using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_13
    {
        public void Exercicio13()
        {
            Console.WriteLine("Informe três números inteiros:");

            Console.Write("Número 1: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 3: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 >= numero2 && numero1 >= numero3)
            {
                if (numero2 >= numero3)
                {
                    Console.WriteLine("Os números em ordem decrescente são: " + numero1 + ", " + numero2 + ", " + numero3);
                }
                else
                {
                    Console.WriteLine("Os números em ordem decrescente são: " + numero1 + ", " + numero3 + ", " + numero2);
                }
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                if (numero1 >= numero3)
                {
                    Console.WriteLine("Os números em ordem decrescente são: " + numero2 + ", " + numero1 + ", " + numero3);
                }
                else
                {
                    Console.WriteLine("Os números em ordem decrescente são: " + numero2 + ", " + numero3 + ", " + numero1);
                }
            }
            else
            {
                if (numero1 >= numero2)
                {
                    Console.WriteLine("Os números em ordem decrescente são: " + numero3 + ", " + numero1 + ", " + numero2);
                }
                else
                {
                    Console.WriteLine("Os números em ordem decrescente são: " + numero3 + ", " + numero2 + ", " + numero1);

                }
            }
        }
    }
}

            
        
    

