using AutoMapper;
using DDD.Application.Interface;
using DDD.Domian.Entities;
using DDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
namespace DDD.MVC.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientAppService _clientAppService;
        public ClientsController(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }
        // GET: Clients
        public ActionResult Index()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientAppService.GetAll());
            return View(clientViewModel);
        }
        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            var client = _clientAppService.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clientDomain = Mapper.Map<ClientViewModel, Client>(client);
                _clientAppService.Add(clientDomain);
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _clientAppService.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clientDomain = Mapper.Map<ClientViewModel, Client>(client);
                _clientAppService.Add(clientDomain);
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _clientAppService.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = _clientAppService.GetById(id);
            _clientAppService.Remove(client);
            return RedirectToAction("Index");
        }
    }
}
