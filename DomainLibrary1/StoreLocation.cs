using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DomainLibrary1
{
    public class StoreLocation
    {
        [DisplayName("Store ID")]
        public int StoreId { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Zipcode")]
        public string ZipCode { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
    }
}
