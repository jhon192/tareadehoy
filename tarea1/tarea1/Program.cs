using System;

namespace tarea1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que use el operador condicional para mostrar el valor absoluto
             de un numero de la siguiente forma: si el numero es positivo, se mostrara tal cual; 
             si es negativo, se mostrara el signo cambiado.*/
            
            Console.WriteLine("Verificador del valor absoluto");
            Console.Write("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); // salto de linea
            if (num>0)
            {
                Console.WriteLine(string.Concat("Este es su resultado: " ,num));
            }
            
            else if (num<0)
            {
                Console.WriteLine(string.Concat("Este numero es negativo porque contiene este signo (-): ", num));
                //string.concat es para concatenar es mas flexibe que usa el + 
            }

            else
            {
                Console.WriteLine("Este Numero tiene un valor de Cero"); //Esto es opcional
            }
            
            Console.ReadKey();
        }
    }
}
