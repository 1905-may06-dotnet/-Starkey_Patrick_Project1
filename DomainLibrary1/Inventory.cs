using System;
using System.Linq;
namespace DomainLibrary1
{
    public class Inventory
    {
        private int _StoreId;
        private int? _Ham;
        private int? _Bacon;
        private int? _Mushroom;
        private int? _Peperoni;
        private int? _Anchovies;
        private int? _Cheese;
        private int? _Dough;



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