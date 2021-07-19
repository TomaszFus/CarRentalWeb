using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required(ErrorMessage ="Wybierz samochód")]
        public CarModel Car { get; set; }
        [Required(ErrorMessage = "Wybierz klienta")]
        public CustomerModel Customer { get; set; }
        [DisplayName("Data wypożyczenia")]
        public DateTime RentDate { get; set; }
        [DisplayName("Data zawrotu")]
        public DateTime DeliveryDate { get; set; }
        [DisplayName("Koszt wypożyczenia")]
        public double Cost { get; set; }
        [DisplayName("Zakończone")]
        public bool Ended { get; set; }


    }
}
