using System;

namespace ThrowAwayTestsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char c = 'C';
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            bool flag;

            // Check all letters
            foreach (char letter in lowercaseAlphabet)
            {
                if ((c == letter) ||
                     (c == char.ToUpper(letter)))
                {
                    Console.WriteLine($"It is a letter {letter}");
                    flag = true;
                    //return true;
                }
                else
                {
                    flag = false;
                   // Console.WriteLine($"{c} Not the letter {letter}");
                    //return false;
                }
            }

           if (CharacterIsALetter(c) == true)
          {
                Console.WriteLine("It is definitely a character in module");
          }
        }

        public static bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";

            // Check all letters
            foreach (char letter in lowercaseAlphabet)
            {
                if ((c == letter) ||
                     (c == char.ToUpper(letter)))
                {
                    Console.WriteLine($"It is a letter {letter}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{c} Not the letter {letter}");
                    return false;
                }
            }

            return false;



        }
    }
}
