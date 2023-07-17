using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEscalonaTécnicaDeloitte
{
    public class Ejercicio2
    {
        public static void Anagrama()
        {
            string palabra1;
            string palabra2;
            Console.WriteLine("**Anagrama**\n");
            Console.WriteLine("Primerapalabra a comparar");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Segunda palabra a comparar");
            palabra2 = Console.ReadLine();

            if (palabra1.Equals(palabra2))
            {
                Console.WriteLine("Son anagramas");
            }
            else
            {
                Console.WriteLine("No son anagramas");
            }

            Console.ReadKey();
        }
    }
}
