using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter a Number : ");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine(numb + " is Even Number");
            else
                Console.WriteLine(numb + " is Odd Number");
        }
    }
}
