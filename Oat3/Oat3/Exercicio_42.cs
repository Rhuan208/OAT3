using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_42
    {
        public void Exercicio42()
        {
            int numero;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            do
            {
                Console.WriteLine("Digite um número (ou 0 para sair):");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            } while (numero != 0);

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
        }
    }
}
   
            
 