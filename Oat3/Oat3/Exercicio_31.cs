using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_31
    {
        public void Exercicio31()
        {
           int numero = 0;
            int soma_pares = 0;
            int soma_impares = 0;

            Console.WriteLine("Informe um número positivo (ou um número negativo para encerrar):");

            do
            {
                numero = int.Parse(Console.ReadLine());

                if(numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("{0} é par", numero);
                        soma_pares += numero;
                    }
                    else
                    {
                        Console.WriteLine("{0} é ímpar", numero);
                        soma_impares += numero;
                    }
                }
            } while (numero >= 0);

            Console.WriteLine("Soma dos números pares: {0}", soma_pares);
            Console.WriteLine("Soma dos números ímpares: {0}", soma_impares);

            Console.ReadLine();

        }
    }
}

       
            
 