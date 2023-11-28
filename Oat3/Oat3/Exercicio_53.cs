using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_53
    {
        public void Exercicio53()
        {
            Console.Write("Informe a quantidade de voltas: ");
            int quantidadeVoltas = int.Parse(Console.ReadLine());

            double[] tempos = new double[quantidadeVoltas];
            double melhorTempo = double.MaxValue;
            int voltaMelhorTempo = -1;
            double somaTempos = 0;

            for (int i = 0; i < quantidadeVoltas; i++)
            {
                Console.Write("Informe o tempo da volta " + (i + 1) + ": ");
                tempos[i] = double.Parse(Console.ReadLine());
                somaTempos += tempos[i];

                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            double tempoMedio = somaTempos / quantidadeVoltas;

            Console.WriteLine("Melhor tempo: " + melhorTempo.ToString("F2"));
            Console.WriteLine("Volta do melhor tempo: " + voltaMelhorTempo);
            Console.WriteLine("Tempo médio das voltas: " + tempoMedio.ToString("F2"));

            Console.ReadLine();

        }
    }
}
   
            
 