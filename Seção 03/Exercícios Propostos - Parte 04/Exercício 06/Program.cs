using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //Ler um número inteiro N e calcular todos os seus divisores
            Entrada:
            6
            Saída:
            1
            2
            3
            6
            */

            int num = 0;
            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nOs divisores de {num} são:");
            for(int i = 1; num >= i; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");
        }
    }
}
