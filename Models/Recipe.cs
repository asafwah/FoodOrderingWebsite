namespace FoodOrderingWebsite.Models
{
    using System.Collections.Generic;
    public class Recipe
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Description{get; set;}
        public string Ingredients{get; set;}
        public string Category{get; set;}
        public double Price{get; set;}
        public double Rating{get; set;}
        public string PictureUrl {get; set;}
    }

    public class Appetizer : Recipe
    {}
    public class MainCourse : Recipe
    {}
    public class Dessert : Recipe
    {}
    public class Drink : Recipe
    {}

}
