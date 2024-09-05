using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4TP6
{
    internal class Program
    {
        static void Main(string[] args)
            /*4. Crear una función llamada “Login”, que recibe un nombre de usuario y una contraseña y que devuelve
Verdadero si el nombre de usuario es “usuario1” y si la contraseña es “epet5”. Además, la función
calculara el número de intentos que se ha usado para loguearse, tenemos solo 3 intentos, si nos
quedamos sin intentos la función devolverá Falso.*/
        {
            int intentos = 0;
            bool login = false;
            string usuario;
            string contraseña;

            do
            {
                Console.WriteLine("Ingrese el nombre de usuario");
                usuario = Console.ReadLine();

                Console.WriteLine("Ingrese la contraseña");
                contraseña = Console.ReadLine();

                login = Login(usuario, contraseña, ref intentos);

                if (login)
                {
                    Console.WriteLine("El nombre de usuario o contraseña son incorrectos");
                }
            }
            while (login && intentos < 3);

            if (login)
            {
                Console.WriteLine("Se inicio sesion con exito");
            }
            else
            {
                Console.WriteLine("Se acabaron los intentos de inicio");
            }
            Console.ReadKey();
        }

        static bool Login(string usuario, string contraseña,ref int intentos)
        {
            if (usuario == "usuario1" && contraseña == "epet5")
            {
                return true;
            }
            else
            {
                intentos++;
                return false;
            }
        }
    }
}
