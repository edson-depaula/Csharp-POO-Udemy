using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versão_02
{
    internal class Program
    {
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

            double cir = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("\nCircunferência " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));






        }
    }
}
