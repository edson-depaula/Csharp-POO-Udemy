using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002, ent = 0;
            string s2_uni = "\u263A";

            Console.Write("Digite sua senha: ");
            ent = int.Parse(Console.ReadLine());

            while (ent != senha)
            {
                Console.WriteLine("Senha inválida! Tente novamente");
                Console.Write("\nDigite sua senha: ");
                ent = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nAcesso Permitido {s2_uni}");

        }
    }
}
