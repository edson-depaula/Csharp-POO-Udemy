using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Versão_01
{
    internal class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um valor numérico qualquer, e daí mostrar
            quanto seria o valor de uma circunferência e do volume de uma esfera
            para um raio daquele valor. Informar também o valor de PI com duas
            casas decimais

            Entre o valor do raio: 3.0
            Circunferência: 18.84
            Volume: 113.04
            Valor de PI: 3.14
            */

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cir = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("\nCircunferência " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
