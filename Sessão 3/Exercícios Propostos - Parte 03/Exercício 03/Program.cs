using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.
            */

            int alcool = 0, gasolina = 0, diesel = 0, tipo = 0;
            string smile = "\u263A";

            Console.Write("Alcool = 1 | Gasolina = 2 | Diesel = 3");
            Console.Write("\n\nDigite o tipo de combustível: ");
            tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool += 1;
                }
                else if (tipo == 2)
                {
                    gasolina += 1;
                }
                else if (tipo == 3)
                {
                    diesel += 1;
                }

                Console.Write("Digite o tipo de combustível: ");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nMuito obrigado! {smile}");
            Console.WriteLine($"\nSeus clientes preferem:");
            Console.WriteLine($"Alcool = {alcool} | Gasolina = {gasolina} | Diesel = {diesel}\n");

        }
    }
}
