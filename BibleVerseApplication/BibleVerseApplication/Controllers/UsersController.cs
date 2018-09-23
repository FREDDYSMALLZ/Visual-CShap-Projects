using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BibleVerseApplication.Models;

namespace BibleVerseApplication.Controllers
{
    public class UsersController : Controller
    {
        // Register Action
        [Authorize]
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "IsEmailVerified, ActivationCode")]User user)
        {
            bool status = false;
            string message = "";

            //Model Validation
            if (ModelState.IsValid)
            {           
                #region EmailExist
                var isExist = IsEmailExist(user.EmailId);
                if (isExist)
                {
                    ModelState.AddModelError("Email Exist", "Email entered already Exist ");
                    return View(user);
                }
                #endregion

                #region Generate Activation Code 
                user.ActivationCode = Guid.NewGuid();

                #endregion

                #region Password Hashing
                user.Password = Crypto.Hash(user.Password);
                user.ConfirmPassword = Crypto.Hash(user.ConfirmPassword);
                #endregion

                user.IsEmailVerified = false;

                #region Save Data to Database

                using (RegAndLoginDbEntities dbEntities = new RegAndLoginDbEntities() )
                {
                    dbEntities.Users.Add(user);
                    dbEntities.SaveChanges();

                    //Send email to user
                    SendVerificationLinkEmail(user.EmailId, user.ActivationCode.ToString());
                    message = "You have Successfully Registered. Activation Link has been sent tour email." +
                              "Please verify your account ";
                    status = true;
                }
                #endregion
            }
            else
            {
                message = "Invalid Request";
            }
            ViewBag.Message = message;
            ViewBag.Status = status;
            return View(user);
        }

        //Verify user account
        [HttpGet]
        public ActionResult VerifyAccount(string id)
        {
            bool Status = false;
            using (RegAndLoginDbEntities dbEntities = new RegAndLoginDbEntities())
            {
                dbEntities.Configuration.ValidateOnSaveEnabled = false;
                var v = dbEntities.Users.Where(a => a.ActivationCode == new Guid(id)).FirstOrDefault();
                if (v != null)
                {
                    v.IsEmailVerified = true;
                    dbEntities.SaveChanges();
                    Status = true;
                }
                else
                {
                    ViewBag.Message = "Invalid Request";
                }
            }
            ViewBag.Status = Status;
           return RedirectToAction("Login");
            
        }
        //Login 
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login, string ReturnUrl)
        {
            string message = "";

            using (RegAndLoginDbEntities dbEntities = new RegAndLoginDbEntities())
            {
                var v = dbEntities.Users.Where(a => a.EmailId == login.EmailId).FirstOrDefault();
                if (v != null)
                {
                    if (string.Compare(Crypto.Hash(login.Password), v.Password) == 0)
                    {
                        int timeout = login.RememberMe ? 525600 : 20; // 525600 min = 1 year
                        var ticket = new FormsAuthenticationTicket(login.EmailId, login.RememberMe, timeout);
                        string encrypted = FormsAuthentication.Encrypt(ticket);
                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                        cookie.Expires = DateTime.Now.AddMinutes(timeout);
                        cookie.HttpOnly = true;
                        Response.Cookies.Add(cookie);
                        if (Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        message = "Invalid Login Credentials Provided";
                    }
                }
                else
                {
                    message = "Invalid Login Credentials Provided";
                }
            }
            ViewBag.Message = message;


            return View();
        }


        //Log Out function
        [Authorize]
        [HttpPost]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Users");
        }



        [NonAction]
        public bool IsEmailExist(string emailId)
        {
            using (RegAndLoginDbEntities dbEntities = new RegAndLoginDbEntities())
            {
                var v = dbEntities.Users.Where(a => a.EmailId == emailId).FirstOrDefault();
                return v != null;

            }
        }
       
        [NonAction]
        public void SendVerificationLinkEmail(string emailID, string activationCode)
        {
            var verifyUrl = "/User/VerifyAccount/" + activationCode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            var fromEmail = new MailAddress("elisenyaboke@gmail.com", "ASP.NET Bible Verse");
            var toEmail = new MailAddress(emailID);
            var fromEmailPassword = "Welcome@123"; // Replace with actual password
            string subject = "Your account is successfully created!";

            string body = "<br/><br/> Your Bible Verse account is" +
                          " successfully created. Please click on the below link to verify your account" +
                          "<br/><br/><a href='" + link + "'>" + link + "</a> ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
        }
    }

}