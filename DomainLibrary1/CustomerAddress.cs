using System;

namespace DomainLibrary1
{
    public class CustomerAddress
    {

        private string _userid;
        public string Street { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }


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
    }
}