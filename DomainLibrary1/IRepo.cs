using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLibrary1
{
    public interface IRepo
    {

        IEnumerable<StoreLocation> GetStores();
        IEnumerable<Pizzahistory>GetPizzahistories (string id);
        Customers LogIn(string id);
        void addPizza(Pizzahistory newPizza);
        IEnumerable <Inventory> GetInventory();
        void insertCustomer(Customers newCustomer);
        void insertAddress(CustomerAddress newAddress);
        void Save();
        Pizzahistory LastOne(string id);//new

        IEnumerable<Customers> GetCustomers();
        IEnumerable<CustomerAddress> GetAddresses();
        IEnumerable<Pizzahistory> GetPizza();
        IEnumerable<Pizzahistory> GetPizzahistories(int id);//new

        //

    }
}
