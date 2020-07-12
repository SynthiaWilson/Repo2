using System;
using System.Collections.Generic;

namespace IterationsEx3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // CodeWars Challenge
            //int[] arr = new int[] { 1, 3, -5, 7, 9 };
            ////new int[] { 1, 2, -3, 4, 5 };
            //int sum = 0;
            //for (int index = 0; index < arr.Length; index++)
            //{
            //    Console.WriteLine($"Index is {index} and array is ");
            //    if (arr[index] > 0)
            //    {
            //        sum += arr[index];
            //    }
            //}


            // Codewars Reduce numbers
            //long n = 493193;
            //int sqroot = 0;

            //String numS = "";
            //String sqrootS = "";
            //int nLength = 0;
            //int sqrootLength = 0;
            //numS = n.ToString();

            //int sqrootReturn = 0;

            //var sqrootReturn = MyAdd(n);
            //Console.WriteLine($"sqrootReturn is { sqrootReturn}");


            //string sqrootS = sqrootReturn.ToString();

            // if (sqrootS.Length > 1)

            // {
            //    // Console.WriteLine($" another round {sqrootS}");
            //     sqrootReturn = MyAdd(sqrootReturn);
            //}

            //      sqrootReturn = MyAdd(n);
            //Console.WriteLine($"sqrootReturn is { sqrootReturn}");


            //      sqrootS = sqrootReturn.ToString();

            //     if (sqrootS.Length > 1)

            //     {
            // Console.WriteLine($" another round {sqrootS}");
            //        sqrootReturn = MyAdd(sqrootReturn);
            //    }

            //static long MyAdd(long rootN)
            //{
            //    int sqroot = 0;
            //    String numS = "";

            //    numS = rootN.ToString();

            //    if (numS.Length > 1)
            //    {
            //        for (int i = 0; i < numS.Length; i++)
            //        {
            //            var numParse = int.Parse(numS.Substring(i, 1));
            //            Console.WriteLine($" The length of {rootN} parse {numParse} total {numS.Length}");
            //            sqroot += numParse;
            //        }


            //        // Console.WriteLine($"This is sqroot {sqroot}");

            //    }
            //    return sqroot;
            //}



            //long MyAdd(long rootN)
            //    {
            //    int sqroot = 0;
            //    String numS = "";

            //    numS = rootN.ToString();

            //    if (numS.Length > 1)
            //    {
            //        for (int i = 0; i < numS.Length; i++)
            //        {
            //            var numParse = int.Parse(numS.Substring(i, 1));
            //            Console.WriteLine($" The length of {rootN} parse {numParse} total {sqroot}");
            //            sqroot += numParse;
            //        }


            //           // Console.WriteLine($"This is sqroot {sqroot}");

            //    }
            //            return sqroot;
            //    }
            ///////////////
            ///

            //var sqrootReturn = MyAdd(n);
            ////Console.WriteLine($"sqrootReturn is { sqrootReturn}");


            //string sqrootS = sqrootReturn.ToString();

            //while  (sqrootS.Length > 1)

            //{
            //    // Console.WriteLine($" another round {sqrootS}");
            //    sqrootReturn = MyAdd(sqrootReturn);
            //}

            //long MyAdd(long rootN)
            //{
            //    int sqroot = 0;
            //    String numS = "";

            //    numS = rootN.ToString();

            //    if (numS.Length > 1)
            //    {
            //        for (int i = 0; i < numS.Length; i++)
            //        {
            //            var numParse = int.Parse(numS.Substring(i, 1));
            //            // Console.WriteLine($" The length of {rootN} parse {numParse} total {numS.Length}");
            //            sqroot += numParse;
            //        }


            //         Console.WriteLine($"This is sqroot {sqroot}");

            //    }
            //    return sqroot;
            //}

            List<int> li = new List<int>();

            //list<int> li = new list<int>();

            int num = 59172;
            string numS = num.ToString();
            for (int i = 0; i < numS.Length; i++)
            {
                li.Add(int.Parse(numS.Substring(i, 1)));
               /// li.Add(int.Parse(numS.Substring(1, 1)));
               /// li.Add(int.Parse(numS.Substring(2, 1)));
            }
           

            li.Sort();
            var liAdd = "";

            foreach (int item in li)
            {
                liAdd += item.ToString();
                Console.WriteLine(item.ToString() + "\n");
            }
            Console.WriteLine($"String {liAdd}");

            Console.ReadKey();
        }
    }
}
