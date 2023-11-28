using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_45
    {
        public void Exercicio45()
        {
            Console.Write("Informe a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Informe o número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sequência de números na ordem inversa:");

            for (int i = quantidade - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
   
            
 