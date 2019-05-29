using System;
using System.Collections.Generic;

namespace PizzaBoxContext.Context
{
    public partial class Customers
    {
        public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Accesslvl { get; set; }
        public string Password { get; set; }
    }
}
