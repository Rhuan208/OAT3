using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_39
    {
        public void Exercicio39()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }

            if (numero >= 0)
            {
                Console.WriteLine("O número {0} é positivo.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é negativo.", numero);
            }

            Console.Write("Deseja encerrar o programa? (S/N): ");
            string resposta = Console.ReadLine();

            if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                encerrarPrograma = true;
            }

            Console.WriteLine();
        } while (!encerrarPrograma);

        Console.WriteLine("Programa encerrado.");
        Console.ReadLine(); 
        }
    }
}
 