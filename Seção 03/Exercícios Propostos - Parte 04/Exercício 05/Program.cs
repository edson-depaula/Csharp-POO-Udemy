using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.
            */

            int fat = 1;

            Console.Write("Digite um valor inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++)
            {
                fat *= i;
            }

            Console.WriteLine($"\nO fatorial de {numero} é {fat}");



        }
    }
}
