using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_50
    {
        public void Exercicio50()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(101);
            int tentativas = 0;
            int tentativa;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar um número de 0 a 100.");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                if (tentativa < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior do que sua tentativa.");
                }
                else if (tentativa > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor do que sua tentativa.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número sorteado em " + tentativas + " tentativas.");
                }
            }
            while (tentativa != numeroSorteado);

            Console.ReadLine();

        }
    }
}
   
            
 