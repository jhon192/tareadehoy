using System;

namespace mayor_del_otro
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Usar el operador condicional para calcular el menor de dos numeros.*/

            Console.WriteLine("Verificador de Mayores");
            int num1, num2;
            Console.Write("Ingrese el primero numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (num1>num2)
            {
                Console.WriteLine(string.Concat(num1," Es mayor que ", num2));
            }
            
            else if (num2>num1)
            {
               Console.WriteLine(string.Concat(num2," Es mayor que ", num1)); 
            }

            else
            {
                Console.WriteLine("Todos son iguales");
            }
            
            Console.ReadKey();
        }
    }
}
