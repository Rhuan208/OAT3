using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_40
    {
        public void Exercicio40()
        {
            bool encerrarPrograma = false;

            do
            {
                Console.WriteLine("Informe o índice de poluição medido: ");
                double indicePoluicao = double.Parse(Console.ReadLine());

                if (indicePoluicao >= 0.05 && indicePoluicao < 0.3)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                else if (indicePoluicao >= 0.3 && indicePoluicao < 0.4)
                {
                    Console.WriteLine("Indústrias do 1º grupo intimadas a suspenderem suas atividades.");
                }
                else if (indicePoluicao >= 0.4 && indicePoluicao < 0.5)
                {
                    Console.WriteLine("Indústrias do 1º e 2º grupos intimadas a suspenderem suas atividades.");
                }
                else if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
                }
                else
                {
                    Console.WriteLine("Índice de poluição inválido.");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    encerrarPrograma = true;
                }

                Console.WriteLine();
            } while (!encerrarPrograma);

            Console.WriteLine("Programa encerrado!");
            Console.ReadLine();
        }
    }
}
   
            
 