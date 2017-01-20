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
            Hashtable diccionario = new Hashtable();
            diccionario.Add("correr", "es un proceso complejo y coordinado que involucra a todo el cuerpo.\nCada ser humano corre de una manera diferente,\npero ciertos aspectos generales de los movimientos de la carrera son comunes.\n");
            Console.WriteLine("Por favor introdusca una palabra para ver su definicion: ");
            String palabra = Console.ReadLine();
            if(diccionario.ContainsKey(palabra))
            {
                Console.Write(diccionario[palabra]);
            }
            else
            {
                Console.WriteLine("Esta palabra no se encuentra en el diccionario!");
            }
            Console.ReadKey();
        }
    }
}
