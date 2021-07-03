using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt.Models;

namespace Projekt.Repositories
{
    public interface IRentRepository
    {
        RentModel Get(int rentId);
        List<RentModel> GetAllRents();
        List<RentModel> GetEndedRents();
        void AddRent(RentModel rent, int carId, int customerId);
        void EndRent(int rentId, RentModel rent);
        //void Update(int rentId, RentModel rent);


    }
}
