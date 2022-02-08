using GridSystemDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GridSystemDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext _context;


        public ProductController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult GeProducts()
        {
            var prodt = _context.Products.ToList();
            return Json(prodt);
        }

        public IActionResult PostProducts(Product procut)
        { 

        
        }
    }
}
