using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Problema_sem_POO
{
    internal class Triangulo
    {
        //atributos A, B e C
        public double A;
        public double B;
        public double C;

        //Método é uma função dentro da classe
        //o "public" permite que o método seja acessado em outro arquivo
        public double Area()
        {
            //A, B e C ele enxerga direto os atributos, e não os triangulos x ou y
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
