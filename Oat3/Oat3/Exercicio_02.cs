using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    public class Exercicio_02
    {
        public void Exercicio2()
        {
            Console.WriteLine("Qual a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Qual o valor em dólares: ");
            double valorDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            double valorReal = valorDolar * cotacaoDolar;

            Console.WriteLine("O valor em reais é: R$" + valorReal.ToString("F2"));
            Console.ReadLine();
        }
    }
}