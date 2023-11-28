using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_57
    {
        public void Exercicio57()
        {
            Console.Write("Escreva uma frase: ");
            string frase = Console.ReadLine();

            string vogais = ObterVogais(frase);

            Console.WriteLine("Vogais na frase: {0}", vogais);

            Console.ReadLine();
        }

        static string ObterVogais(string texto)
        {
            string vogais = "";

            foreach (char c in texto)
            {
                if (IsVogal(c))
                    vogais += c;
            }

            return vogais;
        }

        static bool IsVogal(char c)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            return Array.Exists(vogais, v => v == c);
        }
    }
}
   
            
 