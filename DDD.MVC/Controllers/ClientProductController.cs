using AutoMapper;
using DDD.Application;
using DDD.Domian.Entities;
using DDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
namespace DDD.MVC.Controllers
{
    public class ClientProductController : Controller
    {
        //DECLARAÇÃO DAS PROPRIEDADES PARA REALIZAR A INJEÇÃO DE DEPENDÊCIA
        private readonly ClientProductAppService _clientProductAppService;
        private readonly ClientAppService _clientAppService;
        private readonly ProductAppService _productAppService;
        //REALIZAR A INJEÇÃO DE DEPENDÊCIA
        public ClientProductController(ClientProductAppService clientProductAppService, ClientAppService clientAppService, ProductAppService productAppService)
        {
            _clientProductAppService = clientProductAppService;
            _clientAppService = clientAppService;
            _productAppService = productAppService;
        }
        // GET: Client_Product
        public ActionResult Index()
        {
            var client_ProductViewModel = Mapper.Map<IEnumerable<ClientProduct>, IEnumerable<ClientProductViewModel>>(_clientProductAppService.GetAll());
            return View(client_ProductViewModel);
        }
        // GET: Client_Product/Details/5
        public ActionResult Details(int id)
        {
            var client_product = _clientProductAppService.GetById(id);
            var client_productViewModel = Mapper.Map<ClientProduct, ClientProductViewModel>(client_product);
            return View(client_productViewModel);
        }
        // GET: Client_Product/Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(_clientAppService.GetAll(), "ClientId", "Name");
            ViewBag.ProductId = new SelectList(_productAppService.GetAll(), "ProductId", "Name");
            return View();
        }
        // POST: Client_Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientProductViewModel client_Product)
        {
            if (ModelState.IsValid)
            {
                var client_ProductDomain = Mapper.Map<ClientProductViewModel, ClientProduct>(client_Product);
                _clientProductAppService.Add(client_ProductDomain);
                return RedirectToAction("Index");
            }
            return View(client_Product);
        }
        // GET: Client_Product/Edit/5
        public ActionResult Edit(int id)
        {
            var client_product = _clientProductAppService.GetById(id);
            var client_productViewModel = Mapper.Map<ClientProduct, ClientProductViewModel>(client_product);
            return View(client_productViewModel);
        }
        // POST: Client_Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientProductViewModel client_Product)
        {
            if (ModelState.IsValid)
            {
                var client_productDomain = Mapper.Map<ClientProductViewModel, ClientProduct>(client_Product);
                _clientProductAppService.Add(client_productDomain);
                return RedirectToAction("Index");
            }
            return View(client_Product);
        }
        // GET: Client_Product/Delete/5
        public ActionResult Delete(int id)
        {
            var client_Product = _clientProductAppService.GetById(id);
            var client_ProductViewModel = Mapper.Map<ClientProduct, ClientProductViewModel>(client_Product);
            return View(client_ProductViewModel);
        }

        // POST: Client_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client_product = _clientProductAppService.GetById(id);
            _clientProductAppService.Remove(client_product);
            return RedirectToAction("Index");
        }
    }
}
