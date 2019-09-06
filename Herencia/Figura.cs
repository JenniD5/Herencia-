using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Figura //debe de ser abstracta para que funcione 
    {
        public string Color { get; set; }  //todas las fguras deben de calcular le area
        public abstract double CalcularArea();//debe de implementarse 

        public string toString()
        {
            return "soy una figura: " + Color;
        }

    }
}
