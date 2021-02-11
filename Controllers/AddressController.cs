using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaAppplication.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Address()
        {
            return View();
        }
        public IActionResult OrderPlaced()
        {
            ViewBag.msg = "Your order has been placed and will be delivered to you within 30 minutes!";
            return View();
        }
    }
}