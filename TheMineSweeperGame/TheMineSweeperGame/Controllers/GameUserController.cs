using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheMineSweeperGame.Models;

namespace TheMineSweeperGame.Controllers
{
    public class GameUserController : Controller
    {
       //Registration Action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        //Registration Post Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(GameUser gameUser)
        {
            bool status = false;
            string message = "";

            //Model Validation
            if (ModelState.IsValid)
            {
                //Email already exist
                var emailExist = IsEmailExist(gameUser.Email);
                if (emailExist)
                {
                    ModelState.AddModelError("Email exist", "Email entered already exists." );
                    return View(gameUser);
                }

                //Password hashing 
                gameUser.Password = PasswordHashing.Hash(gameUser.Password);
                gameUser.ConfirmPassword = PasswordHashing.Hash(gameUser.ConfirmPassword);


                //Save user data to the database
                using (GameEntities entities = new GameEntities())
                {
                    entities.GameUsers.Add(gameUser);
                    entities.SaveChanges();

                    return RedirectToAction("Login");


                }
                
            }
            else
            {
                message = "Invalid request";
            }

            ViewBag.Message = message;
            ViewBag.Status = status;
            
            return View(gameUser);

        }

        [NonAction]
        public bool IsEmailExist(string email)
        {
            using (GameEntities gameEntities = new GameEntities())
            {
                var v = gameEntities.GameUsers.Where(a => a.Email == email).FirstOrDefault();
                return v == null;
            }
        }

        //Login


        //Login Post


        //Logout
    }

}