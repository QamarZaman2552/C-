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
        public string distance ="";
        public int id;
        // Parameterized Constructor
        // public Student(string name, int age)
        // {
        //     this.name = name;
        //     this.age = age;
        // }

        //overloaded Constructor

        // public Student()
        // {
        //     Console.WriteLine($"deful constructor is invoked");

        // }
        // Parameterized Constructor (2 parameters)

        // public Student(int age, int salary)
        // {
        //     this.age = age;
        //     this.salary = salary;
        // }
        // Parameterized Constructor (3 parameters)

        // public Student(int age, int salary,int id)
        // {
        //     this.age = age;
        //     this.salary = salary;  
        //     this.id =id; 
        // }


        // CopyConstructor Constructor
        public Student(int age, int salary, int id)
        {
            this.age = age;
            this.salary = salary;
            this.id = id;
        }
        public Student(Student S,String distance)
        {
            this.age = S.age;
            this.salary = S.salary;
            this.id = S.id;
            this.distance = distance;
        }
         public void getdata()
        {
            Console.WriteLine("Student salary is :{0}", salary);
            Console.WriteLine("Student age is :{0}", age);
            Console.WriteLine("student id is:{0}", id);
            Console.WriteLine("Student traveled distance: {0}",distance);
            
        }


        static void Main(string[] args)
        {
            // Student std3 = new Student();
            Student std1 = new Student(18, 20002, 1000);
            Student std4 = new Student(std1,"500km");


            // Student std2 = new Student(22, 20002);
             Console.WriteLine("Original Student (std1):");
            std1.getdata();

            Console.WriteLine("Copied Student (std2):");
            std4.getdata();
            Console.ReadLine();
        }
           
    }
}