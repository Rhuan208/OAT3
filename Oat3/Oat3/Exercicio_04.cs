using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_04
    {
        public void Exercicio4()
        {
            Console.WriteLine("Informe o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            int resultado;

            resultado = A * B;
            Console.WriteLine($"A * B = {resultado}");

            resultado = A * C;
            Console.WriteLine($"A * C = {resultado}");

            resultado = A * D;
            Console.WriteLine($"A * D = {resultado}");

            resultado = B * C;
            Console.WriteLine($"B * C = {resultado}");

            resultado = B * D;
            Console.WriteLine($"B * D = {resultado}");

            resultado = C * D;
            Console.WriteLine($"C * D = {resultado}");

            Console.WriteLine("----------");

            resultado = A + B;
            Console.WriteLine($"A + B = {resultado}");

            resultado = A + C;
            Console.WriteLine($"A + C = {resultado}");

            resultado = A + D;
            Console.WriteLine($"A + D = {resultado}");

            resultado = B + C;
            Console.WriteLine($"B + C = {resultado}");

            resultado = B + D;
            Console.WriteLine($"B + D = {resultado}");

            resultado = C + D;
            Console.WriteLine($"C + D = {resultado}");
            Console.ReadLine();

        }
    }
}
    

