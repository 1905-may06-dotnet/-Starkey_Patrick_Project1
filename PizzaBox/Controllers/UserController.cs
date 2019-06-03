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
           


 
            return View();

            
        }

        // GET: User/Details/5
        //[HttpGet]
        //public ActionResult Login(Models.Customers customers)
        //{
        //    return View();
        //}
        [HttpGet("Login")]
       public ActionResult Login(Models.Customers customers)
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
                    return RedirectToAction("Index","Pizza");
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


        [HttpGet("Create")]
        public ActionResult Create()
        {


            return View();
        }






    // GET: User/Create
    [HttpPost("Create")]
        public ActionResult Create(IFormCollection collection,Models.Customers C)
        {
            //DomainLibrary1.CustomerAddress CA = new CustomerAddress();
            DomainLibrary1.Customers Cust = new Customers();
            Cust.Userid = C.Userid;
            Cust.password = C.password;
            Cust.Firstname = C.Firstname;
            Cust.Lastname = C.Lastname;
            Cust.Accesslvl = 1;
            TempData["UserId"] = Cust.Userid;
            try
            {
                db.insertCustomer(Cust);
                db.Save();
            
            }
            catch (Exception)
            {

                return View();
            }


            return RedirectToAction("CreateAddress");
        }

        [HttpGet("CreateAddress")]
        public ActionResult CreateAddress()
        {


            return View();
        }
        [HttpPost("CreateAddress")]
        public ActionResult CreateAddress(IFormCollection collection, Models.CustomerAddress C)
        {
            //DomainLibrary1.CustomerAddress CA = new CustomerAddress();
            DomainLibrary1.CustomerAddress Cust = new CustomerAddress();
            Cust.Userid = TempData["UserId"].ToString();
            Cust.Street = C.Street;
            Cust.City = C.City;
            Cust.State = C.State;
            Cust.ZipCode = C.ZipCode;
            TempData["UserId"] = Cust.Userid;
            try
            {
                db.insertAddress(Cust);
                db.Save();
            }
            catch (Exception)
            {
                
                return View();
            }
            return RedirectToAction("PizzaOrder", "Pizza");
        }






        // POST: User/Create


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