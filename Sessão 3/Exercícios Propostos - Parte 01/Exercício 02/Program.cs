using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.
            Fórmula da área: area = π.raio2
            Considere o valor de π = 3.14159
            */

            double raio = 0, area = 0, pi = 3.14159;

            Console.Write("Digite o valor do Raio do Círculo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"O valor da área da circunferência é de: {area.ToString("F4", CultureInfo.InvariantCulture)}.");


        }
    }
}
