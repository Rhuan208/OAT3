using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_08
    {
        public void Exercicio8()
        {
            Console.WriteLine("Informe o raio da lata de óleo: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura da lata de óleo: ");
            double altura = double.Parse(Console.ReadLine());
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("O volume da lata de óleo é: " + volume.ToString("F2"));
            Console.ReadLine();

        }
    }
}
