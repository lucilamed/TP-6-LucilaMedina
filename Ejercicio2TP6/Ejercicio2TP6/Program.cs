using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2TP6
{
    internal class Program
    {
        static void Main(string[] args)
            /*2. Realizar una función que valide si un número es impar o no. Si es impar la función debe devolver un
verdadero, si no es impar debe devolver falso. Nota: la función no debe tener mensajes que digan si es
par o no.*/
        {
            int numero;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            bool esimpar = impar(numero);
            Console.WriteLine(esimpar);

            Console.ReadKey();

        }
        static bool impar (int num)
        {
            return num % 2 != 0;
        }
    }
}
