using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainLibrary1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBoxClient.Controllers
{
    public class PizzaController : Controller
    {
        
        private readonly IRepo db;
        Models.Pizzahistory ph;
        DomainLibrary1.PizzaOrder DL = new PizzaOrder();
        //Models.CustomerAddress a;
        List<Models.Pizzahistory> PizzaList = new List<Models.Pizzahistory>();
        public PizzaController(IRepo db)
        {
            this.db = db;

        }




        // GET: Pizza
        public ActionResult Index()
        {
            var pizzas = db.GetPizza();
            foreach(var pizza in pizzas)
            {
                ph = new Models.Pizzahistory();
                ph.UserId = pizza.UserId;
                ph.Size = pizza.Size;
                ph.StoreId = pizza.StoreId;
                ph.Orderid = pizza.Orderid;
                ph.Crust = pizza.Crust;
                ph.Orderdate = pizza.Orderdate;
                ph.Topping1 = pizza.Topping1;
                ph.Topping2 = pizza.Topping2;
                ph.Topping3 = pizza.Topping3;
                ph.Topping4 = pizza.Topping4;
                ph.Topping5 = pizza.Topping5;
                PizzaList.Add(ph);
            }
            return View();
        }
        //[HttpGet("History")]
        //public ActionResult History()
        //{
        //    return View();
        //}
        // GET: Pizza/Details/5
        [HttpGet("History")]
        public ActionResult History(Models.Pizzahistory pizzahistory)
        {
        //InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'System.Collections.Generic.List`1[PizzaBoxClient.Models.Pizzahistory]',
        //    but this ViewDataDictionary instance requires a model item of type 'System.Collections.Generic.IEnumerable`1[PizzaBoxContext.Context.Pizzahistory]'.




            var Userid = TempData["UserId"].ToString();
            TempData["UserId"] = Userid;
            var temp = db.GetPizzahistories(Userid);
            foreach (var p in temp)
            {
                
                ph = new Models.Pizzahistory();
                ph.Crust = p.Crust;
                ph.Size = p.Size;
                ph.Topping1 = p.Topping1;
                ph.Topping2 = p.Topping2;
                ph.Topping3 = p.Topping3;
                ph.Topping4 = p.Topping4;
                ph.Topping5 = p.Topping5;
                PizzaList.Add(ph);

            }

            return View(PizzaList);
        }

        // GET: Pizza/Create
        [HttpGet("PizzaOrder")]
        public ActionResult PizzaOrder()
        {
            return View();
        }
        [HttpPost("PizzaOrder")]
        // POST: Pizza/Create
        public ActionResult PizzaOrder(IFormCollection collection,Models.Pizzahistory pizza,int id)
        {

            if (DL.Count() == true)
            {
                ViewData["Text"] = "invalid pizza quantity";
                return View();
            }
                if (DL.checkcost() == true)
                {
                    //var pizzas = db.addPizza();

                    DomainLibrary1.Pizzahistory ph = new Pizzahistory();
                    ph.UserId = TempData["UserId"].ToString();

                    ph.Size = pizza.Size;
                    ph.StoreId = 1;//need to store it
                                   //ph.Orderid = pizza.Orderid;
                    ph.StoreId = id;
                    ph.Crust = pizza.Crust;
                    ph.Orderdate = DateTime.Now;

                    ph.Topping1 = pizza.Topping1;
                    ph.Topping2 = pizza.Topping2;
                    ph.Topping3 = pizza.Topping3;
                    ph.Topping4 = pizza.Topping4;
                    ph.Topping5 = pizza.Topping5;
                    DL.AddTopping(ph.Topping1);
                    DL.AddTopping(ph.Topping2);
                    DL.AddTopping(ph.Topping3);
                    DL.AddTopping(ph.Topping4);
                    DL.AddTopping(ph.Topping5);
                    TempData["UserId"] = ph.UserId;
                    DL.cost = DL.TotalCost(DL.cost, ph.Size, DL.top);
                    DL.orderCount = DL.orderCount + 1;

                    try
                    {

                        db.addPizza(ph);
                        db.Save();

                        // TODO: Add insert logic here
                        //return View();
                        return RedirectToAction("History");
                    }
                    catch
                    {
                        return View();

                    }



                }
                else
                {
                    ViewData["Text"] = "Your order would go over our $5000 limit.";
                    return View();
                }
            
        }



        Models.StoreLocation l;
        List<Models.StoreLocation> locations = new List<Models.StoreLocation>();
        [HttpGet("Store")]
        public ActionResult Store(Models.StoreLocation location)
        {
            var loca = db.GetStores();
            foreach(var loc in loca)
            {
                l = new Models.StoreLocation();
                l.StoreId = loc.StoreId;
                l.Street = loc.Street;
                l.City = loc.City;
                l.ZipCode = loc.ZipCode;
                l.State = loc.State;
                locations.Add(l);
            }
            return View(locations);
        }
        Models.Inventory i;
        public List<Models.Inventory> inventorylist = new List<Models.Inventory>();
        [HttpGet("Inventory")]
        public ActionResult Inventory(Models.StoreLocation location)
        {
            var inventories = db.GetInventory();
            foreach (var inv in inventories)
            {
                //i = new Models.Inventory();
                //i.StoreId = inv.StoreId;
                //i.Dough= inv.Dough;
                //i.Cheese= inv.Cheese;
                //i.Bacon = inv.Bacon;
                //i.Anchovies = inv.Anchovies;
                //i.Ham = inv.Ham;
                //i.Mushroom = inv.Mushroom;
                //i.Peperoni = inv.Peperoni;

                inventorylist.Add(i);
            }
            return View(inventorylist);
        }




        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}