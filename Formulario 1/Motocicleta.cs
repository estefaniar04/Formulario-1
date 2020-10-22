using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1
{
    class Motocicleta : vehiculo 
    {
        protected string marca;

        public string Marca
        {
            get
            {
                return Marca;
            }
            set
            {
                marca = value;
            }
        }
        public Motocicleta() : base()
        {
            marca = "";
        }

        public override string ToString()
        {
            return marca + " " + base.ToString();

        }
    }
}
