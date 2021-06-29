using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt.Models;

namespace Projekt.Repositories
{
    public interface ICustomerRepository
    {
        CustomerModel Get(int customerId);
        List<CustomerModel> GetAllCustomers();
        void Add(CustomerModel customer);
        void Update(int customerId, CustomerModel customer);
        void Delete(int customerId);
    }
}
