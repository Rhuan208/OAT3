using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_36
    {
        public void Exercicio36()
        {
            const int quantidadeValores = 10;
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int soma = 0;

            Console.WriteLine("Digite {0} valores inteiros e positivos:", quantidadeValores);

            for (int i = 0; i < quantidadeValores; i++)
            {
                int valor = LerValorInteiroPositivo();

                if (valor > maior)
                {
                    maior = valor;
                }

                if (valor < menor)
                {
                    menor = valor;
                }

                soma += valor;
            }

            double media = (double)soma / quantidadeValores;

            Console.WriteLine("Maior valor: {0}", maior);
            Console.WriteLine("Menor valor: {0}", menor);
            Console.WriteLine("Média dos valores: {0}", media);

            Console.ReadLine();
        }

        static int LerValorInteiroPositivo()
        {
            int valor;
            bool valorValido;

            do
            {
                Console.Write("Digite um valor inteiro positivo: ");
                string input = Console.ReadLine();

                valorValido = int.TryParse(input, out valor);

                if (!valorValido || valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite um valor inteiro positivo.");
                }

            } while (!valorValido || valor <= 0);

            return valor;

        }
    }
}

            
 