using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_kenarları_girilen_paralel_kenarın_çevresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formül:2a+2b  = a+b+a+b = 2*(a+b)
                        

            Console.WriteLine("Paralel kenarın a kenarını girin");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Paralel kenarın b kenarını girin");
            int b = Int32.Parse(Console.ReadLine());

            int cevre = 2 * (a + b);

            Console.WriteLine("Paralel kenarın çevresi  = " + cevre);
            Console.ReadLine();
        }
    }
}
