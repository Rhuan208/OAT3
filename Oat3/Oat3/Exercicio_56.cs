using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_56
    {
        public void Exercicio56()
        {
            int[] vetor = new int[50];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o valor para a posição {0}: ", i);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int quantidadePares = 0;
            int quantidadeMultiplosDe5 = 0;

            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                    quantidadePares++;

                if (numero % 5 == 0)
                    quantidadeMultiplosDe5++;
            }

            Console.WriteLine("Quantidade de números pares: {0}", quantidadePares);
            Console.WriteLine("Quantidade de múltiplos de 5: {0}", quantidadeMultiplosDe5);

            Console.ReadLine();
        }
    }
}
   
            
 