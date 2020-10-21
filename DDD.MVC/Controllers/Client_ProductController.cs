using AutoMapper;
using DDD.Domian.Entities;
using DDD.Infra.Data.Repositories;
using DDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
namespace DDD.MVC.Controllers
{
    public class Client_ProductController : Controller
    {
        private readonly Client_ProductRepository _client_ProductRepository = new Client_ProductRepository();
        // GET: Client_Product
        public ActionResult Index()
        {
            var client_ProductViewModel = Mapper.Map<IEnumerable<Client_Product>, IEnumerable<Client_ProductViewModel>>(_client_ProductRepository.GetAll());
            return View(client_ProductViewModel);
        }

        // GET: Client_Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client_Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client_Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client_ProductViewModel client_Product)
        {
            if (ModelState.IsValid)
            {
                var client_ProductDomain = Mapper.Map<Client_ProductViewModel, Client_Product>(client_Product);
                _client_ProductRepository.Add(client_ProductDomain);
                return RedirectToAction("Index");
            }
            return View(client_Product);
        }

        // GET: Client_Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client_Product/Edit/5
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

        // GET: Client_Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client_Product/Delete/5
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
