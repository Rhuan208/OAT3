using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_16
    {
        public void Exercicio16()
        {
            Console.WriteLine("Digite dois números:");

            Console.WriteLine("Número 1: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Número 2: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
                Console.WriteLine("O menor número é: " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O maior número é: " + numero2);
                Console.WriteLine("O menor número é: " + numero1);
            }
            else
            {
                Console.WriteLine("Os dois números são iguais: " + numero1);

            }
        }
    }
}
            
        
    

