using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CarRentalContext _context;
        public CustomerRepository(CarRentalContext context)
        {
            _context = context;
        }
        public CustomerModel Get(int customerId)
            => _context.Customers.SingleOrDefault(x => x.Id == customerId);
        

        public List<CustomerModel> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
        public void Add(CustomerModel customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Delete(int customerId)
        {
            var result = _context.Customers.SingleOrDefault(x => x.Id == customerId);
            if (result!=null)
            {
                _context.Customers.Remove(result);
                _context.SaveChanges();
            }
        }

        public void Update(int customerId, CustomerModel customer)
        {
            var result = _context.Customers.SingleOrDefault(x => x.Id == customerId);
            if (result!=null)
            {
                result.FirstName = customer.FirstName;
                result.LastName = customer.LastName;
                result.PhoneNumber = customer.PhoneNumber;

                _context.SaveChanges();
            }
        }        
    }
}
