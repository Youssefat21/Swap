using System;

namespace Swap_Two_Numbers
{
    class Program
    {
        public static string SwapTwoNumbers(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            int temp;

            temp = b;         // put b value in temp 
            b = a;               // put a value in b
            a = temp;         // put temp value in a 

            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }

        public static void Main()
        {
            Console.WriteLine(SwapTwoNumbers(23, 15));      // Before: a = 23, b = 15; After: a = 15, b = 23
            Console.WriteLine(SwapTwoNumbers(-123, 999));   // Before: a = -123, b = 999; After: a = 999, b = -123
            Console.WriteLine(SwapTwoNumbers(0, 333));      // Before: a = 0, b = 333; After: a = 333, b = 0
        }
    }
}
