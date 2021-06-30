using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Repositories
{
    public class RentRepository : IRentRepository
    {
        private readonly CarRentalContext _context;
        public RentRepository(CarRentalContext context)
        {
            _context = context;
        }
        public RentModel Get(int rentId)
            => _context.Rents.Include(c=>c.Car).Include(z=>z.Customer).SingleOrDefault(x => x.Id == rentId);
        

        public List<RentModel> GetAllRents()
        {
            return _context.Rents.Include(x => x.Car).Include(z=>z.Customer).ToList();
        }
        public void AddRent(RentModel rent)
        {
            
            rent.RentDate = DateTime.Today;
            rent.Ended = false;
            //rent.Car.Brand = "dasd";
            //rent.Car.Model = "dasd";
            //rent.Car.Year = 123;
            //rent.Car.Course = 123;
            //rent.Customer.FirstName = "ads";
            //rent.Customer.LastName = "ads";
            //rent.Customer.PhoneNumber = "456465";

            //rent.Car.Availability = false;
           
            _context.Rents.Add(rent);
            _context.SaveChanges();
        }        
    }
}
