using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace FoodOrderingWebsite.Models
{


    public class FoodOrdering
    {
        private MySqlConnection CreateConnection()
       {
             string connection = "server=localhost;database=FoodOrderingWebsite;user=root;password=Root@123;port=3306";
             MySqlConnection con = new MySqlConnection(connection);
             con.Open();
             return con;
       }

        public List<Address> addresses = new List<Address>();
        public List<Customer> customers = new List<Customer>();
        public List<Order> orders = new List<Order>();
        public List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> appetizers = new List<Recipe>();
        public List<Recipe> mainCourses = new List<Recipe>();
        public List<Recipe> desserts = new List<Recipe>();
        public List<Recipe> drinks = new List<Recipe>();

        public List<Recipe> getAppetizersFromDB()
        {
          List<Recipe> appetizers = new List<Recipe>();

          // creating and opening the mysql connection
          var con = this.CreateConnection();

          // creating the mysql command/query that I want to run
          MySqlCommand cmd = new MySqlCommand("select * from recipes where category = 'Appetizer'", con);

          // executy the command
          var result = cmd.ExecuteReader();

          while(result.Read())
          {
            Recipe recipe = new Recipe();
            recipe.Id = Convert.ToInt32(result["id"]);
            recipe.Name = result["name"].ToString();
            recipe.Description = result["description"].ToString();
            recipe.Ingredients = result["ingredients"].ToString();
            recipe.Category = result["category"].ToString();
            recipe.Price = Convert.ToInt32(result["price"]);
            recipe.Rating = Convert.ToInt32(result["rating"]);
            recipe.PictureUrl = result["pictureUrl"].ToString();
            appetizers.Add(recipe);
          } 

          con.Close();
          return appetizers;
        }

        
        public List<Recipe> getMainCoursesFromDB()
        {
          List<Recipe> mainCourses = new List<Recipe>();

          // creating and opening the mysql connection
          var con = this.CreateConnection();

          // creating the mysql command/query that I want to run
          MySqlCommand cmd = new MySqlCommand("select * from recipes where category = 'MainCourse'", con);

          // executy the command
          var result = cmd.ExecuteReader();

          while(result.Read())
          {
            Recipe recipe = new Recipe();
            recipe.Id = Convert.ToInt32(result["id"]);
            recipe.Name = result["name"].ToString();
            recipe.Description = result["description"].ToString();
            recipe.Ingredients = result["ingredients"].ToString();
            recipe.Category = result["category"].ToString();
            recipe.Price = Convert.ToInt32(result["price"]);
            recipe.Rating = Convert.ToInt32(result["rating"]);
            recipe.PictureUrl = result["pictureUrl"].ToString();
            mainCourses.Add(recipe);
          } 

          con.Close();
          return mainCourses;
        }
        public List<Recipe> getDessertsFromDB()
        {
          List<Recipe> desserts = new List<Recipe>();

          // creating and opening the mysql connection
          var con = this.CreateConnection();

          // creating the mysql command/query that I want to run
          MySqlCommand cmd = new MySqlCommand("select * from recipes where category = 'Dessert'", con);

          // executy the command
          var result = cmd.ExecuteReader();

          while(result.Read())
          {
            Recipe recipe = new Recipe();
            recipe.Id = Convert.ToInt32(result["id"]);
            recipe.Name = result["name"].ToString();
            recipe.Description = result["description"].ToString();
            recipe.Ingredients = result["ingredients"].ToString();
            recipe.Category = result["category"].ToString();
            recipe.Price = Convert.ToInt32(result["price"]);
            recipe.Rating = Convert.ToInt32(result["rating"]);
            recipe.PictureUrl = result["pictureUrl"].ToString();
            desserts.Add(recipe);
          } 

          con.Close();
          return desserts;
        }

        public List<Recipe> getRecipesFromDB()
        {
          List<Recipe> recipes = new List<Recipe>();

          // creating and opening the mysql connection
          var con = this.CreateConnection();

          // creating the mysql command/query that I want to run
          MySqlCommand cmd = new MySqlCommand("select * from recipes", con);

          // executy the command
          var result = cmd.ExecuteReader();

          while(result.Read())
          {
            Recipe recipe = new Recipe();
            recipe.Id = Convert.ToInt32(result["id"]);
            recipe.Name = result["name"].ToString();
            recipe.Description = result["description"].ToString();
            recipe.Ingredients = result["ingredients"].ToString();
            recipe.Category = result["category"].ToString();
            recipe.Price = Convert.ToInt32(result["price"]);
            recipe.Rating = Convert.ToInt32(result["rating"]);
            recipe.PictureUrl = result["pictureUrl"].ToString();
            recipes.Add(recipe);
          } 
          con.Close();
          return recipes;
        }
        
        
        public Recipe getRecipe(int id)
         {
             var con = this.CreateConnection();
             string cmdText = $"select * from recipes where id = {id}";
             MySqlCommand cmd = new MySqlCommand(cmdText, con);
             var result = cmd.ExecuteReader();

             Recipe r = new Recipe();

             while(result.Read())
             {
                 r.Id = Convert.ToInt32(result["id"]);
                 r.Name = result["name"].ToString();
                 r.Description = result["description"].ToString();
                 r.Ingredients = result["ingredients"].ToString();
                 r.Category = result["category"].ToString();
                 r.Price = Convert.ToDouble(result["price"]);
                 r.Rating = Convert.ToDouble(result["rating"]);
                 r.PictureUrl = result["pictureUrl"].ToString();
             }
             return r;
         }
         public void UpdateRecipe(int id, string name, string description, string ingredients, string category, double price, double rating, string pictureUrl)
         {
            var con = this.CreateConnection();
            string cmdText= $"update recipes set name='{name}', description='{description}', ingredients='{ingredients}', category='{category}',price = {price}, rating = {rating}, '{pictureUrl}' where id={id};";
            MySqlCommand cmd = new MySqlCommand(cmdText,con);
            cmd.ExecuteNonQuery();
            con.Close();
         }
         public void deleteRecipe(int id)
        {
            var con = this.CreateConnection();
            string cmdText= $"delete from recipes where id = {id}";
            MySqlCommand cmd = new MySqlCommand(cmdText,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Customer//

        public List<Customer> getCustomersFromDB()
        {
          List<Customer> customers = new List<Customer>();

          // creating and opening the mysql connection
          var con = this.CreateConnection();

          // creating the mysql command/query that I want to run
          MySqlCommand cmd = new MySqlCommand("select * from customers", con);

          // executy the command
          var result = cmd.ExecuteReader();

          while(result.Read())
          {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(result["id"]);
            customer.FirstName = result["firstName"].ToString();
            customer.LastName = result["lastName"].ToString();
            customer.Email = result["email"].ToString();
            customer.Password = result["password"].ToString();
            customer.Phone = result["phone"].ToString();
            customers.Add(customer);
          } 
          con.Close();
          return customers;
        }
        
        
        public Customer getCustomer(int id)
         {
             var con = this.CreateConnection();
             string cmdText = $"select * from customers where id = {id}";
             MySqlCommand cmd = new MySqlCommand(cmdText, con);
             var result = cmd.ExecuteReader();

             Customer c = new Customer();

             while(result.Read())
             {
              c.Id = Convert.ToInt32(result["id"]);
              c.FirstName = result["firstName"].ToString();
              c.LastName = result["lastName"].ToString();
              c.Email = result["email"].ToString();
              c.Password = result["password"].ToString();
              c.Phone = result["phone"].ToString();
             }
             return c;
         }
         public void UpdateCustomer(int id, string firstName, string lastName, string email, string password, string phone)
         {
            var con = this.CreateConnection();
            string cmdText= $"update customers set firstName='{firstName}', lastName='{lastName}', email='{email}', password='{password}',phone = '{phone}' where id={id};";
            MySqlCommand cmd = new MySqlCommand(cmdText,con);
            cmd.ExecuteNonQuery();
            con.Close();
         }
         public void deleteCustomer(int id)
        {
            var con = this.CreateConnection();
            string cmdText= $"delete from customers where id = {id}";
            MySqlCommand cmd = new MySqlCommand(cmdText,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Customer> searchCustomersByName(string name)
        {
            List<Customer> customers = new List<Customer>();
            var con = this.CreateConnection();
            // creating the mysql command/query that I want to run
              MySqlCommand cmd = new MySqlCommand($"select * from customers where firstname like '%{name}%' or lastName like '%{name}%'", con);
             var result = cmd.ExecuteReader();
             // prepare our result
             while(result.Read())
             {
               Customer customer = new Customer();
               customer.Id = Convert.ToInt32(result["id"]);
               customer.FirstName = result["firstName"].ToString();
               customer.LastName = result["lastName"].ToString();
               customer.Email = result["email"].ToString();
               customer.Password = result["password"].ToString();
               customer.Phone = result["phone"].ToString();
               customers.Add(customer);                 
             }
             con.Close();
             return customers;
        }
        
        public void addCustomerToDB(Customer c)
         {
           var con = this.CreateConnection();
            // creating the mysql command/query that I want to run
              MySqlCommand cmd = new MySqlCommand($"insert into customers(firstName, lastName, email, password, phone) values ('{c.FirstName}', '{c.LastName}', '{c.Email}', '{c.Password}', {c.Phone});", con);
             cmd.ExecuteNonQuery();
         }

        





        

        public List<Recipe> searchRecipeByName(string name)
        {
            List<Recipe> recipes = new List<Recipe>();
            var con = this.CreateConnection();
            // creating the mysql command/query that I want to run
              MySqlCommand cmd = new MySqlCommand($"select * from recipes where name like '%{name}%'", con);
             var result = cmd.ExecuteReader();
             // prepare our result
             while(result.Read())
             {
               Recipe recipe = new Recipe();
               recipe.Id = Convert.ToInt32(result["id"]);
               recipe.Name = result["name"].ToString();
               recipe.Description = result["description"].ToString();
               recipe.Ingredients = result["ingredients"].ToString();
               recipe.Category = result["category"].ToString();
               recipe.Price = Convert.ToInt32(result["price"]);
               recipe.Rating = Convert.ToInt32(result["rating"]);
               recipe.PictureUrl = result["pictureUrl"].ToString();
               recipes.Add(recipe);                 
             }
             con.Close();
             return recipes;
        }
        public void addRecipeToDB(Recipe r)
         {
           var con = this.CreateConnection();
            // creating the mysql command/query that I want to run
              MySqlCommand cmd = new MySqlCommand($"insert into recipes(Name, Description, Ingredients, Category, Price, Rating, PictureUrl) values ('{r.Name}', '{r.Description}', '{r.Ingredients}', '{r.Category}', {r.Price}, {r.Rating}, '{r.PictureUrl}');", con);
             cmd.ExecuteNonQuery();
         }


         //Orders
         public List<Order> getOrdersFromDB()
        {
          List<Order> orders = new List<Order>();

          // creating and opening the mysql connection
          var con = this.CreateConnection();

          // creating the mysql command/query that I want to run
          MySqlCommand cmd = new MySqlCommand("select * from orders", con);

          // executy the command
          var result = cmd.ExecuteReader();

          while(result.Read())
          {
            Order order = new Order();
            order.Id = Convert.ToInt32(result["id"]);
            order.CreationDate = result["creationDate"].ToString();
            order.DeleveryDate = result["deleveryDate"].ToString();
            order.CustomerId = Convert.ToInt32(result["customerId"]);
            order.Status = result["status"].ToString();
            order.Cost = Convert.ToDouble(result["cost"]);
            orders.Add(order);
          } 
          con.Close();
          return orders;
        }
        
        
        public Order getOrder(int id)
         {
             var con = this.CreateConnection();
             string cmdText = $"select * from orders where id = {id}";
             MySqlCommand cmd = new MySqlCommand(cmdText, con);
             var result = cmd.ExecuteReader();

             Order o = new Order();

             while(result.Read())
             {
              o.Id = Convert.ToInt32(result["id"]);
              o.CreationDate = result["creationDate"].ToString();
              o.DeleveryDate = result["deleveryDate"].ToString();
              o.CustomerId = Convert.ToInt32(result["customerId"]);
              o.Status = result["status"].ToString();
              o.Cost = Convert.ToDouble(result["cost"]);
             }
             return o;
         }

         public List<Order> searchOrderById(int id)
        {
            List<Order> orders = new List<Order>();
            var con = this.CreateConnection();
            // creating the mysql command/query that I want to run
              MySqlCommand cmd = new MySqlCommand($"select * from orders where id ='{id}'", con);
             var result = cmd.ExecuteReader();
             // prepare our result
             while(result.Read())
             {
               Order order = new Order();
               order.Id = Convert.ToInt32(result["id"]);
               order.CreationDate = result["creationDate"].ToString();
               order.DeleveryDate = result["deleveryDate"].ToString();
               order.CustomerId = Convert.ToInt32(result["customerId"]);
               order.Status = result["status"].ToString();
               order.Cost = Convert.ToDouble(result["cost"]);
               orders.Add(order);                 
             }
             con.Close();
             return orders;
        }

        public void addOrderToDB(Order o)
         {
           var con = this.CreateConnection();
            // creating the mysql command/query that I want to run
              MySqlCommand cmd = new MySqlCommand($"insert into orders(creationDate, deleveryDate, customerId, status, cost) values ('{o.CreationDate}', '{o.DeleveryDate}', {o.CustomerId}, '{o.Status}', {o.Cost});", con);
             cmd.ExecuteNonQuery();
         }
         public void deleteOrder(int id)
        {
            var con = this.CreateConnection();
            string cmdText= $"delete from orders where id = {id}";
            MySqlCommand cmd = new MySqlCommand(cmdText,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateOrder(int id, string creationDate, string deleveryDate, int customerId, string status, double cost)
         {
            var con = this.CreateConnection();
            string cmdText= $"update orders set creationDate='{creationDate}', deleveryDate='{deleveryDate}', customerId={customerId}, status='{status}',cost = {cost} where id={id};";
            MySqlCommand cmd = new MySqlCommand(cmdText,con);
            cmd.ExecuteNonQuery();
            con.Close();
         }

         public Boolean LoginCustomer(string email, string password)
         {

            var con = this.CreateConnection(); // call the connection function to get the connection
            string cmdText = $"select * from customers where email = '{email}' and password = '{password}'"; // creating the query
            MySqlCommand cmd = new MySqlCommand(cmdText, con); // creating the mysql command
            var result = cmd.ExecuteReader(); // executing the query
             if(result.HasRows) // check whether query result has any rows or not
             {
               return true;
             }
             return false;
         }

         
         public Boolean LoginAdmin(string email, string password)
         {
            var con = this.CreateConnection(); // call the connection function to get the connection
            string cmdText = $"select * from customers where email = '{email}' and password = '{password}' and privileges = 'admin'"; // creating the query
            MySqlCommand cmd = new MySqlCommand(cmdText, con); // creating the mysql command
            var result = cmd.ExecuteReader(); // executing the query
             if(result.HasRows) // check whether query result has any rows or not
             {
               return true;
             }
             return false;
         }



        



    }

}