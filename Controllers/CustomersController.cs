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
            FoodOrdering fo = new FoodOrdering();
            ViewData["customers"] = fo.getCustomersFromDB();
            return View();
        }

        
        public IActionResult SearchCustomers(string SearchText)
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["customers"] = fo.searchCustomersByName(SearchText);
            return View();
        }
        
        [HttpGet]
        public IActionResult addCustomer()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult addCustomer(IFormCollection formCollection)
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
        
        public RedirectResult DeleteCustomer(int id)
        {
            FoodOrdering os = new FoodOrdering();
            os.deleteCustomer(id);
            return Redirect("/Customers/Index");
        }
        public IActionResult UpdateCustomer(int id)
        {
            FoodOrdering fo = new FoodOrdering();
            ViewData["customer"]= fo.getCustomer(id);
            return View();
        }
        [HttpPost]
        public RedirectResult UpdateCustomer(int id, string firstName, string lastName, string email, string password, string phone)
        {
            FoodOrdering fo = new FoodOrdering();
            fo.UpdateCustomer(id,firstName,lastName,email, password, phone);
            return Redirect("/Customers/Index");
        }

        
        
    }
}