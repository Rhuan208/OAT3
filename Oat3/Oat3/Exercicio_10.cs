using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_10
    {
        public void Exercicio10()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================");
            Console.WriteLine("Relacionamentos de ordem:");
            Console.WriteLine("=========================");


            if (numero1 == numero2)
            {
                Console.WriteLine("(Igual)");
            }
            else
            {
                Console.WriteLine("(Não igual)");
            }
            if (numero1 > numero2)
            {
                Console.WriteLine("(Maior)");
                Console.WriteLine("(Maior ou igual)");
            }
            else
            {
                Console.WriteLine("(Menor)");
                Console.WriteLine("(Menor ou igual)");
            }
            Console.ReadLine();
        }
    }
}
