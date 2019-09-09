using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Circulo:Figura
    {
        public double Radio { get; set; }
        public override double CalcularArea()//el override es necesario
        {
            return Math.PI * (Radio * Radio);
        }

        public Circulo(double radio)
        {
            Radio = radio;
            Color = "sin color";

        }
    }
}
