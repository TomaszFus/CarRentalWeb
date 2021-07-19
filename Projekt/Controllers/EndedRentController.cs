using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class EndedRentController : Controller
    {
        private readonly IRentRepository _rentRepository;
        public EndedRentController(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }
        // GET: EndedRentController
        public ActionResult Index()
        {
            return View(_rentRepository.GetEndedRents());
        }

        // GET: EndedRent/Details
        public ActionResult Details(int id)
        {
            return View(_rentRepository.Get(id));
        }

        
    }
}
