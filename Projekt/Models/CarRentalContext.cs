using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CarModel> Cars { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<RentModel> Rents { get; set; }
    }
}
