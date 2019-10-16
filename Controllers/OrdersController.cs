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
            return View();
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

        
        
    }
}