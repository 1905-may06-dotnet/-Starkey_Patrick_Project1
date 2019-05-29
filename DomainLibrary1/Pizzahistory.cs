using System;
namespace DomainLibrary1
{
    public class Pizzahistory
    {
        private string _UserId;
        private string _Size;
        private string _Crust;
        private string _Topping1;
        private string _Topping2;
        private string _Topping3;
        private string _Topping4;
        private string _Topping5;
        private DateTime? _Orderdate;
        private int? _StoreId;
        private int _Orderid;
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
        public int Orderid { get; set; }//primary key



    }
}