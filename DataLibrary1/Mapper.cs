using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DomainLibrary1;


namespace PizzaBoxContext
{
    public static class Mapper
    {
        public static DomainLibrary1.Customers Map(PizzaBoxContext.Context.Customers customers) => new DomainLibrary1.Customers
        {
            Userid=customers.UserId,
            password = customers.Password,
            Firstname=customers.Firstname,
            Lastname=customers.Lastname,
            Accesslvl=customers.Accesslvl

        };
        public static PizzaBoxContext.Context.Customers Map(DomainLibrary1.Customers customers) => new Context.Customers
        {
            UserId = customers.Userid,
            Password = customers.password,
            Firstname = customers.Firstname,
            Lastname = customers.Lastname,
            Accesslvl = customers.Accesslvl
        };
        public static DomainLibrary1.CustomerAddress Map(PizzaBoxContext.Context.CustomerAddress customer) => new DomainLibrary1.CustomerAddress
        {
            Userid=customer.UserId,
            City= customer.City,
            State=customer.State,
            Street=customer.Street,
            ZipCode=customer.ZipCode
        };
        public static PizzaBoxContext.Context.CustomerAddress Map(DomainLibrary1.CustomerAddress customer) => new Context.CustomerAddress
        {
            UserId = customer.Userid,
            City = customer.City,
            State = customer.State,
            Street = customer.Street,
            ZipCode = customer.ZipCode
        };
        public static DomainLibrary1.Inventory Map(Context.Inventory inventory) => new DomainLibrary1.Inventory
        {
            StoreId=inventory.StoreId,
            Anchovies=inventory.Anchovies,
            Bacon=inventory.Bacon,
            Cheese=inventory.Cheese,
            Dough=inventory.Dough,
            Ham=inventory.Ham,
            Mushroom=inventory.Mushroom,
            Peperoni=inventory.Peperoni

        };
        public static Context.Inventory Map(DomainLibrary1.Inventory inventory) => new Context.Inventory
        {
            StoreId = inventory.StoreId,
            Anchovies = inventory.Anchovies,
            Bacon = inventory.Bacon,
            Cheese = inventory.Cheese,
            Dough = inventory.Dough,
            Ham = inventory.Ham,
            Mushroom = inventory.Mushroom,
            Peperoni = inventory.Peperoni

        };
        public static DomainLibrary1.Pizzahistory Map(Context.Pizzahistory pizza) => new DomainLibrary1.Pizzahistory
        {
            UserId=pizza.UserId,
            Crust=pizza.Crust,
            Orderdate=pizza.Orderdate,
            Orderid=pizza.Orderid,
            Size=pizza.Size,
            StoreId=pizza.StoreId,
            Topping1=pizza.Topping1,
            Topping2=pizza.Topping2,
            Topping3=pizza.Topping3,
            Topping4=pizza.Topping4,
            Topping5=pizza.Topping5
        };
        public static Context.Pizzahistory Map(DomainLibrary1.Pizzahistory pizza) => new Context.Pizzahistory
        {
            UserId = pizza.UserId,
            Crust = pizza.Crust,
            Orderdate = pizza.Orderdate,
            Orderid = pizza.Orderid,
            Size = pizza.Size,
            StoreId = pizza.StoreId,
            Topping1 = pizza.Topping1,
            Topping2 = pizza.Topping2,
            Topping3 = pizza.Topping3,
            Topping4 = pizza.Topping4,
            Topping5 = pizza.Topping5
        };
        //public static IEnumerable<DomainLibrary1.Customers> Map(IEnumerable<Customers> customers) => customers.Select(Map);



        //public static IEnumerable<Restaurant> Map(IEnumerable<Library.Restaurant> restaurants) => restaurants.Select(Map);



        //public static IEnumerable<Library.Review> Map(IEnumerable<Review> reviews) => reviews.Select(Map);



        //public static IEnumerable<Review> Map(IEnumerable<Library.Review> reviews) => reviews.Select(Map);

    }
}
