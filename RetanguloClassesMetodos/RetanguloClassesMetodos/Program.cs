﻿using System;
using System.Globalization;

namespace RetanguloClassesMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
           
            Console.WriteLine("Entre com a Largura e Altura do Triangulo");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
