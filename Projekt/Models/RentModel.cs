using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class RentModel
    {
        public int Id { get; set; }
        public CarModel Car { get; set; }
        public CustomerModel Customer { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DeliveryDate { get; set; }


    }
}
