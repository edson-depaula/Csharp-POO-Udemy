using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            exemplo
            */

            Console.Write("Digite um número positivo: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                while (n <= 0)
                {
                    Console.Write("Digite um número positivo (maior que zero): ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            if (n > 0)
            {
                Console.WriteLine("");
                for(int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i}, ao quadrado {Math.Pow(i, 2)}, ao cubo {Math.Pow(i, 3)}");
                }
            }





        }
    }
}
