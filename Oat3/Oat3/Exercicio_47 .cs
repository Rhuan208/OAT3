using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_47
    {
        public void Exercicio47()
        {
            int tamanhoVetor = 10;

            int[] vetor = new int[tamanhoVetor];

            Console.WriteLine("Informe os elementos do vetor:");
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Informe o número X: ");
            int numeroX = int.Parse(Console.ReadLine());

            int maioresQueX = 0;
            int menoresQueX = 0;
            int iguaisAX = 0;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                if (vetor[i] > numeroX)
                {
                    maioresQueX++;
                }
                else if (vetor[i] < numeroX)
                {
                    menoresQueX++;
                }
                else
                {
                    iguaisAX++;
                }
            }
            Console.WriteLine("Quantidade de números maiores que X: " + maioresQueX);
            Console.WriteLine("Quantidade de números menores que X: " + menoresQueX);
            Console.WriteLine("Quantidade de números iguais a X: " + iguaisAX);
        }
    }
}
   
            
 