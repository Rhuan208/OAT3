using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_15
    {
        public void Exercicio15()
        {

            Console.WriteLine("Digite as quatro notas escolares do aluno:");

            Console.Write("Nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado! Média: " + media);
            }
            else
            {
                Console.WriteLine("O aluno não foi aprovado. Média: " + media);

                Console.Write("Digite a nota de recuperação: ");
                double notaRecuperacao = Convert.ToDouble(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;

                if (novaMedia >= 7)
                {
                    Console.WriteLine("O aluno foi aprovado na recuperação! Nova média: " + novaMedia);
                }
                else
                {
                    Console.WriteLine("O aluno não foi aprovado na recuperação. Nova média: " + novaMedia);

                }
            }
        }
    }
}
