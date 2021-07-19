using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using Projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class CarController : Controller
    {
        
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        // GET: Cars
        public ActionResult Index()
        {
            return View(_carRepository.GetAllCars());
        }

        // GET: Car
        public ActionResult Details(int id)
        {
            return View(_carRepository.Get(id));
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View(new CarModel());
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarModel carModel)
        {
            
            _carRepository.Add(carModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: Car/Edit
        public ActionResult Edit(int id)
        {
            return View(_carRepository.Get(id));
        }

        // POST: Car/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CarModel carModel)
        {
            _carRepository.Update(id, carModel);
            return RedirectToAction(nameof(Index));
        }


        // GET: Car/Delete
        public ActionResult Delete(int id)
        {
            return View(_carRepository.Get(id));
        }

        // POST: Car/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CarModel carModel)
        {
            var car = _carRepository.Get(id);
            
            if (car.Availability==true)
            {
                _carRepository.Delete(id);
            }
            
            return RedirectToAction(nameof(Index));
            
        }
    }
}
