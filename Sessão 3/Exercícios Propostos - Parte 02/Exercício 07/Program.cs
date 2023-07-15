using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            situação.
            */

            double x = 0, y = 0;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de Y: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("\nPonto de Origem (0,0)");

            } else if (x > 0 && y > 0)
            {
                Console.WriteLine("\nQuadrante Q1");

            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("\nQuadrante Q4");

            } else if (x < 0 && y > 0)
            {
                Console.WriteLine("\nQuadrante Q2");

            } else 
            {
                Console.WriteLine("\nQuadrante Q3");

            }


        }
    }
}
