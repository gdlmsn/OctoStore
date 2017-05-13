using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OctoStore.Services.Infrastructure;
using Microsoft.AspNetCore.Identity;
using OctoStore.Models;

namespace OctoStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly IProduct _productRepository;

        private readonly ICategory _categoryRepository;

        private readonly UserManager<Customer> _userManager;

        public ProductsController(IProduct productRepository, ICategory categoryRepository, UserManager<Customer> userManager)
        {

            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}