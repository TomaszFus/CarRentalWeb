using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt.Repositories;
using Projekt.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Projekt.Controllers
{
    public class RentController : Controller
    {
        private readonly IRentRepository _rentRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ICarRepository _carRepository;
        public RentController(IRentRepository rentRepository, ICustomerRepository customerRepository, ICarRepository carRepository)
        {
            _rentRepository = rentRepository;
            _customerRepository = customerRepository;
            _carRepository = carRepository;
        }
        // GET: RentController
        public ActionResult Index()
        {
            return View(_rentRepository.GetAllRents());
        }

        // GET: Rent/Details/5
        public ActionResult Details(int id)
        {
            return View(_rentRepository.Get(id));
        }

        // GET: RentController/Create
        public ActionResult Create()
        {
            var cars = _carRepository.GetAvailableCars();
            var carsToDDList = cars.Select(x => new { Text = x.Brand + " " + x.Model, Value=x.Id }).ToList();
            ViewBag.Cars = new SelectList(carsToDDList, "Value", "Text");
            var customer = _customerRepository.GetAllCustomers();
            var customersToDDList = customer.Select(x => new { Text = x.FirstName + " " + x.LastName, Value = x.Id }).ToList();
            ViewBag.Customers = new SelectList(customersToDDList, "Value", "Text");

            return View(new RentModel());
        }

        // POST: RentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RentModel rentModel)
        {
            int carId = int.Parse(Request.Form["Cars"].ToString());
            int customerId = int.Parse(Request.Form["Customers"].ToString());
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
