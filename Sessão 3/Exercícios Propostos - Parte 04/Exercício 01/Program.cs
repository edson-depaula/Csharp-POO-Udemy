using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso.

            int num = 0, i = 0;

            Console.Write("Digite um valor de 1 a 1000: ");
            num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 1000)
            {
                Console.WriteLine("\nDigite um número válido!");

            } 
            else
            {
                for (i = 1; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
