using System;

namespace Var_And_Dynamic_Keyword_In_CSharp
{
    //single inheritance,herarchy inheritance,multilevel inheritance
    class baseClass
    {
        public dynamic age;
        public dynamic name;

        public dynamic id;
        public void Display()
        {
            Console.WriteLine("Display method from baseClass");
        }
    }
    class derivedClass : baseClass
    {
        public void Show()
        {
            Console.WriteLine("Show method from derivedClass");
        }
    }
    class derivedClass2 : derivedClass
    {
        public void Print()
        {
            Console.WriteLine("Print method from derivedClass2");
        }
    }

    class derivedClass3 : derivedClass2
    {
        public void Hello()
        {
            Console.WriteLine("Hello method from derivedClass3");
        }
    }

    class derivedClass4 : derivedClass3
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome method from derivedClass4");
        }
    }
    

    class Program
    {
        
        static void Main(string[] args)
        {
            derivedClass4 obj = new derivedClass4();
            obj.age = 22;
            obj.name = "Qamar";
            obj.id = 101;

            Console.WriteLine("Name: " + obj.name);
            Console.WriteLine("Age: " + obj.age);
            Console.WriteLine("ID: " + obj.id);

            obj.Display();
            obj.Show();
            obj.Print();
            obj.Hello();
            obj.Welcome();
           
        }
    }
}
