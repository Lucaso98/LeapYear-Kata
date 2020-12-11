using LeapYear.Library;
using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2000; i < 2101; i++)
            {
                Console.WriteLine(LeapYearer.getValue(i));
            }
            Console.ReadLine();
        }
    }
}
