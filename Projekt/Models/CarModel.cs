using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class CarModel
    {
        public int CarId { get; set; }
        [DisplayName("Marka")]
        public string Brand { get; set; }
        [DisplayName("Model")]
        public string Model { get; set; }
        [DisplayName("Rok produkcji")]
        public int Year { get; set; }
        [DisplayName("Przebieg")]
        public int Course { get; set; }
        [DisplayName("Dostępność")]
        public bool Availability { get; set; }
    }
}
