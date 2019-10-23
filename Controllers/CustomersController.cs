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
    public class CustomersController : Controller

    {
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["customers"] = fo.getCustomersFromDB();
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
            
        }

        
        public IActionResult SearchCustomers(string SearchText)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["customers"] = fo.searchCustomersByName(SearchText);
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
            
        }
        
        [HttpGet]
        public IActionResult addCustomer()
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

        [HttpPost]
        public RedirectResult addCustomer(IFormCollection formCollection)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                Customer newcustomer = new Customer();
                foreach (var item in formCollection)
                {
                    if(item.Key == "FirstName")
                    {
                        newcustomer.FirstName = item.Value;
                    }
                    if(item.Key == "LastName")
                    {
                        newcustomer.LastName = item.Value;
                    }
                    if(item.Key == "Email")
                    {
                        newcustomer.Email = item.Value;
                    }
                    if(item.Key == "Password")
                    {
                        newcustomer.Password = item.Value;
                    }
                    if(item.Key == "Phone")
                    {
                        newcustomer.Phone = item.Value;
                    }
                }
                FoodOrdering fo = new FoodOrdering();
                fo.addCustomerToDB(newcustomer);
                return Redirect("/Customers/Index");
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }

            
        }
        
        public RedirectResult DeleteCustomer(int id)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering os = new FoodOrdering();
                os.deleteCustomer(id);
                return Redirect("/Customers/Index");
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }


            
        }
        public IActionResult UpdateCustomer(int id)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                ViewData["customer"]= fo.getCustomer(id);
                return View();
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
        }
        [HttpPost]
        public RedirectResult UpdateCustomer(int id, string firstName, string lastName, string email, string password, string phone)
        {
            var user = HttpContext.Session.GetString("user");
            if(user == "admin")
            {
                FoodOrdering fo = new FoodOrdering();
                fo.UpdateCustomer(id,firstName,lastName,email, password, phone);
                return Redirect("/Customers/Index");
            }
            else
            {
                return Redirect("/auth/adminLogin");
            }
        }        
    }
}