using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_22
    {
        public void Exercicio22()
        {
            int numero;
            int a = 0;
            int b = 0;

            Console.WriteLine("Informe um número: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                if (numero > 0)
                {
                    a = numero;
                    Console.WriteLine("O número é positivo e foi armazenado em A.");
                }
                else if (numero < 0)
                {
                    b = numero;
                    Console.WriteLine("O número é negativo e foi armazenado em B.");
                }
                else
                {
                    Console.WriteLine("O número digitado é zero.");
                }

                Console.WriteLine("Valor em A: " + a);
                Console.WriteLine("Valor em B: " + b);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");

            }
        }
    }
}



            
 