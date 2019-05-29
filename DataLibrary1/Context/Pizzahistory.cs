using System;
using System.Collections.Generic;

namespace PizzaBoxContext.Context
{
    public partial class Pizzahistory
    {
        public string UserId { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string Topping4 { get; set; }
        public string Topping5 { get; set; }
        public DateTime? Orderdate { get; set; }
        public int? StoreId { get; set; }
        public int Orderid { get; set; }

        public virtual StoreLocation Store { get; set; }
        public virtual CustomerAddress User { get; set; }
    }
}
