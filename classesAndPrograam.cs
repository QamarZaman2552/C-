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
        public int salary;
        public int age; 

        public int id;  
        // Parameterized Constructor
        // public Student(string name, int age)
        // {
        //     this.name = name;
        //     this.age = age;
        // }

        //overloaded Constructor
        public Student()
        {
            Console.WriteLine($"deful constructor is invoked");
            
        }
        public Student(int age, int salary)
        {
            this.age = age;
            this.salary = salary;
        }
        public Student(int age, int salary,int id)
        {
            this.age = age;
            this.salary = salary;  
            this.id =id; 
        }
        public void getdata()
        {
            Console.WriteLine("Student salary is :{0}", salary);
            Console.WriteLine("Student age is :{0}", age);
            Console.WriteLine("student bonus is:{0}",id);
        }

        static void Main(string[] args)
        {
            Student std1 = new Student(18, 20002, 1000);
             // Student std1 = new Student(22, 20002);
             // Student std1 = new Student();
            std1.getdata();
             Console.ReadLine();
        }
           
    }
}