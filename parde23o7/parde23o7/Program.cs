using System;

namespace parde23o7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que escriba en pantalla los numeros pares
             del 23 al 7 en orden descendente, usando while.*/
            Console.WriteLine("Par de 23 y 7");
            int num = 23;
            while (num>7)
            {
                Console.WriteLine(num);
                num = num - 2;
            }
            
            Console.ReadKey();
            
        }
    }
}
