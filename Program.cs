using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //for //foreach

            /* //Caso simple for 

            for (int i = 0; i < 10; i++)
            {

            Console.WriteLine($"El numero {i}");

            } //Fin for*/

            Console.WriteLine("\nIngrese un numero para elaborar");
            int numero = Convert.ToInt32(Console.ReadLine());


            for( int i = 1; i <= 10; i++)
            {

                int multiplicacion = numero = i;

                Console.WriteLine($"{numero} x {i} = {multiplicacion}");
            }

            Console.ReadKey();
            
            }

        }
    }
