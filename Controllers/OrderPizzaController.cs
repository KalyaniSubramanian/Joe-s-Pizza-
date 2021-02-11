using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaAppplication.Models;

namespace PizzaAppplication.Controllers
{
    public class OrderPizzaController : Controller
    {
        private readonly PizzaDBContext _context;
        public OrderPizzaController(PizzaDBContext context)
        {
            _context = context;
        }
        // GET: LaptopController
        public async Task<ActionResult> Index()
        {
            return View(await _context.Pizza.ToListAsync());
        }

        // GET: LaptopController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pizza = await _context.Pizza.FirstOrDefaultAsync(x => x.SNo == id);
            if (pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }
    }
}