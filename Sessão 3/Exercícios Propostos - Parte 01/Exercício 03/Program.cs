using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

            double a = 0, b = 0, c = 0, d = 0, diferenca = 0;

            Console.WriteLine("Olá! Aqui, faremos um cálculo da diferença da multiplicação de quatro números\n");
            Console.Write("Informe o valor do primeiro número(a): ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do segundo número(b): ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do terceiro número(c): ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do quarto número(d): ");
            d = double.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);

            Console.WriteLine($"\nA diferença entre os números, conforme a fórmula (A * B - C * D) é de: {diferenca}");    

        }
    }
}
