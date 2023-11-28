using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_23
    {
        public void Exercicio23()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Informe o primeiro número:");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número:");
                double numero2 = double.Parse(Console.ReadLine());
                double resultado = numero1 + numero2;
                Console.WriteLine("O resultado da adição é: " + resultado);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Informe o primeiro número:");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número:");
                double numero2 = double.Parse(Console.ReadLine());
                double resultado = numero1 - numero2;
                Console.WriteLine("O resultado da subtração é: " + resultado);
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Informe o primeiro número:");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número:");
                double numero2 = double.Parse(Console.ReadLine());
                double resultado = numero1 * numero2;
                Console.WriteLine("O resultado da multiplicação é: " + resultado);
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Informe o primeiro número:");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número:");
                double numero2 = double.Parse(Console.ReadLine());

                if (numero2 != 0)
                {
                    double resultado = numero1 / numero2;
                    Console.WriteLine("O resultado da divisão é: " + resultado);
                }
                else
                {
                    Console.WriteLine("Erro: divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");

            }
        }
    }
}


   
            
 