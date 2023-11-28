using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_63
    {
        public void Exercicio63()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            string resultado = Verifica(numero);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        static string Verifica(int numero)
        {
            if (numero % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "ÍMPAR";

            }
        }
    }
}
   
            
 