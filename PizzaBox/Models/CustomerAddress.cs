using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class CustomerAddress
    {
        

        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        public string Userid { get; set; }
    }
}
