using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    [Table("Cars")]
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Marka")]
        [Required(ErrorMessage ="Podaj markę")]
        [MaxLength(50)]
        public string Brand { get; set; }
        [DisplayName("Model")]
        [Required(ErrorMessage = "Podaj model")]
        [MaxLength(50)]
        public string Model { get; set; }
        [DisplayName("Rok produkcji")]
        [Required(ErrorMessage = "Podaj rok produkcji")]
        public int Year { get; set; }
        [DisplayName("Przebieg")]
        [Required(ErrorMessage = "Podaj przebieg")]
        public int Course { get; set; }
        [DisplayName("Dostępność")]
        public bool Availability { get; set; }
        [DisplayName("Cena")]
        [Required(ErrorMessage ="Podaj cenę")]
        public double Price { get; set; }
        [DisplayName("Numer rejestracyjny")]
        [MaxLength(7)]
        public string NumberPlate { get; set; }
    }
}
