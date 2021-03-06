using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public void HeadTailPercentage()
        {
            double percentageOfHead, percentageOfTail;
            int headCount = 0, tailCount = 0;

            Console.WriteLine("Enter the number of times coin should be tossed: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i != N)
            {
                Random random = new Random();
                double tossCheck = random.NextDouble();
                if (tossCheck < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
                i++;
            }

            Console.WriteLine("Total number of Tail occour: " + tailCount);
            Console.WriteLine("Total number of Head occour: " + headCount);

            percentageOfHead = (double)headCount / N * 100;
            percentageOfTail = (double)tailCount / N * 100;

            Console.WriteLine("Percentage of Tail : " + percentageOfTail);
            Console.WriteLine("Percentage of Head : " + percentageOfHead);
        }
    }
}
