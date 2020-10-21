using AutoMapper;
using DDD.Domian.Entities;
using DDD.Infra.Data.Repositories;
using DDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
namespace DDD.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        // GET: Product
        public ActionResult Index()
        {
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productRepository.GetAll());
            return View(productViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(product);
                _productRepository.Add(productDomain);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
