using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Repositories
{
    public interface ICarRepository
    {
        CarModel Get(int carId);
        List<CarModel> GetAllCars();
        void Add(CarModel car);
        void Delete(int carId);
        void Update(int carId, CarModel car);
    }
}
