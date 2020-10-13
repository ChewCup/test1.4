using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace test1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c,f;

            Console.Write("Mata in grader i Celsius: ");
            c = double.Parse(Console.ReadLine());
            f = (c / 5) * 9 + 32;
            Console.Write("Det blir " + f + " grader Farenheit.");
            Console.WriteLine();
            Console.Write("Tryck ned valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();

            //the distance between two points

            double x1, y1, x2, y2, d, d2;
            Console.Write("Beräkna avståndet mellan två punkter.");
            Console.WriteLine();
            Console.Write("Ange x-koordinaten för p1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Ange y-koordinaten för p1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Ange x-koordinaten för p2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Ange y-koordinaten för p2: ");
            y2 = double.Parse(Console.ReadLine());
            Console.ReadLine();
            d  = Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2);
            d2 = Math.Sqrt(d);
            Console.Write("Avståndet är " + d2 + ".");

            //stop
            Console.ReadKey();

        }
    }
}
