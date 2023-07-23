using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            //seguir, calcule e mostre o valor da conta a pagar.


            int cod = 0, qtd = 0;

            Console.Write("Digite o código do item desejado: ");
            cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do item desejado: ");
            qtd = int.Parse(Console.ReadLine());

            double total;
            if (cod == 1)
            {
                total = qtd * 4.0;
            }
            else if (cod == 2)
            {
                total = qtd * 4.5;
            }
            else if (cod == 3)
            {
                total = qtd * 5.0;
            }
            else if (cod == 4)
            {
                total = qtd * 2.0;
            }
            else
            {
                total = qtd * 1.5;
            }

            Console.WriteLine("\nTotal a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
