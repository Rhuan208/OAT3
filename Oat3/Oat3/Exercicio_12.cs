using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_12
    {
        public void Exercicio12()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int modulo = Math.Abs(numero);

            Console.WriteLine("O módulo do número é: " + modulo);
        }
    }
}
