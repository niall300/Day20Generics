using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a single generic function named printArray; 
//    this function must take an array of generic elements as a parameter 
//        (the exception to this is C++, which takes a vector). 
//The locked Solution class in your editor tests your function.

//Note: You must use generics to solve this challenge.Do not write overloaded functions.
namespace Generics
{

    
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }



            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
            Console.ReadLine();

        }

        static void PrintArray<T>(T[] arr)
        {
            foreach(var v in arr)
            {
                Console.WriteLine(v);
            }
        }
    }
}
