using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt.Repositories;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class RentController : Controller
    {
        private readonly IRentRepository _rentRepository;
        public RentController(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }
        // GET: RentController
        public ActionResult Index()
        {
            return View(_rentRepository.GetAllRents());
        }

        // GET: RentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_rentRepository.Get(id));
        }

        // GET: RentController/Create
        public ActionResult Create()
        {
            return View(new RentModel());
        }

        // POST: RentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RentModel rentModel)
        {
            _rentRepository.AddRent(rentModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: RentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
