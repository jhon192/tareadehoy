using System;

namespace signo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que lea una letra tecleada
             por el usuario y diga si se trata de un signo de puntuacion, 
             una cifra numerica o algun otro caracter.*/

            Console.WriteLine("Verificador de Signos");
            Console.Write("Ingrese una Letra/Signo: ");
            string sig = Console.ReadLine();
            Console.WriteLine(); // salto de linea
            if (sig == ";" || sig == "." || sig == "," || sig == ":")
            {
                Console.WriteLine("Esto es un Signo de Puntuacion");
            }
            
            else if (sig == "1" || sig == "2" || sig == "3" || sig == "4" || sig == "5" || 
                     sig == "6" || sig == "7" || sig == "8" || sig == "9" || sig == "00")
            {
                Console.WriteLine("Esto es un cifra numerica");
            }

            else
            {
                Console.WriteLine("Esto es un caracter");
            }
            
            Console.ReadKey();
        }
    }
}
