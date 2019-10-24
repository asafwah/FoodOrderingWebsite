namespace FoodOrderingWebsite.Models
{
    public class OrderRecipes
    {
        public int Id {set; get;}
        public int CustomerId {set; get;}
        public int OrderId {set; get;}
        public int RecipeId {set; get;}
        public int Quantity {set; get;}
        public string RecipeName {set; get;}
    }
}

