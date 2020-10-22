using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1
{
    class Cuatrimoto : Motocicleta
    {
        protected string color;

        public string Color
        {
            get
            {
                return Color;
            } 
            set
            {
                color = value;
            }
        }
        public Cuatrimoto() : base()
        {
            color = "";
        }
        public override string ToString()
        {
            return color + " " + base.ToString();
        }
    } 
}
