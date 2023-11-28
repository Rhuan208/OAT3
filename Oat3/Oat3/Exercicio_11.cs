using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_11
    {
        public void Exercicio11()
        {

            Console.WriteLine("Informe o valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Valores Informados:");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            int auxiliar = A;
            A = B;
            B = auxiliar;

            Console.WriteLine("Valores trocados:");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }
}
