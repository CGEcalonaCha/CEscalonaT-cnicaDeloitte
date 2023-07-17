using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEscalonaTécnicaDeloitte
{
    public class Ejercicio4
    {
        public static void VariableTemp()
        {

            int primera;
            int segunda;

            Console.WriteLine("Primer Numero");
            primera = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero");
            segunda = int.Parse(Console.ReadLine());

            Console.WriteLine("Antes:" + primera + "" + "" + segunda);
            primera = primera + segunda;
            segunda = primera - segunda;
            primera = primera - segunda;
            Console.WriteLine("Después: " + primera + "" + "" + segunda);

        }
    }
}
