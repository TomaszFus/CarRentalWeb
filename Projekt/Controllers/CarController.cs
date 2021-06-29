using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class CarController : Controller
    {
        private static List<CarModel> carsList = new List<CarModel>()
        {
            new CarModel(){CarId=1, Brand="Mazda", Model="3", Year=2016, Course=50410, Availability=true},
            new CarModel(){CarId=1, Brand="Toyota", Model="Auris", Year=2020, Course=16015, Availability=false}
        };
        // GET: CarController
        public ActionResult Index()
        {
            return View(carsList);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            return View(carsList.FirstOrDefault(x=>x.CarId==id));
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View(new CarModel());
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarModel carModel)
        {
            carModel.CarId = carsList.Count + 1;
            carModel.Availability = true;
            carsList.Add(carModel);
            return RedirectToAction(nameof(Index));
        }

        //// GET: CarController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View(carsList.FirstOrDefault(x=>x.CarId==id));
        //}

        //// POST: CarController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, CarModel carModel)
        //{
        //    CarModel car = carsList.FirstOrDefault(x => x.CarId == id);
        //    car.Brand = carModel.Brand;
        //    car.Model = carModel.Model;
        //    car.
        //    return RedirectToAction(nameof(Index));
        //}

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            CarModel car = carsList.FirstOrDefault(x => x.CarId == id);
            if (car.Availability==true)
            {
                return View(carsList.FirstOrDefault(x => x.CarId == id));
            }
            return RedirectToAction(nameof(Index));
            
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CarModel carModel)
        {
            CarModel car = carsList.FirstOrDefault(x => x.CarId == id);
            carsList.Remove(car);
            return RedirectToAction(nameof(Index));
            
        }
    }
}
