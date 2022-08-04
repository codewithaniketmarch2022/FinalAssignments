using FinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalAssignment.Controllers
{
    public class RegistrationsController : Controller
    {
        // GET: Registrations
        public ActionResult Index()
        {
            var list = City.GetCities();
            ViewBag.Cities = list;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration obj)
        {
            try
            {
                // TODO: Add insert logic here
                Registration.InsertRegistrationDetails(obj);
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registrations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registrations/Create
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(Registration obj)
        {
            try
            {
                // TODO: Add insert logic here
                var list= Registration.verifyLogin(obj);
                if(obj.LoginName==list[0].LoginName&&obj.Password==list[0].Password)
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return RedirectToAction("Login");
                }
               
            }
            catch
            {
                return View();
            }
        }

        public ActionResult HomePage()
        {

            return View();
        }



        // GET: Registrations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registrations/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registrations/Delete/5
        
    }
}
