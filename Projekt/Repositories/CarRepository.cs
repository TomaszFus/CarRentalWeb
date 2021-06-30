using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarRentalContext _context;
        public CarRepository(CarRentalContext context)
        {
            _context = context;
        }

        public CarRepository()
        {
        }

        public CarModel Get(int carId)
            => _context.Cars.SingleOrDefault(x => x.Id == carId);
        
        public List<CarModel> GetAllCars()
        {
            return _context.Cars.ToList();
        }
        public void Add(CarModel car)
        {
            car.Availability = true;
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void Delete(int carId)
        {
            var result = _context.Cars.SingleOrDefault(x => x.Id == carId);
            if (result!=null)
            {
                _context.Cars.Remove(result);
                _context.SaveChanges();
            }
        }

        public void Update(int carId, CarModel car)
        {
            var result = _context.Cars.SingleOrDefault(x => x.Id == carId);
            if (result != null)
            {
                result.Price = car.Price;
                

                _context.SaveChanges();
            }
        }

        public List<CarModel> GetAvailableCars()
        {
            return _context.Cars.Where(x => x.Availability == true).ToList();
        }
    }
}
