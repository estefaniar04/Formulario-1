using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1
{
    class vehiculo
    {
        protected string llantas;


        public string Llantas
        {
            get
            {
                
                return llantas; 
            }
            set 
            {
                llantas = value;
            }
        }

        public vehiculo()
        {
            llantas = "Rodada 16";
        }

        public override string ToString()
        {
            return llantas + " ";
        }

    }
}
