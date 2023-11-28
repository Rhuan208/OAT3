using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_25
    {
        public void Exercicio25()
        {

            Console.WriteLine("Informe a altura (em metros):");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Informe o sexo (M para masculino ou F para feminino):");
            string sexo = Console.ReadLine();
            Console.WriteLine("---------------------------");
            double pesoIdeal;

            if (sexo.ToUpper() == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo.ToUpper() == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, digite M ou F.");
                return;
            }

            Console.WriteLine("O peso ideal para uma pessoa com altura " + altura + " metros e sexo " + sexo.ToUpper() + " é: " + pesoIdeal + " kg.");

        }
    }
}


            
 