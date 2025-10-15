// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Hello, World!");
namespace classesAndPrograam
{
    class Student
    {
         string Name;
        string RollNo;
         int Age;
         string Standard;

        public void setStudentData(string name, string rollno, int age, string standard)
        {
            this.Name = name;
           this.RollNo = rollno;
            this.Age = age;
            this.Standard = standard;
        }

        public void getStudentData()
        {
            Console.WriteLine("Student name is: " + Name);
            Console.WriteLine("Student rollno is: " + RollNo);
            Console.WriteLine("Student age is: " + Age);
            Console.WriteLine("Student standard is: " + Standard);
        }

        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.setStudentData("John", "101", 15, "10th");
            std1.getStudentData();
            Console.ReadLine();
            
 
        }
    }
}