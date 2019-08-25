using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica4_1
    {
        static void Main(string[] args)
            //Andrés Lemus 14/08/2019
        {
            Console.WriteLine("Sueldos de Adventure Company");
            Console.WriteLine();
            decimal sueldo = 0, sum = 0, prom = 0;
            for (int n = 1; n < 21; n++)
            {
                Console.Write("Sueldo del empleado " + n + ": $");
                if (decimal.TryParse(Console.ReadLine(), out sueldo) && sueldo >= 0)
                {
                    sum = sum + sueldo;
                }
                else
                {
                    Console.WriteLine("El valor tiene que ser un decimal positivo :(");
                    n--;
                    
                }
                Console.WriteLine();
            }
            prom = sum / 20;
            Console.WriteLine("Cantidad total a pagar:  " + sum.ToString("C2"));
            Console.WriteLine("Valor Promedio de sueldos:  " + prom.ToString("C2"));
            Console.ReadKey();
        }
    }
}
