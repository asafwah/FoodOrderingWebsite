using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebsite.Models;

namespace FoodOrderingWebsite.Controllers
{
  public class AuthController : Controller
  {

    


    public IActionResult adminLogin()
    {
      ViewData["error"] = false;
      ViewData["loginSuccessfull"] = false;
      ViewData["adminNotFound"] = false;
      return View();
    }

    [HttpPost]
    // function to execute when user submits the login form
    public IActionResult adminLogin(string email, string password)
    {
      try
      {
      FoodOrdering fo = new FoodOrdering();
      Boolean AdminExist = fo.LoginAdmin(email, password);             
        if(AdminExist==true) // check whether query result has any rows or not
        {

          HttpContext.Session.SetString("user", "admin"); // setting the the session in HttpContext

          ViewData["error"] = false;
          ViewData["loginSuccessfull"] = true;
          ViewData["adminNotFound"] = false;
          return Redirect("/home/admin");

        }
        else
        {
          ViewData["error"] = false;
          ViewData["loginSuccessfull"] = false;
          ViewData["adminNotFound"] = true;
          return View();
        }

      }
      catch(Exception exception)
      {
        ViewData["error"] = true;
        ViewData["loginSuccessfull"] = false;
        ViewData["adminNotFound"] = false;
        return View();
      }
    }





    public IActionResult Login()
    {
      ViewData["error"] = false;
      ViewData["loginSuccessfull"] = false;
      ViewData["userNotFound"] = false;
      return View();
    }

    [HttpPost]
    // function to execute when user submits the login form
    public IActionResult Login(string email, string password)
    {
      try
      {
      FoodOrdering fo = new FoodOrdering();
      Boolean UserExist = fo.LoginCustomer(email, password);             
        if(UserExist==true) // check whether query result has any rows or not
        {

          HttpContext.Session.SetString("user", email); // setting the the session in HttpContext

          ViewData["error"] = false;
          ViewData["loginSuccessfull"] = true;
          ViewData["userNotFound"] = false;
          return Redirect("/home/Index");

        }
        else
        {
          ViewData["error"] = false;
          ViewData["loginSuccessfull"] = false;
          ViewData["userNotFound"] = true;
          return View();
        }

      }
      catch(Exception exception)
      {
        ViewData["error"] = true;
        ViewData["loginSuccessfull"] = false;
        ViewData["userNotFound"] = false;
        return View();
      }
    }
    // function to execute when logout button is clicked
    public IActionResult Logout()
    {
      HttpContext.Session.Clear(); // clearout the session
      return Redirect("/home/index");
    }

      // function to execute when user clicks on the register
    public IActionResult Register()
    {
      ViewData["registrationSuccessfull"] = false;
      ViewData["error"] = false;
      return View();
    }

    [HttpPost]
    // function to execute when user submit registration form
    public IActionResult Register(string FirstName, string LastName, string Email, string Password, string Phone)
    {
      try
      {
        FoodOrdering fo = new FoodOrdering();
        Customer newcustomer = new Customer();
        newcustomer.FirstName = FirstName;               
        newcustomer.LastName = LastName;               
        newcustomer.Email = Email;              
        newcustomer.Password = Password;             
        newcustomer.Phone = Phone;            
        fo.addCustomerToDB(newcustomer);
        ViewData["registrationSuccessfull"] = true;
        ViewData["error"] = false;
        return View();
      } 
      catch(MySqlException exception)
      {
        ViewData["error"] = true;
        ViewData["registrationSuccessfull"] = false;
        return View();
      }
    }




  }
}
