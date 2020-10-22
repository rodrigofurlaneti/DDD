using AutoMapper;
using DDD.Application.Interface;
using DDD.Domian.Entities;
using DDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
namespace DDD.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productAppService;
        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productAppService.GetAll());
            return View(productViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _productAppService.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            return View(productViewModel);
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
                _productAppService.Add(productDomain);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _productAppService.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            return View(productViewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(product);
                _productAppService.Add(productDomain);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _productAppService.GetById(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            return View(productViewModel);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, FormCollection collection)
        {
            var product = _productAppService.GetById(id);
            _productAppService.Remove(product);
            return RedirectToAction("Index");
        }
    }
}
