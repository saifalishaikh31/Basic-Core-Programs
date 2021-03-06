using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.FlipCoin."
                               + "\n 2.LeapYear."
                               + "\n 3.ReplaceString"
                               + "\n 4.Power Of Two"
                               + "\n 5.Harmonic Number"
                               + "\n 6.Factors"
                               + "\n 7.Quotient Remainder"
                               + "\n 8.Swap Two Numbers"
                               + "\n 9. Even or Odd"
                               + "\n 10. Vowel Or Consonant"
                               + "\n 11.Find Largest Among Three Numbers"
                               + "\n 12.Exit \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipcoin = new FlipCoin();
                        flipcoin.HeadTailPercentage();
                        break;
                    case 2:
                        LeapYear leapyear = new LeapYear();
                        leapyear.CheckLeapYear();
                        break;
                    case 3:
                        ReplaceString replacestr = new ReplaceString();
                        replacestr.ReplaceStr();
                        break;
                    case 4:
                        PowerOfTwo poweroftwo = new PowerOfTwo();
                        poweroftwo.PwrOfTwo();
                        break;
                    case 5:
                        HarmonicNumber hrmnum = new HarmonicNumber();
                        hrmnum.FindHarmonicNumber();
                        break;
                    case 6:
                        Factors factors = new Factors();
                        factors.FindFactors();
                        break;
                    case 7:
                        QuotientRemainder qm = new QuotientRemainder();
                        qm.CalQuoRem();
                        break;
                    case 8:
                        SwapTwoNumbers swap = new SwapTwoNumbers();
                        swap.Swap();
                        break;
                    case 9 :
                        EvenOdd evenodd = new EvenOdd();
                        evenodd.CheckEvenOrOdd();
                        break;
                    case 10:
                        VowelOrConsonant vowelconsonant = new VowelOrConsonant();
                        vowelconsonant.checkVowelOrNot();
                        break;
                    case 11:
                        LargestAmongThreeNumbers largestnumber = new LargestAmongThreeNumbers();
                        largestnumber.CheckLargestNumber();
                        break;
                    case 12: flag = false;
                        break;
                    default: Console.WriteLine("Choose Correct option");
                        break;
                }



            } 
        }
    }
}
