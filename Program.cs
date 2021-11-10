using System;

namespace PolitBank
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to PolitBank!");
            Console.WriteLine("");
            loginMenu();
        }

        static void loginMenu()
        {
            Console.WriteLine("\n\nSelect Option: ");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Login");

            string userInput = Console.ReadLine();
            int processedInput = -1;

            Validator.validate(userInput, processedInput, loginMenu);

            switch (processedInput)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("ERROR: NO VALID OPTION");
                    break;
            }
        }

        static void createAccount()
        {
            Console.WriteLine("Lets get you set up...");
            Console.WriteLine("\n\nEnter Name: ");
            string username = Console.ReadLine();
            Console.WriteLine("\nEnter Age: ");
            string userAge = Console.ReadLine();
            int processedAge;
            try
            {  
                processedAge = Convert.ToInt32(userAge);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: Input failed!");
                loginMenu();
            }
        }
        static void login()
        {
            Console.WriteLine("");
        }

        static void menu()
        {
            Console.WriteLine("Select Option: ");
            Console.WriteLine("1. Create Account");
        }
    }

}
