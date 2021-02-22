using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4AnalisisGuia6
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Identificador de números positivos, negativos, pares y múltiplos de 15";

        int po = 0, ne = 0, pa = 0, mul15 = 0;
        Console.WriteLine("¿Cuántos números va ingresar? ");
        int nuu = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nuu; i++)
        {

        Console.WriteLine("Digite el número: ");
        int nu = int.Parse(Console.ReadLine());

        if (nu >= 0)
        {
         po = po + 1;
        }

        if (nu < 0)
        {
        ne = ne + 1;
        }
        if (nu % 2 == 0)
        {
        pa = pa + 1;
        }
        if (nu % 15 == 0)
        {
        mul15 = mul15 + 1;
        }

        }
        Console.WriteLine("Números positivos: " + po);
        Console.WriteLine("Números negativos: " + ne);
        Console.WriteLine("Números pares: " + pa);
        Console.WriteLine("Números múltiplos de 15: " + mul15);
        

        Console.ReadKey();
        }
    }
}
