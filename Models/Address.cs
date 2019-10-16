namespace FoodOrderingWebsite.Models
{
    public class Address
    {
        public int Id {set; get;}
        public int CustomerId {set; get;}
        public string Description {set; get;}
        public string Unit {set; get;}
        public string Building {set; get;}
        public string Street {set; get;}
        public string City {set; get;}
        public string Province {set; get;}
        public string Country {set; get;}
        public string PostalCode {set; get;}
    }
}