using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i = 0, soma = 0, valor = 0;

            Console.Write("Quantos números inteiros você irá digitar? ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.Write("Valor #{0}: ", i);
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"\nA soma é igual a: {soma}");


        }
    }
}
