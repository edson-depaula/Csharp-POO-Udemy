using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.
            Exemplos:
            Entrada: 10, 30 Saída: SOMA = 40
            */

            double num1 = 0;
            double num2 = 0;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nA soma dos números é: {num1 + num2}.");

        }
    }
}
