using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Business.Concrete;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View(_productService.GetAll());
        }

        public IActionResult ProductCreate()
        {
            var model = new ProductModel();
            model.SelectedCategories = null;
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult ProductCreate(ProductModel model,int[] categoryIds,IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length>0 && file!=null)
            {
                JobManager urlGenerate = new JobManager();

                var url = urlGenerate.MakeUrl(model.Name);

                model.ImageUrl = urlGenerate.UploadImage(file,url);

                var product = new Product()
                {
                    Name = model.Name,
                    Url = url,
                    Price = model.Price,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    IsApproved = model.IsApproved,
                    IsHome = model.IsHome
                };
                _productService.Create(product, categoryIds);
                return RedirectToAction("ProductList");
            }
            //Eğer validationdan geçemediyse ve/veya kategori seçilmemişse
            ViewBag.Categories = _categoryService.GetAll();
            if (categoryIds.Length > 0)
            {
                model.SelectedCategories = categoryIds.Select(catid => new Category()
                {
                    CategoryId = catid

                }).ToList();
            }
            else
            {
                ViewBag.CategoryMessage = "Lütfen bir kategori seçimi yapınız!";
            }
            if (file == null)
            {
                ViewBag.ImageMessage = "Lütfen resim seçiniz";
            }
            return View(model);

        }

        public IActionResult ProductEdit(int? id)
        {

            var entity = _productService.GetByIdWithCategories((int)id);
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult ProductEdit(ProductModel model, int[] categoryIds,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _productService.GetById(model.ProductId);
                entity.Name = model.Name;
                entity.Price = model.Price;
                entity.Url = model.Url;
                entity.Description = model.Description;
                entity.IsApproved = model.IsApproved;
                entity.IsHome = model.IsHome;
                //entity.ImageUrl = model.ImageUrl;
                _productService.Update(entity, categoryIds);
                return RedirectToAction("ProductList");
            }
            if (file !=null)
            {
                JobManager urlGenerate = new JobManager();

                var url = urlGenerate.MakeUrl(model.Name);

                model.ImageUrl = urlGenerate.UploadImage(file, url);
            }

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);

        }

      
        public IActionResult ProductDelete(int productId)  //productId viewda name 
        {
            var entity = _productService.GetById(productId);
            _productService.Delete(entity);
            return RedirectToAction("ProductList");
        }
    }
}
