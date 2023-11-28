using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_05
    {
        public void Exercicio5()
        {
            Console.WriteLine("Informe o tempo gasto na viagem (em horas): ");
            double tempo_gasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade média (em Km/h): ");
            double velocidade_media = double.Parse(Console.ReadLine());

            double distancia = tempo_gasto * velocidade_media;
            double litros_usados = distancia / 12;

            Console.WriteLine("Velocidade média: " + velocidade_media + " Km/h");
            Console.WriteLine("Tempo gasto: " + tempo_gasto + " Hrs");
            Console.WriteLine("Distância percorrida: " + distancia + " Km");
            Console.WriteLine("Quantidade de litros utilizada na viagem: " + litros_usados.ToString("F2") + " litros");



        }
    }
}
