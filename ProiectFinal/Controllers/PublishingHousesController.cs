using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Controllers
{
    public class PublishingHousesController : Controller
    {
        private readonly AppDbContext _context;

        public PublishingHousesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPublishingHouses = await _context.PublishingHouses.ToListAsync();
            return View(allPublishingHouses);
        }
    }
}
