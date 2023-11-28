using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_34
    {
        public void Exercicio34()
        {
           int numero;
            int menor = int.MaxValue;
            int maior = int.MinValue;

            Console.WriteLine("Digite um número positivo (ou um número negativo para encerrar):");

            do
            {
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                }
            } while (numero >= 0);

            if (menor == int.MaxValue)
            {
                Console.WriteLine("Nenhum número foi inserido.");
            }
            else
            {
                Console.WriteLine("Menor número: {0}", menor);
                Console.WriteLine("Maior número: {0}", maior);
            }

            Console.ReadLine();
        }
    }
}
    

            
 