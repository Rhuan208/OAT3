using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_33
    {
        public void Exercicio33()
        {
            int matricula;
            double nota;
            int contador_alunos = 0;
            double soma_notas = 0;

            Console.WriteLine("Informe o número de matrícula do aluno (ou um número negativo para encerrar):");

            do
            {
                Console.Write("Número de matrícula: ");
                matricula = int.Parse(Console.ReadLine());

                if (matricula >= 0)
                {
                    Console.Write("Nota na prova: ");
                    nota = double.Parse(Console.ReadLine());

                    contador_alunos++;
                    soma_notas += nota;
                }
            } while (matricula >= 0);

            if (contador_alunos > 0)
            {
                double media = soma_notas / contador_alunos;
                Console.WriteLine("Média das notas: {0}", media);
            }
            else
            {
                Console.WriteLine("Nenhum aluno inserido.");
            }

            Console.ReadLine();
        }
    }
}

  
            
 