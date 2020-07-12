using System;
using System.Linq;

namespace CWuniqueIDUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // int[] inArray = new int[5] { 0, 1, 2, 3, 5 };
           // int[] inArray =  { 9, 8 ,8 , 9 };
            int[] inArray = { 9, 8, 8, 9 };
            int[] dist = inArray.Distinct().ToArray();
            Array.Sort(dist);
            int returnID = 0;

            int[] place = new int[dist.Length];
            for (int i=0; i < dist.Length; i++)
            {
                place[i] = i;
            }
        for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine($"dist[i] placeholder {place[i]}");

                switch (dist[i] != place[i])
                {
                    case true:
                        returnID = place[i];
                        Console.WriteLine($"return {returnID}");
                        break;
                   // case 2:
                    //    Console.WriteLine("Case 2");
                    //    break;
                    default:
                        returnID = place[i]++;
                        Console.WriteLine($"Default case {returnID}");
                        break;
                }
                //if (dist[i] != place[i])
                //{
                //    returnID = place[i]++;
                //    Console.WriteLine($"return {returnID}");
                    
                //}
            }
            
        }
       
    }
}
