﻿using Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> list = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));

                }                

            }
            
            double total = 0.0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");       


            foreach (Payers tp in list)
            {

                Console.WriteLine(tp.Name + ": $ " + tp.Tax().ToString("F2", CultureInfo.InvariantCulture));

                total += tp.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
