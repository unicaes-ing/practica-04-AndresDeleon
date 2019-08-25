using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_5
    {
        static void Main(string[] args)
        {
            string contra = "amor123", comp;
            int intentos = 0;
            bool rep = true;
            Console.WriteLine("¡Bienvenido Pablo Contreras!");
            Console.WriteLine("Ingrese su contraseña");
            do
            {
                intentos++;
                if (intentos == 2)
                {
                    Console.WriteLine("La primera letra de su contraseña es \"a\" ");
                }
                else
                {
                    if (intentos == 3)
                    {
                        Console.WriteLine("La primera letra de su contraseña es \"m\" ");
                    }
                }
                comp = Console.ReadLine();
                if (comp == contra)
                {
                    Console.WriteLine("La contraseña es correcta");
                    Console.WriteLine("Ya puede acceder en su cuenta :)");
                    rep = false;
                }
                else
                {
                    Console.WriteLine("Contraseña Incorrecta, Intentos restantes: " + (3 - intentos));
                }
            } while (rep == true && intentos != 3);
            if (intentos == 3)
            {
                Console.WriteLine("Intentos terminados, inténtelo más tarde ;)");
            }
            Console.ReadKey();
        }
    }
}
