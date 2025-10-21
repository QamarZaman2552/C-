// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Hello, World!");
namespace staticClassesAndConstructors
{
    static class Product
    {
        public static int id;
        public static string name = "";
        public static double price;
        // static constructor
        static Product()
        {
            id = 22;
            name = "laptop";
            price = 25000.00;
        }
        /// static method to display product details
     
        public static void displayProductDetails()
        {
            Console.WriteLine("Product ID is {0}: ",  id);
            Console.WriteLine("Product Name is {0}: ",   name);
            Console.WriteLine("Product Price is{0}: ",  price);
        }

        public static void discount()
        {
            double discount = price / 10;
            double finalPrice=price-discount;
            Console.WriteLine("Discounted Price is:{0} ", +discount);
            Console.WriteLine("total price Of Product :{0}",finalPrice);
        
            
        }



    }

    class Program
    {
        

        static void Main(string[] args)
        {
            Product.displayProductDetails();
            Product.discount();
            Console.ReadLine();
 
        }
    }
}