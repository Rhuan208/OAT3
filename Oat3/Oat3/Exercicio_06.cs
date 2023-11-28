using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_06
    {
        public void Exercicio6()
        {
            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            double temperatura_celsius = double.Parse(Console.ReadLine());

            double temperatura_fahrenheit = (9 * temperatura_celsius + 160) / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + temperatura_fahrenheit.ToString("F2") + "°F");

        }
    }
}
