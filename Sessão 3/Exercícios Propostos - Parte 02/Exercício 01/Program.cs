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
            int num = 0;


            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0) {

                Console.WriteLine("\nO número é negativo!");

            } else if (num > 0)
            {
                Console.WriteLine("\nO número é positivo!");
            } else
            {
                Console.WriteLine("\nO número é nulo!");
            }







        }
    }
}
