namespace FoodOrderingWebsite.Models
{
    public class Cart
    {
        public int Id {set; get;}
        public int CustomerId {set; get;}
        public int RecipeId {set; get;}
        public string RecipeName {set; get;}
        public string PictureUrl {set; get;}
        public int Quantity {set; get;}
        public double Price {set; get;}
        public double TotalPrice {set; get;}
        public string Status {set; get;}
    }
}

