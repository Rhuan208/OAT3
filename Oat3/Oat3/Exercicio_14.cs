using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_14
    {
        public void Exercicio14()
        {
            Console.WriteLine("Digite o primeiro numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("O Maior e " + num1 + " e a diferença é " + (num1 - num2));
            }
            else if ( num2 > num1)
                    {
                Console.WriteLine("O Maior e " + num2 + " e a diferença é " + (num2 - num1));
            }
        }

    }
}

            
        
    

