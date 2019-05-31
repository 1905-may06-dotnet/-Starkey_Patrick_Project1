using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class Customers
    {

        [DisplayName("Password")]
        public string password { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "userID can not be empty")]
        public string Userid { get; set; }


        [DisplayName("First Name")]
        public string Firstname { get; set; }
        [DisplayName("Last Name")]
        public string Lastname { get; set; }
        public int? Accesslvl { get; set; }

    }
}
