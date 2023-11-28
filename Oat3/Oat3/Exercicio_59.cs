using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_59
    {
        public void Exercicio59()
        {
            Console.Write("Informe o primeiro caractere (de A a Z): ");
            char caractere1 = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Informe o segundo caractere (de A a Z): ");
            char caractere2 = char.Parse(Console.ReadLine().ToUpper());

            if (caractere1 >= 'A' && caractere1 <= 'Z' && caractere2 >= 'A' && caractere2 <= 'Z')
            {
                if (caractere1 < caractere2)
                {
                    int quantidadeCaracteres = caractere2 - caractere1 - 1;
                    Console.WriteLine("Número de caracteres existentes entre '{0}' e '{1}': {2}", caractere1, caractere2, quantidadeCaracteres);
                }
                else
                {
                    Console.WriteLine("Erro: Os caracteres não estão em ordem alfabética.");
                }
            }
            else
            {
                Console.WriteLine("Erro: Caracteres inválidos. Digite caracteres de A a Z.");
            }

            Console.ReadLine();

        }
    }
}
   
            
 