﻿using System;
using System.Globalization;

namespace ProvaEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * (raio * raio);

            Console.WriteLine("A="+area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
