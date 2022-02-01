using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int god;
            


            for (god = 1900; god < 2101; god++)
            {
                if (god % 4 == 0 && god % 100 != 0)
                {
                     Console.WriteLine("godina " + god + " je prijestupna godina. ");
                }
                if (god % 400 == 0)
                Console.WriteLine("godina " + god + " je prijestupna godina. ");
            }

            Console.ReadKey(); 
        
        }


    }
}
