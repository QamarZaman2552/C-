using System;

namespace static_polymorphism_and_dynamic_MethodOverloading_MethodOverriding_MethodHiding
{
    //static_polymorphism_and_dynamic_MethodOverloading_MethodOverriding_MethodHiding

    // method overloading
    public class Animal
    {
        public int age=18;
        public void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
        public void Speak(string name, string fullname)
        {
            Console.WriteLine("Animal says: " + name + " " + fullname);
        }
        public void Speak(string sound, int timeOfSound)
        {
            for (int i = 0; i < timeOfSound; i++)
            {
                Console.WriteLine($"Animal sound like:{sound}");
            }

        }

        public void Speak(string sound)
        {
            Console.WriteLine("Animal says: " + sound);
        }

    }
    //method Hiding

    internal class Parent
    {

        public void showMoney()
        {
            Console.WriteLine($"Details of wil for Childern");

        }
    }
    internal class Child : Parent
    {

        public new void showMoney()
        {
            Console.WriteLine($"if Childern age > : 18 then they will get full amount of money");

        }
    }

    //method overriding

    public class Room
    {
        public virtual void area()
        {
            Console.WriteLine("Area of room is 200 sq ft");

        }
    }
    public class Bedroom : Room
    {
        public override void area()
        {
            Console.WriteLine("Area of bedroom is 150 sq ft");

        }
    }   
    

    class Program
    {

       
        static void Main(string[] args)
        {
            //method overloading
        Animal cat = new Animal();
            cat.Speak();
            cat.Speak("Mano","Bili");
            cat.Speak("Miau", 3);

            //method Hiding

            //calling parent class method
            Parent p = new Child();
            p.showMoney();
            //callling child class method
            Child c = new Child();
            c.showMoney();  

            //method overriding
            Room myRoom = new Room();
            myRoom.area();
            Bedroom myBedRoom = new Bedroom();
            myBedRoom.area();
            Room anotherRoom = new Bedroom();
            anotherRoom.area();
            



            
            
        }
    }
}
