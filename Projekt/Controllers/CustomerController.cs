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
        private readonly IRentRepository _rentRepository;
        public CustomerController(ICustomerRepository customerRepository, IRentRepository rentRepository)
        {
            _customerRepository = customerRepository;
            _rentRepository = rentRepository;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(_customerRepository.GetAllCustomers());
        }

        // GET: CustomerC/Details
        public ActionResult Details(int id)
        {
            return View(_customerRepository.Get(id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View(new CustomerModel());
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerModel customerModel)
        {
            _customerRepository.Add(customerModel);
            return RedirectToAction(nameof(Index));            
        }

        // GET: Customer/Edit
        public ActionResult Edit(int id)
        {
            return View(_customerRepository.Get(id));
        }

        // POST: Customer/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerModel customerModel)
        {
            _customerRepository.Update(id, customerModel);
            return RedirectToAction(nameof(Index));            
        }

        // GET: Customer/Delete
        public ActionResult Delete(int id)
        {
            return View(_customerRepository.Get(id));
        }

        // POST: Customer/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerModel customerModel)
        {
          
            var rents = _rentRepository.GetAllRents();
            bool exist = false;
            foreach (var rent in rents)
            {
                if (rent.Customer.Id==id)
                {
                    exist = true;
                }
            }

            if (exist==false)
            {
                _customerRepository.Delete(id);
            }
            return RedirectToAction(nameof(Index));            
        }
    }
}
