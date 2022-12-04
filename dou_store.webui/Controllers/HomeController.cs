using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dou_store.webui.Data;
using dou_store.webui.Models;

namespace dou_store.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {      
        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }

         // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}