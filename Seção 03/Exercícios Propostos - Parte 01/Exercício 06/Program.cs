using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
            mostre: 
            a) a área do triângulo retângulo que tem A por base e C por altura. 
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B. 
            e) a área do retângulo que tem lados A e B.

            Entrada: 3.0 4.0 5.2
            Saída:
            TRIANGULO: 7.800
            CIRCULO: 84.949
            TRAPEZIO: 18.200
            QUADRADO: 16.000
            RETANGULO: 12.000
            */

            double a = 0, b = 0, c = 0, triangRet = 0, circulo = 0, trapezio = 0, quadrado = 0, retangulo = 0;

            Console.WriteLine("Olá! Aqui calcularemos a área de algumas formas\n");

            Console.Write("Digite o valor de \"A\", \"B\" e \"C\": ");
            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangRet = (a * c) / 2.0;
            circulo = c * c * 3.14159;
            trapezio = (a + b) / 2.0 * c;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine($"\nTriângulo: {triangRet.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}\n");
        }
    }
}
