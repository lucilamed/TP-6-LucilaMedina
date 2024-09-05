using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7TP6
{
    internal class Program
    {
        static void Main(string[] args)
            /*7. Diseñar un procedimiento que reciba una frase, y el programa remueva todas las vocales . Al final el
procedimiento mostrará la frase final.
Por ejemplo:
Entrada: “Habia una vez un barco”
Salida: “Hb n vz n brc"*/
        {
            string frase;
            string remover;

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            remover(frase);
        }
    }
}
