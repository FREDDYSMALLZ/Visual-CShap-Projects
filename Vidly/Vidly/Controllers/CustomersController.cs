using System;
using System.Collections.Generic;
using  System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New ()

        {
            List<MembershipType> membershipTypes;
           // membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
               // MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        // GET: Customers
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();//gets all customers from the database
            return View(customers);
        }

       /* private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer{Id = 1, Name = "Fredrick Ondieki"},
                new Customer{Id = 2, Name = "John Wangonya"},
                new Customer{Id = 3, Name = "Mary Njoki"},
                new Customer{Id = 4, Name = "Justus Okiri"},
                new Customer{Id = 5, Name = "Francis Imbuga"}                 

    }; 
        }
        */
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);

        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
    }
}