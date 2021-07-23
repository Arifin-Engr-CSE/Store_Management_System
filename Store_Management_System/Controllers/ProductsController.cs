using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Store_Management_System.Data;
using Store_Management_System.Models;
using Store_Management_System.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Management_System.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostEnv;

        public ProductsController(ApplicationDbContext db, IHostingEnvironment hostEnv)
        {
            _db = db;
            _hostEnv = hostEnv;
        }
        public IActionResult Index()
        {
            var ProductInfo = (from p in _db.Products
                                join pp in _db.ProductPhotos
                                 on p.ProductId equals pp.ProductId

                               join pc in _db.ProductTypes
                                on p.CategoryId equals pc.CategoryId
                               
                                select new ProductRetriveVM
                                {
                                    ProductId = p.ProductId,
                                    ProductName = p.ProductName,
                                    ProductQTY = p.ProductQTY,
                                    BuyingPrice=p.BuyingPrice,
                                    SellingPrice=p.SellingPrice,
                                    Name=pc.Name,
                                    Image = pp.Image
                                }).ToList();
            return View(ProductInfo);
        }

        //Create
        public IActionResult Create()
        {
            ViewBag.ProductCategory = _db.ProductTypes.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductVM vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.Image != null)
                {
                    string NewFileName = Guid.NewGuid().ToString() + "_" + vm.Image.FileName;
                    string NewFilePath = Path.Combine("Images", NewFileName);
                    string File = Path.Combine(_hostEnv.WebRootPath, NewFilePath);

                    vm.Image.CopyTo(new FileStream(File, FileMode.Create));

                    Product product = new Product { ProductId = vm.ProductId, ProductName = vm.ProductName, ProductQTY = vm.ProductQTY, BuyingPrice = vm.BuyingPrice, SellingPrice = vm.SellingPrice ,CategoryId=vm.CategoryId};
                    ProductPhoto cus = new ProductPhoto { Product = product, Image = NewFilePath };
                    _db.ProductPhotos.Add(cus);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
