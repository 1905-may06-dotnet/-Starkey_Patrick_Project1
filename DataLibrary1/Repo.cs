using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using DomainLibrary1;
namespace PizzaBoxContext
{
    public class Repo : IRepo
    {
        /// <summary>
        /// access db
        /// </summary>
        private readonly PizzaBoxContext.Context.Pizzboxdb _db;

        public Repo(PizzaBoxContext.Context.Pizzboxdb db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }




       
        /// //////////////////////////////

        public void addPizza(Pizzahistory newPizza)
        {
            _db.Pizzahistory.Add(PizzaBoxContext.Mapper.Map(newPizza));
        }

        public Inventory GetInventory(int storeid)
        {
            

            return Mapper.Map(_db.Inventory.Where(i => i.StoreId == storeid).FirstOrDefault());
            //return Mapper.Map(_db.Inventory.AsNoTracking().First(i => i.StoreId == storeid)); lack of sleep
        }
        

        public IEnumerable<Pizzahistory> GetPizzahistories(string id)
        {
            return _db.Pizzahistory.Select(i => Mapper.Map(i));
        }

        public void insertAddress(CustomerAddress newAddress)
        {
            _db.CustomerAddress.Add(Mapper.Map(newAddress));
        }

        public void insertCustomer(Customers newCustomer)
        {
            _db.Customers.Add(PizzaBoxContext.Mapper.Map(newCustomer));
        }

        public Customers LogIn(string id)
        {
            return Mapper.Map(_db.Customers.Where(i => i.UserId == id).FirstOrDefault());
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
