using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_32
    {
        public void Exercicio32()
        {
            Console.WriteLine("Digite um número entre 1 e 10:");
            int numero;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > 0 && numero < 10)
                    {
                        break; 
                    }
                }

                Console.WriteLine("Número inválido. Digite um número entre 1 e 10:");
            }

            int contador = 0;
            int soma_Quadrados = 0;

            for (int i = numero; contador < 20; i += 2)
            {
                soma_Quadrados += i * i;
                contador++;
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é: {soma_Quadrados}");
        }
    }
}
  


            
 