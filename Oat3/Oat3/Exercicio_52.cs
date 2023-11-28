using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_52
    {
        public void Exercicio52()
        {
            const int tamanhoMaximo = 100;
            int[] vetor = new int[tamanhoMaximo];
            int contadorUm = 0;
            int contadorTres = 0;
            int contadorQuatro = 0;
            int contador = 0;

            Console.WriteLine("Informe os números inteiros positivos separados por espaço (ou -1 para sair):");

            while (contador < tamanhoMaximo)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    break;
                }

                vetor[contador] = numero;
                contador++;

                if (numero == 1)
                {
                    contadorUm++;
                }
                else if (numero == 3)
                {
                    contadorTres++;
                }
                else if (numero == 4)
                {
                    contadorQuatro++;
                }
            }

            Console.WriteLine("Quantidade de vezes que aparece o número 1: " + contadorUm);
            Console.WriteLine("Quantidade de vezes que aparece o número 3: " + contadorTres);
            Console.WriteLine("Quantidade de vezes que aparece o número 4: " + contadorQuatro);

            Console.ReadLine();

        }
    }
}
   
            
 