using EFitnessMonitoring.Models;
using EFitnessMonitoring.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EFitnessMonitoring.Controllers
{
    public class AuthController : Controller
    {
       //FitnessEntities db = new FitnessEntities();
        // GET: Auth
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                //cautam userul in bd
                User user = null;
                using(FitnessData db = new FitnessData())
                {
                    user = db.Users.FirstOrDefault(u => u.Username == model.Username && u.Parola == model.Parola);
                }

                if(user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Username, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Nu exista asa utilizator");
                }
            }

            return View();
            
            //var user = db.Users.FirstOrDefault(u => u.Username == model.Username && u.Parola == model.Parola);
            //FormsAuthentication.SetAuthCookie(user.Username, false);

            //return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(UserViewModel model)
        {
            
            //var role = db.Roles.FirstOrDefault(u => u.RoleID.Equals(model.Rolul));
            if (ModelState.IsValid)
            {
                User user = null;
                //using(FitnessEntities db = new FitnessEntities())
                //{
                //   user = db.Users.FirstOrDefault(u => u.Username.Equals(model.Username));
                //}
                //CREEAZA USER
                if (user == null)
                {
                    using (FitnessData db = new FitnessData())
                    {
                        db.Users.Add(new User { Username = model.Username, Email = model.Email, Gen = model.Gen,
                            Virsta = model.Virsta, Parola = model.Parola, ConfirmPaorola = model.ConfirmPaorola, RoleID = 2 });
                        
                        db.SaveChanges();

                        user = db.Users.Where(u => u.Username == model.Username && u.Parola == model.Parola).FirstOrDefault();

                    }
                    // Daca userul sa adaugat cu succes in db
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Exista deja un utilizator cu asa nume");
                }
            }
            return View();
           
            //var role = db.Roles.FirstOrDefault(r => r.Name == model.Rolul).RoleID;
            //var user = db.Users.Create();

            //user.Username = model.Username;
            //user.Email = model.Email;
            //user.Gen = model.Gen;
            //user.Data = model.Data;
            //user.Parola = model.Parola;
            //user.ConfirmPaorola = model.ConfirmPaorola;
            //user.RoleID = role;

            //db.Users.Add(user);
            //db.SaveChanges();
            //return RedirectToAction("Login", "Auth");
        }
    }
}