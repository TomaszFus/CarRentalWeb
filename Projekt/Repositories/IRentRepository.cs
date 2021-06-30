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
        void AddRent(RentModel rent);
        
        
    }
}
