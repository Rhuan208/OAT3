using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_51
    {
        public void Exercicio51()
        {
            Console.Write("Informe a quantidade de alunos: ");
            int quantidade_alunos = int.Parse(Console.ReadLine());
            double[] notas = new double[quantidade_alunos];
            double somaNotas = 0;
            int alunosAcimaDeSete = 0;

            for (int i = 0; i < quantidade_alunos; i++)
            {
                Console.Write("Digite a nota do aluno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                somaNotas += notas[i];

                if (notas[i] > 7.0)
                {
                    alunosAcimaDeSete++;
                }
            }

            if (quantidade_alunos > 0)
            {
                double media = somaNotas / quantidade_alunos;
                Console.WriteLine("A média aritmética das notas é: " + media.ToString("F2"));

                if (alunosAcimaDeSete > 0)
                {
                    Console.WriteLine("Quantidade de alunos com nota acima de 7.0: " + alunosAcimaDeSete);
                }
                else
                {
                    Console.WriteLine("Não há nenhum aluno com nota acima de 7.0.");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno foi inserido.");
            }

            Console.ReadLine();

        }
    }
}
   
            
 