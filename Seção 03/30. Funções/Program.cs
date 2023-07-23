using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Funções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Ex 1
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"\nMaior número: {n1}");
            }
            else if (n2 > n3)
            {
                Console.WriteLine($"\nMaior número: {n2}");
            }
            else
            {
                Console.WriteLine($"\nMaior número: {n3}");
            }
            */


            //Usando a Função
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior: {resultado}");



        }

        //Função Maior
        //int eu defino a saída do valor

        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a> c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            } 
            else
            {
                m = c;
            }

            return m;
        }


    }
}
