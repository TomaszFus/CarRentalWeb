using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    [Table("Rents")]
    public class RentModel
    {
        [Key]
        public int Id { get; set; }
        public CarModel Car { get; set; }
        public CustomerModel Customer { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double Cost { get; set; }
        public bool Ended { get; set; }


    }
}
