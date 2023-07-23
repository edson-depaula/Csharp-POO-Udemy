using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _40.Primeiros_exercícios___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário, nome e salário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite os dados do segundo funcionário, nome e salário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (f1.Salário + f2.Salário) / 2.0;

            Console.WriteLine($"\nA média salarial é de R$ {medio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
