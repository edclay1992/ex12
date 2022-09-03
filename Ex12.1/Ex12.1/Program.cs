using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo;
             triangulo = new Triangulo();

            Console.Write("Digite o primeiro valor: ");
            triangulo.setA(int.Parse(Console.ReadLine()));

            Console.Write("Digite o segundo valor: ");
            triangulo.setB(int.Parse(Console.ReadLine()));

            Console.Write("Digite o terceiro valor: ");
            triangulo.setC(int.Parse(Console.ReadLine()));

            triangulo.Calcular();
        }
    }
}
