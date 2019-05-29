using System;
using System.Collections.Generic;

namespace PizzaBoxContext.Context
{
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            Pizzahistory = new HashSet<Pizzahistory>();
        }

        public string UserId { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<Pizzahistory> Pizzahistory { get; set; }
    }
}
