using System;

namespace my1stapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PizzaDen!!!");
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender M/F/O: ");
            String gender = Console.ReadLine();

            double bill=0;

            gender=gender.ToLower();

            switch (gender)
            {
                case "m":
                    Console.WriteLine($"Hi Mr. {name}");
                    break;
                case "f":
                    Console.WriteLine($"Hi Ms.{name}");
                    break;
                case "o":
                    Console.WriteLine($"Hi {name}");
                    break;
                default:
                    Console.WriteLine("Enter Correct gender");
                    break;
            }
            bool isvalid = true;            
            isvalid = (gender == "m" || gender == "f" || gender == "o");
