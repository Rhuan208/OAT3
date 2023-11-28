using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_18
    {
        public void Exercicio18()
        {
            Console.Write("Digite um número inteiro (CODIGO): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            string valorPorExtenso;

            switch (codigo)
            {
                case 1:
                    valorPorExtenso = "um";
                    break;
                case 2:
                    valorPorExtenso = "dois";
                    break;
                case 3:
                    valorPorExtenso = "três";
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    return;
            }

            Console.WriteLine("O valor por extenso do código é: " + valorPorExtenso);
            Console.ReadLine();

        }
    }
}

