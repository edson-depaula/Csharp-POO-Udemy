using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _38.Problema_sem_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar as variáveis compostas dessa classe triângulo
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            //x.a ou x.b ou x.c acessa o atributo da variável na classe
            //Assim já armazena as informações no objeto composto "x" da classe triângulo
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("\nÁrea de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("\nMaior área: X");
            }
            else
            {
                Console.WriteLine("\nMaior área: Y");
            }

            //Os objetos são instâncias das classes | X é a instância | A, B e C são os atributos

            // X   3.0 4.0 5.0
            //      A   B   C
        }
    }
}
