using System;
class HelloWord
{
    static void Main()
    {
        CalculoDeMeses(5000, 2500, 3000);
        Console.ReadKey(true);
    }

    public static void CalculoDeMeses(int mesUno, int mesDos, int mesTres)

    {
        string nombre;

        int suma = mesUno + mesDos + mesTres;
        int promedio = suma / 3;
        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola {0} en total ganaste {1} y promediaste {2}", nombre, suma, promedio);

    }
}



