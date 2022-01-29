using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCorePrograms
{
    class VowelOrConsonant
    {
        public void checkVowelOrNot()
        {
            Console.WriteLine(" Enter a character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + " is a Vowel ");
            }
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch + " is a Consonant ");
            }
            else
            {
                Console.WriteLine(ch + " not an Alphabet");
            }
        }
    }
}
