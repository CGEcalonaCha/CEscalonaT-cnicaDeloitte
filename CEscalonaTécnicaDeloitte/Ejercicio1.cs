using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEscalonaTécnicaDeloitte
{
    public class Ejercicio1
    {
        public static void FizzBuzz()
        {
            int i;
            int numero;

            Console.WriteLine("**Ejercicio FizzBuzz**\n");
            Console.WriteLine("Numero Hasta Donde Se Ejecutara FizzBuzz\n");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Inicio:\n");

            for (i = 1; i <= numero; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz\n");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz\n");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz\n");
                }
                else
                {
                    Console.WriteLine(i + "\n");
                }
            }

            Console.Write("Fin\n");
            Console.Write("TODO QUEDA \n ¡GOOD!");
        }
    }
}
