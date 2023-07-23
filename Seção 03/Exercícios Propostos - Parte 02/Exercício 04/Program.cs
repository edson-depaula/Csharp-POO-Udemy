using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas

            int horaIni = 0, horaFin = 0, duracao = 0; ;

            Console.Write("A que horas o jogo iniciou? ");
            horaIni = int.Parse(Console.ReadLine());

            Console.Write("A que horas o jogo acabou? ");
            horaFin = int.Parse(Console.ReadLine());

            if (horaIni < horaFin)
            {
                duracao = horaFin - horaIni;
            }
            else
            {
                duracao = 24 - horaIni + horaFin;
            }

            Console.WriteLine($"\nA duração do jogo foi de {duracao} horas.");

        }
    }
}
