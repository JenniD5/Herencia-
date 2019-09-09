using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Color = "amarillo";

            Console.WriteLine(triangulo.toString());
            triangulo.Altura = 2.5;
            triangulo.Base = 4;
            double areaTriangulo = triangulo.CalcularArea();
            Console.WriteLine("area del triangulo= " + areaTriangulo);

            Circulo circulo = new Circulo(5.4);
            Console.WriteLine("area del circulo: " + circulo.CalcularArea().ToString());

            /* Figura figura = new Figura();--(polimorfismo)(triangulo comporatandose como figura)no pueden contener estancias espeficas de la clase figura a que es abstara  se considera solo como guia*/
            Figura triangulo2 = new Triangulo();//es tratado como figura, no tiene las propedades de triangulo, sino de fiura, porlo tanto no tiene base ni altura 
            ((Triangulo)triangulo2)./*para que se tenga acceso a la clase triangulo*/Base = 2;
            ((Triangulo)triangulo2).Altura = 3;

            Console.WriteLine("area del triangulo 2= " + triangulo2.CalcularArea().ToString());//polimosfismo, clases comportandose ocmo otras
            List<Figura> figuras = new List<Figura>();
            figuras.Add(circulo);
            figuras.Add(triangulo);
            figuras.Add(triangulo2);
            
            foreach(var figura in figuras)
            {
                Console.WriteLine("area: " + figura.CalcularArea().ToString()); //var infiere el tipo de dato
            }


            Console.Read();

        }
    }
}
