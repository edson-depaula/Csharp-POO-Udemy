using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"
            Entrada: 
            3
            3 -2
            -8 0
            0 8
            Saída:
            -1.5
            divisao impossivel
            0.0
            */

            int n = 0;

            Console.Write("Digite a quantidade de pares de números: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("\nDigite um par de números: ");
                string[] nums = Console.ReadLine().Split(' ');
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);

                if(b == 0)
                {
                    Console.WriteLine("Divisão impossível! Denominador 0");
                }
                else
                {
                    double divisao = (double)a / b;
                    Console.WriteLine("A divisão é igual a: " + (divisao.ToString("F1", CultureInfo.InvariantCulture)));
                }
            }

            Console.WriteLine("");


        }
    }
}
