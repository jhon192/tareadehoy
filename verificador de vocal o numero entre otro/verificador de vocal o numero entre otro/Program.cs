using System;

namespace verificador_de_vocal_o_numero_entre_otro
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que lea una letra tecleada por el usuario
             y diga si se trata de una vocal, una cifra numerica o una constante.
            Tips: usar dato tipo "char".*/

            char tecla;
            Console.WriteLine("Verificador de vocales o numero entre otros");
            Console.Write("Ingrese un Dato: ");
            tecla = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            if (tecla == 'a' || tecla == 'e' || tecla == 'i' || tecla == 'o' || tecla == 'u')
            {
                Console.WriteLine("Esto es una vocal");
            }
            
            else if (tecla == '1' || tecla == '2' || tecla == '3' || tecla == '4' || tecla == '5' ||
            tecla == '6' || tecla == '7' || tecla == '8' || tecla == '9' || tecla == '0')
            {
                Console.WriteLine("Esto es una cifra numerica");
            }
            
            else
            {
                Console.WriteLine("Esto es una constante");
            }
        }
    }
}