using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_24
    {
        public void Exercicio24()
        {
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = int.Parse(Console.ReadLine());

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Verificar se um dos números lidos é múltiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números lidos são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                        {
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                        }
                        break;

                    case "2":
                        if (numero1 % 2 == 0 && numero2 % 2 == 0)
                        {
                            Console.WriteLine("Os dois números são pares.");
                        }
                        else
                        {
                            Console.WriteLine("Pelo menos um dos números não é par.");
                        }
                        break;

                    case "3":
                        double media = (numero1 + numero2) / 2.0;
                        if (media >= 7)
                        {
                            Console.WriteLine("A média dos números é maior ou igual a 7.");
                        }
                        else
                        {
                            Console.WriteLine("A média dos números é menor do que 7.");
                        }
                        break;

                    case "4":
                        sair = true;
                        Console.WriteLine("Programa encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        break;
                }

            }
        }
    }
}

            
 