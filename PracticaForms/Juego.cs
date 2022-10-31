using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForms
{
    public class Juego
    {

        public int? id { get; set; }

        public string? titulo { get; set; }

        public DateTime fechaSalida { get; set; }

        public int ventas { get; set; }

        public double precio { get; set; }

        public string? genero { get; set; }
    }
}
