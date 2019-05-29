using System;
using System.Collections.Generic;

namespace PizzaBoxContext.Context
{
    public partial class Inventory
    {
        public int StoreId { get; set; }
        public int? Ham { get; set; }
        public int? Bacon { get; set; }
        public int? Mushroom { get; set; }
        public int? Peperoni { get; set; }
        public int? Anchovies { get; set; }
        public int? Cheese { get; set; }
        public int? Dough { get; set; }
    }
}
