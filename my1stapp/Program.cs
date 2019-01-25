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
                 
            while(isvalid)
        {
            Console.WriteLine("Select an item from menu: \n 1. Small\n 2.Medium\n 3.Large");
            int pizza_Type = Convert.ToInt32(Console.ReadLine());     
            Console.WriteLine("Enter  number of Pizzas You want: ");
            int item_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Calculating Bill Please Wait....!");
        
        if(pizza_Type==1){

            bill=GetBill(item_num,45);
            break;

        }else if(pizza_Type==2){  

            bill=GetBill(item_num,50);
            break;

        }else{

            bill=GetBill(item_num,60);
            break;
        } 
                                
        }
        if(isvalid){
            
            if(bill > 100){
                Console.WriteLine("Discount Applied!!!!!");
                double discount = bill - (bill*0.2);
                decimal disc = (decimal)(discount);
                Console.WriteLine("Bill: "+ disc);
            }
            else{
                Console.WriteLine("Bill:" + bill);
            }
            Console.WriteLine("Enter q to Quit");
            var isQuit=Console.ReadLine();
            var temp=Convert.ToChar(isQuit);
            if(temp=='q')
            {
                Environment.Exit(-1);
            }
        }
    }
    public static double GetBill(int quantity,int rate){
        return quantity*rate;
    }
}
}
