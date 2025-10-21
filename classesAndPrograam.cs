// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Hello, World!");
namespace classesAndPrograam
{
    // Constructor in class
    class Student
    {
        // Defult Constructor
        // public Student()
        // {

        //     System.Console.WriteLine("DefultConstructor is called");
        // }
        public string name;
        public int age; 
        // Parameterized Constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void getdata()
        {
            Console.WriteLine("Student name is :{0}", name);
            Console.WriteLine("Student age is :{0}",age);
        }

        static void Main(string[] args)
        {
            Student std1 = new Student("Qamar", 22);
            std1.getdata();
             Console.ReadLine();
        }
           
    }
}