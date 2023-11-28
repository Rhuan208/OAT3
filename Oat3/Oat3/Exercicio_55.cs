using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_55
    {
        public void Exercicio55()
        {
            Console.Write("Escreva uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();

            string fraseSemEspacos = frase.Replace(" ", "");
            int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;

            Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
            Console.WriteLine("Quantidade de espaços em branco: " + quantidadeEspacos);

            Console.ReadLine();
        }
    }
}
   
            
 