﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat3
{
    internal class Exercicio_41
    {
        public void Exercicio41()
        {
            Console.WriteLine("Informe a idade do nadador:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Categoria: Infantil A");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Categoria: Infantil B");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Categoria: Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Categoria: Juvenil B");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Categoria: Adulto");
            }
            else
            {
                Console.WriteLine("Idade inválida.");

            }
        }
    }
}
   
            
 