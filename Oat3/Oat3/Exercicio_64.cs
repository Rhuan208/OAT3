using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_64
    {
        public void Exercicio64()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares existentes nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares existentes nas posições pares do vetor");
            Console.WriteLine("7 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirPares();
                    break;
                case 4:
                    ExibirImpares();
                    break;
                case 5:
                    ContarParesPosicoesImpares();
                    break;
                case 6:
                    ContarImparesPosicoesPares();
                    break;
                case 7:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
   
            
 