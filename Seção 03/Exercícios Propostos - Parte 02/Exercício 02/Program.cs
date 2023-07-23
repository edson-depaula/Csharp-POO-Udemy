using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

            int num = 0;

            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {

                Console.WriteLine($"\nO número {num} é par!");

            } else
            {
                Console.WriteLine($"\nO número {num} é impar!");
            }
        }
    }
}
