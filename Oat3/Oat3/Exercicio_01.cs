using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    public class Exercicio_01
    {
        public void Exercicio1()
        {
            Console.WriteLine("Iforme a quantidade mínima de peças: ");
            int quantidade_minima = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima de peças: ");
            int quantidade_maxima = int.Parse(Console.ReadLine());

            double estoque_medio = (quantidade_minima + quantidade_maxima) / 2;

            Console.WriteLine("O estoque médio é: " + estoque_medio);
            Console.ReadLine();
        }
    }

}
