using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeaNarutoPractica
{
    class Aldea
    {
        public string Nombre { get; set; }
        public string Kage { get; set; }
        public int Habitantes { get; set; }
        public List<Shinobi> Lista { get; set; }

        public Aldea()
        {
            Lista = new List<Shinobi>();
        }

        private double _ingresos { get; set; }
        public double Ingresos
        {
            get
            {
                return _ingresos;
            }

            set
            {
                if (value>= 5000000)
                {
                    _ingresos = value;
                }

                else
                {
                    throw new Exception("Tu Aldea es muy pobre para considerarse aldea");
                }
            }


        }




    }
}
