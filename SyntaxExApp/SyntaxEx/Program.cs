using System;
using System.ComponentModel;

namespace SyntaxEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = int.Parse(Console.ReadLine());
 
            
            var response = (answer < 9) ? $"{answer,0:c} is less than nine dollars" : $"{answer,0:c} greater than or equal to nine dollars";
           
           Console.WriteLine(response);
        }
    }
}
