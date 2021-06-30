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
        private readonly ICarRepository _carRepository;
        private readonly ICustomerRepository _customerRepository;
        public RentRepository(CarRentalContext context, ICarRepository carRepository, ICustomerRepository customerRepository)
        {
            _context = context;
            _carRepository = carRepository;
            _customerRepository = customerRepository;
        }
        public RentModel Get(int rentId)
            => _context.Rents.Include(c=>c.Car).Include(z=>z.Customer).SingleOrDefault(x => x.Id == rentId);
        

        public List<RentModel> GetAllRents()
        {
            return _context.Rents.Include(x => x.Car).Include(z=>z.Customer).ToList();
        }
        public void AddRent(RentModel rent, int carId, int customerId)
        {
            var car = _carRepository.Get(carId);
            var customer = _customerRepository.Get(customerId);
            car.Availability = false;

            rent.Car = car;
            rent.Customer = customer;
            rent.RentDate = DateTime.Today;
            rent.Ended = false;
            
            _context.Cars.Update(car);
            _context.Rents.Add(rent);
            _context.SaveChanges();
        }

        public void EndRent(RentModel rent, int carId)
        {
            var car = _carRepository.Get(carId);
            car.Availability = true;
            _context.Cars.Update(car);

            _context.SaveChanges();
        }
    }
}
