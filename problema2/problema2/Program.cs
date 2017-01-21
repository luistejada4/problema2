using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdusca una palabra: ");
            String cadena = Console.ReadLine();
            Console.WriteLine("Escriba 1 si quieres justificar la cadena la izquierda o 2 para justificar la cadena a la derecha");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    cadena.PadLeft(cadena.Length);
                    break;
                case 2:
                    cadena.PadRight(cadena.Length);
                    break;
            }
            Console.WriteLine(cadena);
            Console.ReadKey();
        }
    }
}
