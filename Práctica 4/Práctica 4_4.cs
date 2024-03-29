﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_4
    {
        static void Main(string[] args)
        {
            double precio = 0, sum = 0, total, bon;
            int num = 1;
            do
            {
                Console.Write("Ventas #{0}: $", num);
                if (double.TryParse(Console.ReadLine(), out precio))
                {
                    if (precio != -1)
                    {
                        sum = sum + precio;
                    }
                }
                else
                {
                    Console.WriteLine("Tiene que ser un número decimal :(");
                    num--;
                }
                num++;
            } while (precio != -1);
            bon = sum * 0.05;
            total = sum + bon;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ventas totales: " + total.ToString("C2"));
            Console.WriteLine("Bonificación de ventas: " + bon.ToString("C2"));
            Console.ReadKey();
        }
    }
}
