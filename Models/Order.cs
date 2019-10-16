namespace FoodOrderingWebsite.Models
{
    public class Order
    {
        public int Id {set; get;}
        public int CustomerId {set; get;}
        public string CreationDate {set; get;}
        public string DeleveryDate {set; get;}
        public string Status {set; get;}
        public double Cost {set; get;}
    }
}