using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLibrary1
{
    public interface IRepo
    {

        //getsCustomers user and
        IEnumerable<Pizzahistory>GetPizzahistories (string id);
        Customers LogIn(string id);
        void addPizza(Pizzahistory newPizza);
        Inventory GetInventory(int storeid);
        void insertCustomer(Customers newCustomer);
        void insertAddress(CustomerAddress newAddress);
        void Save();
        IEnumerable<Customers> GetCustomers();
        IEnumerable<CustomerAddress> GetAddresses();
        IEnumerable<Pizzahistory> GetPizza();

        //

    }
}
