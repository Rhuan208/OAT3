using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_48
    {
        public void Exercicio48()
        {
            int quantidadeCandidatas = 20;

            string[] nomes = new string[quantidadeCandidatas];
            int[] idades = new int[quantidadeCandidatas];

            Console.WriteLine("Digite o nome e idade das candidatas:");
            for (int i = 0; i < quantidadeCandidatas; i++)
            {
                Console.Write("Nome da candidata {0}: ", i + 1);
                nomes[i] = Console.ReadLine();

                Console.Write("Idade da candidata {0}: ", i + 1);
                idades[i] = int.Parse(Console.ReadLine());
            }

            string[] candidatasAptas = new string[quantidadeCandidatas];
            int contador = 0;

            for (int i = 0; i < quantidadeCandidatas; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    candidatasAptas[contador] = nomes[i];
                    contador++;
                }
            }
            Console.WriteLine("Candidatas aptas para a campanha publicitária:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(candidatasAptas[i]);

            }
        }
    }
}
   
            
 