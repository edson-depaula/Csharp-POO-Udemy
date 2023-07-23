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
            /*
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            */

            int n = 0, i = 0, x = 0, cont_in = 0, cont_out = 0;

            Console.Write("Digite uma quantidade de números: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (i = 1; i <= n; i++)
            {
                Console.Write($"Digite o {i}º número:");
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    cont_in += 1;
                }
                else
                {
                    cont_out += 1;
                }
            }

            Console.WriteLine($"\nHá {cont_in} números dentro do intervalo de [10,20]");
            Console.WriteLine($"Há {cont_out} números fora do intervalo de [10,20]\n");


        }
    }
}
