// boże ratuj mnie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszy_plik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello fatare!");
            Console.WriteLine("Nowa linia");

            Console.Write("Podaj swoje imie: ");
            string name = Console.ReadLine();

            Console.Write("Siema ");
            Console.WriteLine(name);



            //typ int
            int age = 20;
            Console.WriteLine(age);

            //typ uint

            uint number = 10;

            //typ float
            float z = 14.55F;

            //konkatenacja +
            Console.WriteLine("Zmienna z wynosi: " + z);


            
            Console.WriteLine("Program obliczajce pole prostokata: ");
            Console.WriteLine("Podaj bok a: ");
            float c = 0;
            float a= float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Wynik wynosi: " + a*b);

            int x, y = 10, o;

            // int zmienna = 10;
            int zmienna = new int();













            Console.ReadKey();
        }
    }
}
