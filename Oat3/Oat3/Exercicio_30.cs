using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_30
    {
        public void Exercicio30()
        {
            Console.Write("Informe um número para a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do {0}:", numero);

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            }

            Console.ReadLine();
        }
    }
}

            
 