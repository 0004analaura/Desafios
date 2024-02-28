using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarfiostatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inserta el primer numero:");
                int numeroUno = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserte el segundo numero: ");
                int numeroDos = int.Parse(Console.ReadLine());

                SumaDeValores(numeroUno, numeroDos);

                Console.ReadKey(true);
            }

            catch (Exception w)
            {
                Console.WriteLine("has insertado un espacio o un caracter de tipo string ");
                Console.ReadKey(true);

            }


            

        }
        static void SumaDeValores(int num1, int num2)
        {
            Console.WriteLine("La suma de los valores es: " + (num1 + num2));
        }

    }
}
