using System;

namespace Var_And_Dynamic_Keyword_In_CSharp
{
    class ValueExample
    {
        // Correct: class-level fields must have explicit types
        public int num = 10;
        public dynamic data; // 'dynamic' is allowed at class level

        static void Main(string[] args)
        {
            // Using var inside a method
            var a = 5;               // int
            var b = "Hello";         // string
            var c = 5.5;             // double
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            // Using dynamic inside a method
            dynamic x = 10;
            Console.WriteLine($"x = {x}, Type = {x.GetType()}");

            x = "Now I’m a string!";
            Console.WriteLine($"x = {x}, Type = {x.GetType()}");

            ValueExample obj = new ValueExample();
            obj.data = true;
            Console.WriteLine($"obj.data = {obj.data}, Type = {obj.data.GetType()}");
        }
    }
}
