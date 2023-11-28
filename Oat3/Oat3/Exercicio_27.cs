using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_27
    {
        public void Exercicio27()
        {
            Console.WriteLine("Informe a quantidade de números a serem processados:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Digite o número #" + i + ":");
                int numero = int.Parse(Console.ReadLine());

                long fatorial = CalcularFatorial(numero);
                Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
                Console.WriteLine();
            }
        }

        static long CalcularFatorial(int numero)
        {
            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;

        }
    }
}


       
    


            
 