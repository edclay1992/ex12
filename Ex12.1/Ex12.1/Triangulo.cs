using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12._1
{
    internal class Triangulo
    {
        private int a1;
        private int b1;
        private int c1;
        private int resultado;

        public void setA(int a)
        { 
            a1 = a; 
        }
        public void setB(int b)
        {
            b1 = b;
        }
        public void setC(int c)
        { 
            c1 = c; 
        }
        public int getA()
        {
            return a1; 
        }
        public int getB()
        {
            return b1;
        }
        public int getC()
        {
            return c1;
        }
        public int getResultado()
        {
            return resultado;
        }
        public void Calcular()
        {
            if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
                if (a1 == b1 && a1 == c1)
                    Console.WriteLine("Triângulo Equilátero");
                else
                if (a1 == b1 || a1 == c1 || b1 == c1)
                    Console.WriteLine("Triângulo Isósceles");
                else
                    Console.WriteLine("Triângulo Escaleno");
            else
                Console.WriteLine("Não Formam Triângulo");
        }
    }
}
