﻿using System;
using System.Globalization;

namespace Idades_URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont = 0;
            double media, soma = 0.0;

            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                soma = soma + idade;
                cont++;
                idade = int.Parse(Console.ReadLine());               
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture)); 

        }
    }
}
