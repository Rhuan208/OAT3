using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_20
    {
        public void Exercicio20()
        {
            int a, b, c;

            do
            {
                Console.Write("Digite o valor de 'a' (maior que zero): ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

            do
            {
                Console.Write("Digite o valor de 'b' (maior que zero): ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

            do
            {
                Console.Write("Digite o valor de 'c' (maior que zero): ");
            } while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

            int menorValor = Math.Min(Math.Min(a, b), c);
            int maiorValor = Math.Max(Math.Max(a, b), c);

            int resultadoMultiplicacao = menorValor * maiorValor;
            double resultadoDivisao = (double)maiorValor / menorValor;

            Console.WriteLine("O menor valor lido multiplicado pelo maior é: " + resultadoMultiplicacao);
            Console.WriteLine("O maior valor dividido pelo menor é: " + resultadoDivisao);

        }
    }
}

            
 