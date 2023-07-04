using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
        //Entrada:  12 1 5.30   16 2 5.10    Saída: VALOR A PAGAR: R$ 15.50


            int codPeca1 = 0, codPeca2 = 0, qtdPeca1 = 0, qtdPeca2 = 0;
            double valPeca1 = 0, valPeca2 = 0, total = 0;

            Console.WriteLine("Olá! Aqui iremos calcular o valor total a pagar do itens escolhidos");

            Console.Write("\nDigite o código, quantidade e valor unitário da peça 1: ");
            string[] valores = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(valores[0]);
            qtdPeca1 = int.Parse(valores[1]);
            valPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.Write("Digite o código, quantidade e valor unitário da peça 2: ");
            valores = Console.ReadLine().Split(' ');

            codPeca2 = int.Parse(valores[0]);
            qtdPeca2 = int.Parse(valores[1]);
            valPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = qtdPeca1 * valPeca1 + qtdPeca2 * valPeca2;

            Console.WriteLine("\nValor a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
