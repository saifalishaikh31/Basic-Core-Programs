using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class SwapTwoNumbers
    {
        public void Swap()
        {
            
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;      
            b = a - b;      
            a = a - b;  
            Console.Write("After swap a= " + a + " b= " + b); 
        }
    }
}
