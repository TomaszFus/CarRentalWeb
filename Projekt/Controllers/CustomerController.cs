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
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(_customerRepository.GetAllCustomers());
        }

        // GET: CustomerController/Details
        public ActionResult Details(int id)
        {
            return View(_customerRepository.Get(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View(new CustomerModel());
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerModel customerModel)
        {
            _customerRepository.Add(customerModel);
            return RedirectToAction(nameof(Index));            
        }

        // GET: CustomerController/Edit
        public ActionResult Edit(int id)
        {
            return View(_customerRepository.Get(id));
        }

        // POST: CustomerController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerModel customerModel)
        {
            _customerRepository.Update(id, customerModel);
            return RedirectToAction(nameof(Index));            
        }

        // GET: CustomerController/Delete
        public ActionResult Delete(int id)
        {
            return View(_customerRepository.Get(id));
        }

        // POST: CustomerController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerModel customerModel)
        {
            _customerRepository.Delete(id);
            return RedirectToAction(nameof(Index));            
        }
    }
}
