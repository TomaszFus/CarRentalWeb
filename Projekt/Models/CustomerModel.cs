using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    [Table("Customers")]
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Imię")]
        [Required(ErrorMessage = "Podaj imię")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        [Required(ErrorMessage = "Podaj nazwisko")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [DisplayName("Telefon")]
        [Required(ErrorMessage = "Podaj telefon")]
        [MaxLength(9)]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a number")]
        public string PhoneNumber { get; set; }

    }
}
