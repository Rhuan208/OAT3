using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_03
    {
        public void Exercicio3()
        { 
        Console.WriteLine("Digite a identificação do vendedor: ");
            int identificacao_vendedor = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite o código da peça: ");
            int codigo_peca = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite o preço unitário da peça: ");
            double preco_unitario = double.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite a quantidade vendida: ");
            int quantidade_vendida = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------");
            double total_venda = preco_unitario * quantidade_vendida;
        double comissao = total_venda * 0.05;
        Console.WriteLine("Identificação do vendedor: " + identificacao_vendedor);
            Console.WriteLine("Código da peça: " + codigo_peca);
            Console.WriteLine("Total da venda: R$" + total_venda.ToString("F2"));
            Console.WriteLine("Comissão do vendedor: R$" + comissao.ToString("F2"));

        }
    }
}
