using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_21
    {
        public void Exercicio21()
        {
            int numero;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite um número inteiro (digite 0 para sair):");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numero))
                {
                    if (numero > 0)
                    {
                        Console.WriteLine("Esse número é positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("Esse número é negativo.");
                    }
                    else
                    {
                        Console.WriteLine("Digite o número 0 para encerrar o programa.");
                        continuar = false;
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido, digite um número inteiro válido.");
                }

                Console.WriteLine();

            }
        }
    }
}

       

            
 