using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_19
    {
        public void Exercicio19()
        {

            Console.WriteLine("Informe os três valores dos lados do triângulo:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.Write("Lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Lado C: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            if (VerificarTriangulo(ladoA, ladoB, ladoC))
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo");
            }
        }

        static bool VerificarTriangulo(double ladoA, double ladoB, double ladoC)
        {
            return ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB;

        }
    }
}

            
 
