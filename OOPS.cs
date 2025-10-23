// See https://aka.ms/new-console-template for more information
using System;

namespace PassByValue_PassByReference_PassByOut
{
    class ValueExample
    {
        // Pass By Value
        public void PassByValue(int a)
        {
            a += 10;
            Console.WriteLine("Pass By Value (inside method): {0}", a);
        }

        // Pass By Reference
        public void PassByReference(ref int a)
        {
            a += 7;
            Console.WriteLine("Pass By Reference (inside method): {0}", a);
        }

        // Pass By Out
        public void PassByOut(out int a)
        {
            a = 7; // Must assign a value before using it
            Console.WriteLine("Pass By Out (inside method): {0}", a);
        }

        static void Main(string[] args)
        {
            ValueExample example = new ValueExample();

            // ---- Pass by Value ----
            int value = 15;
            example.PassByValue(value);
            Console.WriteLine("Pass By Value (outside method): {0}", value);
            Console.WriteLine();

            // ---- Pass by Reference ----
            int refValue = 50;
            example.PassByReference(ref refValue);
            Console.WriteLine("Pass By Reference (outside method): {0}", refValue);
            Console.WriteLine();

            // ---- Pass by Out ----
            int outValue; // no need to assign before
            example.PassByOut(out outValue);
            Console.WriteLine("Pass By Out (outside method): {0}", outValue);
        }
    }
}
