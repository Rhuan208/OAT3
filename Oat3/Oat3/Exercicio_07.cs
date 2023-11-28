using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_07
    {
        public void Exercicio7()
        {
            Console.WriteLine("Informe a temperatura em graus Fahrenheit: ");
            double temperatura_fahrenheit = double.Parse(Console.ReadLine());
            double temperatura_celsius = (temperatura_fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em graus Celsius é: " + temperatura_celsius.ToString("F2") + "°C");
            Console.ReadLine();
        }
    }
}
