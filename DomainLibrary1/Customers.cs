using System;
using System.Collections.Generic;
using System.Linq;



namespace DomainLibrary1
{
    public class Customers
    {
        private string _userid;
        private string _password;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Accesslvl { get; set; }
        public string Userid
        {
            get => _userid;
            set
            {
                if (value.Length == 0)
                {

                    throw new ArgumentException("userID must not be empty.", nameof(value));



                }
                _userid = value;
            }
        }
        public string password
        {
            get => _password;
            set
            {
                if (value.Length == 0)
                {

                    throw new ArgumentException("password must not be empty.", nameof(value));



                }
                _password = value;
            }
        }


    }
}