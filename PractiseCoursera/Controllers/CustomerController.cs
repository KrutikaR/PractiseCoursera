using Microsoft.AspNetCore.Mvc;
using PractiseCoursera.Models;
using System.Xml.Linq;

namespace PractiseCoursera.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
             new Customer() {id = 101, name = "Krutika" , amount = 1000 },
             new Customer() { id = 102, name = "KrutikaR" , amount = 10000 },
    };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Message()
        {
            return View();
        }
    }
}
