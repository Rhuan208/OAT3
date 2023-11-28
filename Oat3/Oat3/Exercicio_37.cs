using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_37
    {
        public void Exercicio37()
        {
            bool voltarAoMenu = true;

            do
            {
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Encerrar o programa");
                Console.WriteLine("-----------------------");

                Console.Write("Informe a opção desejada: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RealizarOperacao("Adição", (a, b) => a + b);
                        break;
                    case "2":
                        RealizarOperacao("Subtração", (a, b) => a - b);
                        break;
                    case "3":
                        RealizarOperacao("Multiplicação", (a, b) => a * b);
                        break;
                    case "4":
                        RealizarOperacao("Divisão", (a, b) =>
                        {
                            if (b != 0)
                            {
                                return (double)a / b;
                            }
                            else
                            {
                                Console.WriteLine("Divisão por zero não é permitida.");
                                return 0;
                            }
                        });
                        break;
                    case "5":
                        voltarAoMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (voltarAoMenu);

            Console.WriteLine("Programa encerrado.");
            Console.ReadLine(); 
        }

        static void RealizarOperacao(string nomeOperacao, Func<int, int, double> operacao)
        {
            Console.WriteLine();
            Console.WriteLine("=== {0} ===", nomeOperacao);
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            double resultado = operacao(num1, num2);
            Console.WriteLine("Resultado: {0}", resultado);

            Console.WriteLine();
            Console.Write("Deseja voltar ao menu principal? (S/N): ");
            string resposta = Console.ReadLine();

            if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Encerrando o programa...");
                Environment.Exit(0);

            }
        }
    }
}

  
            
 