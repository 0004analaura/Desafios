using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Calculadora operaciones = new Calculadora();

            Console.WriteLine("suma:" + operaciones.suma(1, 2));
            Console.WriteLine("resta:" + operaciones.resta(1, 2));
            Console.WriteLine("multiplicacion" + operaciones.multiplicacion(1, 2));
            Console.WriteLine("division" + operaciones.division(1, 2));

            Console.ReadKey(true);
        }


        class Calculadora
        {
            public int suma(int num1, int num2) {
                return num1 + num2;
            }

            
            public int resta(int num1, int num2)
            {
                return num1 - num2;
            }

            public int multiplicacion(int num1, int num2)
            {
                return num1 * num2;
            }

            public int division(int num1, int num2)
            {
                return num1 / num2;
            }

        }
    }
}
