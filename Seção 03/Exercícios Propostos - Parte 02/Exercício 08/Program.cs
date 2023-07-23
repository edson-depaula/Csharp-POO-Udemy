using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
            mostre o valor que esta pessoa deve pagar de aliquota de Renda, segundo a tabela abaixo.
            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
            salário que fica de R$ 0.00 até R$ 2000.00 é isenta de aliquota de Renda. No exemplo fornecido (abaixo), a taxa é 
            de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
            duas casas decimais.
            */

            double salario = 0, aliquota = 0;

            Console.Write("Digite o valor do seu salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0)
            {
                aliquota = 0.0;
            }
            else if (salario <= 3000.0)
            {
                aliquota = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                aliquota = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                aliquota = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (aliquota == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("Pague de imposto R$ " + aliquota.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
