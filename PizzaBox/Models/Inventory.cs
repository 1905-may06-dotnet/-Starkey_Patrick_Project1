using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class Inventory
    {
        
        public int StoreId { get; set; }
        [DisplayName("Ham")]
        public int? Ham { get; set; }
        [DisplayName("Bacon")]
        public int? Bacon { get; set; }
        [DisplayName("Mushroom")]
        public int? Mushroom { get; set; }
        [DisplayName("Peperoni")]
        public int? Peperoni { get; set; }
        [DisplayName("Anchovies")]
        public int? Anchovies { get; set; }
        [DisplayName("Cheese")]
        public int? Cheese { get; set; }
        [DisplayName("Dough")]
        public int? Dough { get; set; }
    }
}
