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
        [HttpGet("History")]
        public IActionResult History()
        {
            return View(nameof(History));
        }
        // GET: Pizza/Details/5
        [HttpPost("History")]
        public ActionResult History(string id)
        {
            var temp = db.GetPizzahistories(id);
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
        public ActionResult PizzaOrder(IFormCollection collection,Models.Pizzahistory pizza)
        {
            
            //var pizzas = db.addPizza();
            DomainLibrary1.Pizzahistory ph = new Pizzahistory();
            ph.UserId = TempData["UserId"].ToString();
            
            ph.Size = pizza.Size;
            ph.StoreId = 1;//need to store it
            //ph.Orderid = pizza.Orderid;
            ph.StoreId = 1;
            ph.Crust = pizza.Crust;
            ph.Orderdate = DateTime.Now;
            ph.Topping1 = pizza.Topping1;
            ph.Topping2 = pizza.Topping2;
            ph.Topping3 = pizza.Topping3;
            ph.Topping4 = pizza.Topping4;
            ph.Topping5 = pizza.Topping5;
            TempData["UserId"] = ph.UserId;
            //db.addPizza(ph);
            //db.Save();
            //return RedirectToAction(nameof(Index));
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