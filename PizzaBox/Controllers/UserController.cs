using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainLibrary1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBoxClient.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepo db;
        public UserController(IRepo db)
        {
            this.db = db;
        }

        Models.Customers c;
        //Models.CustomerAddress a;
        List<Models.Customers> customersList = new List<Models.Customers>();
        //List<Models.CustomerAddress> AddressesList = new List<Models.CustomerAddress>();

        // GET: User
        public ActionResult Index()
        {
            var custs = db.GetCustomers();
            foreach (var cust in custs)
            {
                c = new Models.Customers();
                
                c.Userid = cust.Userid;
                c.Accesslvl = cust.Accesslvl;
                c.Firstname = cust.Firstname;
                c.Lastname = cust.Lastname;
                c.password = cust.password;
                customersList.Add(c);
            }

            //var addres = db.GetAddresses();
            //foreach (var ad in addres)
            //{
            //    a.Userid = ad.Userid;
            //    a.Street = ad.Street;
            //    a.State = ad.State;
            //    a.City = ad.City;
            //    a.ZipCode = ad.ZipCode;
            //    AddressesList.Add(a);
            //}
            return View();

            
        }

        // GET: User/Details/5
        //[HttpGet]
        //public ActionResult Login(Models.Customers customers)
        //{
        //    return View();
        //}
        [HttpGet("Login")]
       public ActionResult LogIn(Models.Customers customers)
        {
            return View();
        }
        [HttpPost("Login")]
        public ActionResult Login(string UserId, string Password,Models.Customers customers)
        {
           var temp= db.LogIn(UserId);

            try
            {
                if (temp.password == Password)
                {
                    //HttpContext.Session.SetString("UserId",UserId);
                    TempData["UserId"] = UserId;
                    return RedirectToAction("PizzaOrder","Pizza");
                }
                else
                {
                    return View();
                }


            }
            catch
            {
                return View();
            }
        }

        private ActionResult View(string v, Func<ActionResult> menu)
        {
            throw new NotImplementedException();
        }

 //       [HttpGet]
 //public ActionResult Menu()
 //       {
 //           return View();
 //       }










        // GET: User/Create
        //public ActionResult Create()
        //{
        //    //DomainLibrary1.Customers customers = new Customers();
        //    //customers
        //    return View();
        //}

        //// POST: User/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: User/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: User/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: User/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: User/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}