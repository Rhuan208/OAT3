using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_09
    {
        public void Exercicio9()
        {
            Console.WriteLine("Informe a sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int idadeEmDias = anos * 365 + meses * 30 + dias;

            Console.WriteLine("A idade em dias é: " + idadeEmDias + " dias");
            Console.ReadLine();
        }
    }
}
