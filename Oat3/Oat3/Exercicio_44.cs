using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_44
    {
        public void Exercicio44()
        {
            char encerrar = 'N';

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("S - Encerrar o programa");
                Console.WriteLine();

                Console.Write("Opção: ");
                char opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        ConversaoCelsiusParaFahrenheit();
                        break;
                    case '2':
                        ConversaoFahrenheitParaCelsius();
                        break;
                    case '3':
                        PesoIdealHomem();
                        break;
                    case '4':
                        PesoIdealMulher();
                        break;
                    case 'S':
                    case 's':
                        encerrar = 'S';
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (encerrar != 'S');
        }

        static void ConversaoCelsiusParaFahrenheit()
        {
            Console.WriteLine("Conversão de Graus Celsius em Graus Fahrenheit");
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
        }

        static void ConversaoFahrenheitParaCelsius()
        {
            Console.WriteLine("Conversão de Graus Fahrenheit em Graus Celsius");
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperatura em Celsius: " + celsius);
        }

        static void PesoIdealHomem()
        {
            Console.WriteLine("Cálculo do Peso Ideal para Homem");
            Console.Write("Digite a altura em centímetros: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = (72.7 * altura / 100) - 58;
            Console.WriteLine("Peso ideal: " + pesoIdeal + " kg");

            Console.Write("Digite o peso atual em kg: ");
            double pesoAtual = double.Parse(Console.ReadLine());

            if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (pesoAtual > pesoIdeal)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está no peso ideal.");
            }
        }

        static void PesoIdealMulher()
        {
            Console.WriteLine("Cálculo do Peso Ideal para Mulher");
            Console.Write("Digite a altura em centímetros: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = (62.1 * altura / 100) - 44.7;
            Console.WriteLine("Peso ideal: " + pesoIdeal + " kg");

        }
    }
}
 
   
            
 