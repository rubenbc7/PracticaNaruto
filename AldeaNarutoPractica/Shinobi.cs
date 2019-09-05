using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeaNarutoPractica
{
    class Shinobi
    {
        public string Nombre { get; set; }
        public string Rango{ get; set; }

        public Shinobi(string nombre, string rango)
        {
            Nombre = nombre;
            Rango = rango;
        }

    }
}
