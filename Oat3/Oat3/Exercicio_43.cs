using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_43
    {
        public void Exercicio43()
        {

            ulong total_Grains = 0;

            for (int i = 0; i < 64; i++)
            {
                ulong grainsOnSquare = (ulong)Math.Pow(2, i);
                total_Grains += grainsOnSquare;
            }

            Console.WriteLine("O número total de grãos esperado pelo monge é: " + total_Grains);
        }
    }
}
   
            
 