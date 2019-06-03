using DomainLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<DomainLibrary1.Customers> GetCustomers()
        {
            return _db.Customers.Select(x => Mapper.Map(x));
        }
        public IEnumerable<DomainLibrary1.CustomerAddress> GetAddresses()
        {
            return _db.CustomerAddress.Select(x => Mapper.Map(x));
        }

        public IEnumerable<Inventory> GetInventory()
        {


            var temp = _db.Inventory.Select(x => Mapper.Map(x));
            return temp;
            //return Mapper.Map(_db.Inventory.AsNoTracking().First(i => i.StoreId == storeid)); lack of sleep
        }
        public IEnumerable<StoreLocation> GetStores()
        {

            var temp = _db.StoreLocation.Select(x => Mapper.Map(x));
            return temp;
        }

        public IEnumerable<Pizzahistory> GetPizzahistories(string id)
        {
            return Mapper.Map(_db.Pizzahistory.Where(i => i.UserId.Contains(id)));

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
            
            return Mapper.Map(_db.Customers.Find(id));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public IEnumerable<Pizzahistory> GetPizza()
        {
            return _db.Pizzahistory.Select(x => Mapper.Map(x));
        }

        public Pizzahistory LastOne(string id)
        {
            return Mapper.Map(_db.Pizzahistory.Where(i => i.UserId.Contains(id)).OrderByDescending(i=>i.Orderid).First());
        }

        public IEnumerable<Pizzahistory> GetPizzahistories(int id)
        {
            return Mapper.Map(_db.Pizzahistory.Where(i => i.StoreId==id));
        }
    }
}
