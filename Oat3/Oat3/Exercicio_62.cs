using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_62
    {
        public void Exercicio62()
        {
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);
            double area = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine("Hipotenusa do triângulo: {0}", hipotenusa);
            Console.WriteLine("Área do triângulo: {0}", area);

            Console.ReadLine();
        }

        static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double hipotenusaQuadrado = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);
            double hipotenusa = Math.Sqrt(hipotenusaQuadrado);
            return hipotenusa;

        }
    }
}
   
            
 