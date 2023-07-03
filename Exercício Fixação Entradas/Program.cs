using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.CodeDom.Compiler;

namespace ExercícioFixaçãoEntradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
            Entre com seu nome completo:
            Alex Green
            Quantos quartos tem na sua casa?
            3
            Entre com o preço de um produto:
            500.50
            Entre seu último nome, idade e altura(mesma linha):
            Green 21 1.73
            
            SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS):
            Alex Green
            3
            500.50
            Green
            21
            1.73
            */


            Console.Write("Digite seu nome completo: ");
            string nomeCompl = Console.ReadLine();

            Console.Write("\nQuantos quartos tem na sua casa? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o preço de um produto: ");
            double valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nDigite seu último nome, sua idade e sua altura: ");
            string[] nomeIdadeAltura = Console.ReadLine().Split(' ');
            string ultimoNome = nomeIdadeAltura[0];
            int idade = int.Parse(nomeIdadeAltura[1]);
            double altura = double.Parse(nomeIdadeAltura[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"\nO nome completo digitado foi: {nomeCompl}");
            Console.WriteLine($"A quantidade de quartos na casa é de: {qtdQuartos}");
            Console.WriteLine($"O valor do produto é de: R${valorProd.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O último nome é: {ultimoNome}");
            Console.WriteLine($"A idade digitada é: {idade} anos");
            Console.WriteLine($"A altura digitada é de: {altura.ToString("F2", CultureInfo.InvariantCulture)}Mts");

        }
    }
}
