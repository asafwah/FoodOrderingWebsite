using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Http;

namespace FoodOrderingWebsite.Controllers
{
    public class OrdersController : Controller

    {
        public IActionResult Index()
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["orders"] = fo.getOrdersFromDB();
            ViewData["allOrderRecipes"] = fo.getAllOrderRecipesFromDB();
            return View();
        }

        public IActionResult Cart()
        {

            var user = HttpContext.Session.GetString("user");
            if(user == null)
            {
                return Redirect("/auth/Login");
            }
            else
            {
                FoodOrdering fo = new FoodOrdering();
                int CustomerId = fo.GetCustomerId(user);
                List<Cart> carts = new List<Cart>();
                ViewData["carts"] = fo.GetCustomerCart(CustomerId);
                return View();
            }       
        }

        
        public IActionResult SearchOrders(int SearchInt)
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["orders"] = fo.searchOrderById(SearchInt);
            return View();
        }
        
        [HttpGet]
        public IActionResult addOrder()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult addOrder(IFormCollection formCollection)
        {

            Order neworder = new Order();
            foreach (var item in formCollection)
            {
                if(item.Key == "CustomerId")
                {
                    neworder.CustomerId = Int32.Parse(item.Value);
                }
                if(item.Key == "CreationDate")
                {
                    neworder.CreationDate = item.Value;
                }
                if(item.Key == "DeleveryDate")
                {
                    neworder.DeleveryDate = item.Value;
                }
                if(item.Key == "Status")
                {
                    neworder.Status  = item.Value;
                }
                if(item.Key == "Cost")
                {
                    neworder.Cost  = double.Parse(item.Value);
                }

            }

            FoodOrdering fo = new FoodOrdering();

           fo.addOrderToDB(neworder);
            return Redirect("/Orders/Index");
        }
        [HttpPost]
        public RedirectResult DeleteOrder(int id)
        {
            FoodOrdering os = new FoodOrdering();
            os.deleteOrder(id);
            return Redirect("/Orders/Index");
        }
        public IActionResult UpdateOrder(int id)
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["order"]= fo.getOrder(id);
            return View();
        }
        [HttpPost]
        public RedirectResult UpdateOrder(int id, string creationDate, string deleveryDate, int customerId, string status, double cost)
        {
            FoodOrdering fo = new FoodOrdering();
            fo.UpdateOrder(id,creationDate,deleveryDate,customerId,status,cost);
            return Redirect("/Orders/Index");
        }
        [HttpPost]
        public RedirectResult DeleteCart(int id)
        {
            FoodOrdering os = new FoodOrdering();
            os.deleteCart(id);
            return Redirect("/Orders/Cart");
        }
        [HttpPost]
        public RedirectResult addToCart(int id)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == null)
            {
                return Redirect("/auth/Login");
            }
            else
            {
                FoodOrdering fo = new FoodOrdering();
                int CustomerId = fo.GetCustomerId(user);
                List<Cart> carts = new List<Cart>();
                fo.AddRecipeToCart(CustomerId, id);
                return Redirect("/home/allRecipes");
                //ViewData["recipes"] = fo.searchRecipeByName(SearchText);
                //return View();
            }
            
        }
        

        
        [HttpPost]
        public RedirectResult OrderCart(int id)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == null)
            {
                return Redirect("/auth/Login");
            }
            else
            {
                FoodOrdering fo = new FoodOrdering();
                List<Cart> carts = fo.GetCustomerCart(id);
                Customer customer = fo.getCustomer(id);
                Order neworder = new Order();
                //how to add customerId to below number?
                //int orderId=Int32.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
                //neworder.Id=orderId;
                neworder.CustomerId= id;
                neworder.CreationDate=DateTime.Now.Date.ToString();
                neworder.DeleveryDate=DateTime.Today.AddDays(2).ToString();
                neworder.Status="Pending";
                double tempTotalPrice = 0;
                foreach (var item in carts)
                {
                    tempTotalPrice= tempTotalPrice + item.TotalPrice;
                }
                neworder.Cost=tempTotalPrice; 
                fo.addOrderToDB(neworder);
                int lastOrderId=fo.getLastOrderIdfroDB();
                foreach (var item in carts)
                {
                    fo.AddRecipeToOrderRecipe(lastOrderId, item.RecipeId, item.Quantity, item.RecipeName);
                    tempTotalPrice= tempTotalPrice + item.TotalPrice;
                }
                fo.clearCustomerCart(id);
                
                //fo.emptyCart(customerId);
                return Redirect("/home/Index");

            }  


            
        }
        

        
        
    }
}