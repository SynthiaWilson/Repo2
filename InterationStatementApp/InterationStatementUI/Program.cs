using System;
using System.Collections.Generic;

namespace InterationStatementUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Example
          int[] numbers = { 1, 2, 3, 4, 5, 6 };
           // for (int j = 0; j<5;j++)
           

           // {
           //     numbers[j] += 1;
           //     Console.WriteLine($"{numbers[j]} is the {j} index in the array");
             
          foreach(int number in numbers)
            {
                Console.WriteLine($"{number}");
            
            }

            //List Example 
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Remove(5);
        }
    }
}
