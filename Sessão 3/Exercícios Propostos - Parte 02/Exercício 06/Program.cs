using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.


            double entrada = 0;

            Console.Write("Digite um valor: ");
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada < 0 || entrada > 100)
            {
                Console.WriteLine("\nO número está fora do intervalo!");

            } else if (entrada <= 25)
            {
                Console.WriteLine("\nO intervalo é de: [0,25]");

            } else if (entrada <= 50)
            {
                Console.WriteLine("\nO intervalo é de: (25,50]");

            }else if (entrada <= 75)
            {
                Console.WriteLine("\nO intervalo é de: (50,75]");

            } else
            {
                Console.WriteLine("\nO intervalo é de: (75,100]");
            }



        }
    }
}
