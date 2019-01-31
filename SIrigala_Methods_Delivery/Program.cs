using System;

namespace SIrigala_Methods_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();

            try
            {
                User_Name(input);
            }//end of try

            catch
            {
                Console.WriteLine("Please enter your name!");
                Console.WriteLine("Press any key to exit and try again.");
                Console.ReadKey(true);
            }//end of catch
            
        }//end of main

        private static void User_Name(string user_input)
        {
            string UserName = user_input;
            Console.WriteLine("Hello " + UserName + ".");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);

        }//end of method
    }
}
