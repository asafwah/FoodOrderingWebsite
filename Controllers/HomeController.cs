using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using MySql.Data.MySqlClient;



namespace FoodOrderingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FoodOrdering fo = new FoodOrdering();
            List<Recipe> recipes = fo.getRecipesFromDB();
            Recipe appetizerItem = null;
            Recipe mainCourseItem = null;
            Recipe dessertItem = null;
            foreach (var item in recipes)
            {
                if(item.Category == "Appetizer" && appetizerItem == null){
                    appetizerItem = item;
                    ViewData["appetizerItem"] = appetizerItem;
                }
                if(item.Category == "MainCourse" && mainCourseItem == null){
                    mainCourseItem = item;
                    ViewData["mainCourseItem"] = mainCourseItem;
                }
                if(item.Category == "Dessert" && dessertItem == null){
                    dessertItem = item;
                    ViewData["dessertItem"] = dessertItem;
                }
            }
            return View();
        }

        public IActionResult Appetizers()
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["appetizers"] = fo.getAppetizersFromDB();
            ViewData["recipes"] = fo.getRecipesFromDB();
            return View();
        }
        public IActionResult mainCourses()
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["mainCourses"] = fo.getMainCoursesFromDB();
            ViewData["recipes"] = fo.getRecipesFromDB();
            return View();
        }
        public IActionResult desserts()
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["desserts"] = fo.getDessertsFromDB();
            ViewData["recipes"] = fo.getRecipesFromDB();
            
            return View();
        }
        [HttpGet]
        public IActionResult searchRecipes(string SearchText)
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["recipes"] = fo.searchRecipeByName(SearchText);
            return View();
        }
        public IActionResult admin()
        {


            // check whether user has a valid session or not. if not we wanna restrict the user from about page
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["recipes"] = fo.getRecipesFromDB();
                ViewData["customers"] = fo.getCustomersFromDB();
                return View();
            }
            else
            {
              return Redirect("/auth/adminLogin");
            }
        }
        
        public IActionResult adminAllRecipes()
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["recipes"] = fo.getRecipesFromDB();
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
        }
        public IActionResult allRecipes()
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["recipes"] = fo.getRecipesFromDB();
            return View();
        }
        
        public IActionResult adminSearchRecipes(string SearchText)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["recipes"] = fo.searchRecipeByName(SearchText);
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
            
        }

        [HttpGet]
        public IActionResult addRecipe()
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
        }

        //

         [HttpPost]
        public IActionResult addRecipe(string name, string description, string ingredients, string category, double price, double rating, IFormFile picture)
        {

            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                string pictureUrl = null;
                if(picture.Length > 0)
                {
                    var fileName = Path.GetFileName(picture.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", fileName);
                    var stream = new FileStream(filePath, FileMode.Create);
                    picture.CopyTo(stream);
                    pictureUrl = "/images/" + fileName;
                    }

                    Recipe newrecipe = new Recipe();
                    newrecipe.Name = name;
                    newrecipe.Description = description;
                    newrecipe.Ingredients = ingredients;
                    newrecipe.Category = category;             
                    newrecipe.Price = price;
                    newrecipe.Rating = rating;              
                    newrecipe.PictureUrl = pictureUrl;

                    FoodOrdering fo = new FoodOrdering();

                fo.addRecipeToDB(newrecipe);
                    return Redirect("/home/admin");

                }
            else
            {
                return Redirect("/auth/adminLogin");
            }

        }
        public IActionResult UpdateRecipe(int id)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["recipe"]= fo.getRecipe(id);
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
        }
        [HttpPost]
        public RedirectResult UpdateRecipe(int id, string name, string description, string ingredients, string category, double price, double rating, IFormFile picture, string oldPictureUrl)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                string pictureUrl = null;
                if (picture == null)
                {
                    pictureUrl =oldPictureUrl;
                }
                else if(picture.Length > 0)
                {
                var fileName = Path.GetFileName(picture.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", fileName);
                var stream = new FileStream(filePath, FileMode.Create);
                picture.CopyTo(stream);
                pictureUrl = "/images/" + fileName;
                }
                FoodOrdering fo = new FoodOrdering();
                fo.UpdateRecipe(id,name,description,ingredients, category, price, rating, pictureUrl);
                return Redirect("/home/admin");
                }
            else
            {
                return Redirect("/auth/adminLogin");
            }
            
        }
        public RedirectResult DeleteRecipe(int id)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                fo.deleteRecipe(id);
                return Redirect("/home/admin");
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
            
        }
        
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
