using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_58
    {
        public void Exercicio58()
        {
            Console.Write("Digite a quantidade de números a serem lidos: ");
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidadeNumeros];

           
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write("Digite o número {0}: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            
            double soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }
            double media = soma / quantidadeNumeros;

            int maior = int.MinValue;
            foreach (int numero in numeros)
            {
                if (numero > maior)
                    maior = numero;
            }

            Console.WriteLine("Média: {0}", media);
            Console.WriteLine("Maior valor: {0}", maior);

            Console.ReadLine();
        }
    }
}
   
            
 