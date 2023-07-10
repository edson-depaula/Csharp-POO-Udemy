using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            //ordem crescente ou decrescente.

            Console.Write("Digite dois números inteiros separados por espaço para verificar se são multiplos: ");

            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0) {

                Console.WriteLine($"\nOS números {a} e {b} são multiplos entre si!");

            } else
            {
                Console.WriteLine($"\nOs números {a} e {b} não são multiplos!");
            }

        }
    }
}
