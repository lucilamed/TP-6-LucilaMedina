using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1TP6
{
    internal class Program
    {
        static void Main(string[] args)
            /*1. Crear una función que calcule la suma de dos números. En el programa principal, solicitaremos al
usuario que ingrese los dos números para luego pasarlos como argumentos a la función. La función
realizará el cálculo de la suma y devolverá el resultado, que será mostrado para su visualización.*/
        {
            double num1;
            double num2;
            double resultado;

            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 + num2;
            Console.WriteLine("La suma de los numeros ingresados es: " + resultado);
            Console.ReadKey();


        }
        static double suma ( double a, double b) 
        {
            return a + b;
        
        }
    }
}
