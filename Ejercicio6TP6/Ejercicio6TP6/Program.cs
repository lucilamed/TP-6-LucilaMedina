using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6TP6
{
    internal class Program
    {
        static void Main(string[] args)
            /*6. Crear un programa que dibuje una escalera de números, donde cada línea de números comience en uno
y termine en el número de la línea. Solicitar la altura de la escalera al usuario al comenzar. Ejemplo: si se
ingresa el número 3:
1
12
123*/
        {
            int numero;
            int escalera;

            Console.WriteLine("Ingrese la altura de la escalera en numeros");
            numero = int.Parse(Console.ReadLine());

            escalera = Escalera(numero);

            Console.ReadKey();
        }
        public static int Escalera(int numero)
        {
            int N1;
            int N2;
            for (N1 = 1; N1 <= numero; N1++)
            {
                for ( N2 = 1; N2 < N1 ; N2++)
                {
                    Console.Write(N2);
                }
                Console.WriteLine(N2);
            }
            return numero;
        }
    }
}
