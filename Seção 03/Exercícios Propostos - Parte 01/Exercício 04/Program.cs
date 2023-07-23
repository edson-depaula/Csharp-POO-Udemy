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
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais
            */

            double numFunc = 0, horasTrab = 0, valorHora = 0, salario = 0;

            Console.WriteLine("Olá, aqui iremos calcular com base em algumas informações o salário de um funcionário por horas trabalhadas.");
            Console.Write("\nQual o número desse funcionário? ");
            numFunc = double.Parse(Console.ReadLine());

            Console.Write("Quantas horas ele trabalhou? ");
            horasTrab = double.Parse(Console.ReadLine());

            Console.Write("Quanto ele recebe por hora? ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrab * valorHora;

            Console.WriteLine($"\nO funcionário número {numFunc} recebe: R${salario.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
