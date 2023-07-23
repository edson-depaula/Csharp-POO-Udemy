using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
            peso 5.
            Entrada: 
            3
            6.5 4.3 6.2
            5.1 4.2 8.1
            8.0 9.0 10.0
            Saída:
            5.7
            6.3
            9.3
            */

            Console.Write("Digite a quantidade de testes: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for(int i = 1; i <= qtd; i++)
            {
                Console.Write("Digite três notas separadas por espaço: ");
                string[] notas = Console.ReadLine().Split(' ');
                double a = double.Parse(notas[0], CultureInfo.InvariantCulture);
                double b = double.Parse(notas[1], CultureInfo.InvariantCulture);
                double c = double.Parse(notas[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine("A média ponderada é de: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }





        }
    }
}
