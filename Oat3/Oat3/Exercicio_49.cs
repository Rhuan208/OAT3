using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_49
    {
        public void Exercicio49()
        {
           
            int n = 0;
            do
            {
                Console.Write("Informe o tamanho dos vetores (entre 1 e 50): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 50);

            
            int[] v1 = new int[n];
            int[] v2 = new int[n];

            
            Console.WriteLine("Informe os elementos do vetor V1:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe os elementos do vetor V2:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemento {0}: ", i + 1);
                v2[i] = int.Parse(Console.ReadLine());
            }

           
            int contador = 0;

            
            for (int i = 0; i < n; i++)
            {
                if (v1[i] == v2[i])
                {
                    contador++;
                }
            }

           
            Console.WriteLine("Quantidade de valores idênticos nas mesmas posições: " + contador);
        }
    }
}
   
            
 