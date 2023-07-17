using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEscalonaTécnicaDeloitte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {

                try
                {
                    Console.WriteLine("SELECCIONA UNA OPCION\n");
                    Console.WriteLine("1. Fizz Buzz");
                    Console.WriteLine("2. Anagrama");
                    Console.WriteLine("3. Comprension Basica");
                    Console.WriteLine("4. Variable Temporal");
                    Console.WriteLine("5. Matriz");
                    Console.WriteLine("0. SALIR\n");
                 
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Ejercicio1.FizzBuzz();
                            break;

                        case 2:
                            Ejercicio2.Anagrama();
                            break;

                        case 3:
                            Ejercicio3.LetrasRepetidas();
                            break;
                        case 4:
                            Ejercicio4.VariableTemp();
                            break;
                        case 5:
                            Ejercicio5.Matriz();
                            break;

                        case 0:
                            Console.WriteLine("Salir");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("elige una Opcion");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
