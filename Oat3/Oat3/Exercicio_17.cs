using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_17
    {
        public void Exercicio17()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");

            }
        }
    }
}
            
  
