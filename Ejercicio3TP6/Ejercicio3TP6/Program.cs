using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3TP6
{
    internal class Program
    {
        static void Main(string[] args)
            /*3. Realizar un programa que pida al usuario una frase y una letra a buscar en esa frase. La función debe
devolver la cantidad de veces que encontró la letra. Nota: recordar el uso de la función Subcadena().*/
        {
            string frase;
            char letra;
            int cantidad;

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            Console.WriteLine("Ingrese una letra para encontrarla en la frase");
            letra = Convert.ToChar(Console.ReadLine());

            cantidad = contador(frase, letra);
            Console.WriteLine("La letra " + letra + " aparece " + cantidad + " veces en la frase ");

            Console.ReadKey();
        }
        static int contador(string frase, char letra)
        {
            int contador = 0;

            foreach (char caracter in frase)
            {
                if(caracter == letra)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
