using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class StoreLocation
    {
        public int StoreId { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}
