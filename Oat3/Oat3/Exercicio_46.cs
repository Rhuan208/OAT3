using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_46
    {
        public void Exercicio46()
        {
           
            int n = 5;

           
            int[] x = new int[n] { 1, 2, 3, 4, 5 };

          
            int[] y = new int[n] { 6, 7, 8, 9, 10 };

          
            int produtoEscalar = CalcularProdutoEscalar(x, y);

          
            Console.WriteLine("O produto escalar dos vetores x e y é: " + produtoEscalar);
        }

        static int CalcularProdutoEscalar(int[] vetorX, int[] vetorY)
        {
            if (vetorX.Length != vetorY.Length)
            {
                throw new ArgumentException("Os vetores devem ter o mesmo tamanho.");
            }

            int produtoEscalar = 0;

            for (int i = 0; i < vetorX.Length; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            return produtoEscalar;
        }
    }
}
   
            
 