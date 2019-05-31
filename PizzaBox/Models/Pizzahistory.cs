using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class Pizzahistory
    {
        
        public string UserId { get; set; }
        [DisplayName("Size")]
        public string Size { get; set; }
        [DisplayName("Crust")]
        public string Crust { get; set; }
        [DisplayName("Topping 1")]
        public string Topping1 { get; set; }
        [DisplayName("Topping 2")]
        public string Topping2 { get; set; }
        [DisplayName("Topping 3")]
        public string Topping3 { get; set; }
        [DisplayName("Topping 4")]
        public string Topping4 { get; set; }
        [DisplayName("Topping 5")]
        public string Topping5 { get; set; }
        public DateTime? Orderdate { get; set; }
        public int? StoreId { get; set; }
        public int Orderid { get; set; }





    }
}
