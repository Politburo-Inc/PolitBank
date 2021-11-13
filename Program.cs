using System;

namespace PolitBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PolitBank!");
            Console.WriteLine("");
            DirectoryManager.createDirectories();
            loginMenu();
        }

        static void loginMenu()
        {
            bool menuExit = false;
            while (!menuExit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nSelect Option: ");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Login");

                Console.Write("> ");
                string userInput = Console.ReadLine();
                int processedInput = -1;

                processedInput = Validator.validate(userInput, processedInput, loginMenu);
                
                switch (processedInput)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        menuExit = false;
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Entering Account Menu...");
                        createAccount();
                        break;
                    case 2:
                        Console.WriteLine("Entering Login Menu...");
                        //menuExit = true;
                        login();
                        break;
                    default:
                        Console.WriteLine("ERROR: NO VALID OPTION");
                        break;
                }
            }
        }

        static void createAccount()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lets get you set up...");
            Console.WriteLine("\n\nEnter Name: ");
            Console.Write("> ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            Console.Write("> ");
            string password = Console.ReadLine();
            Console.WriteLine("Basic account setup!\n");

            Console.WriteLine("Indexing further...");

            Console.WriteLine("\nEnter Age: ");
            string userAge = Console.ReadLine();
            int processedAge = 0;
            Validator.validate(userAge, processedAge, createAccount);
            Console.WriteLine("Enter Date Of Birth");
            string userDateOfBirth = Console.ReadLine();
            try
            {
                DateTime processedDate = Convert.ToDateTime(userDateOfBirth);

                Console.WriteLine("Creating new user...");
                User user = new User(username, password, processedAge, processedDate);
                Console.WriteLine("Indexing new user...");
                Bank.users.Add(user);
            }
            catch (Exception)
            {

                Console.WriteLine("Date not in correct format!");
            }
        }
        static void login()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lets get you logged in...");
            Console.WriteLine("\n\nEnter your username: ");
            Console.Write("> ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            Console.Write("> ");
            string password = Console.ReadLine();
            Console.WriteLine("Indexing user repository..........");
            if (Bank.users.Count == 0)
            {
                Console.WriteLine("ERROR: No users in system!");
            }
            foreach (User user in Bank.users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine("Data validated!\n\n");
                    menu();
                }
                else
                {
                    Console.WriteLine("ERROR: Could not validate data! Invalid Login!");
                }
            }
        }

        static void menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Select Option: ");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Create Bank Acccount");
            Console.WriteLine("2. Delete Bank Account");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Deposit Money");

            Console.Write("> ");
            string userInput = Console.ReadLine();
            int proccessedInput = -1;

            proccessedInput = Validator.validate(userInput, proccessedInput, menu);

            bool menuExit = false;

            while (!menuExit)
            {
                switch (proccessedInput)
                {
                    case 0:
                        Console.WriteLine("Exiting bank options...");
                        menuExit = true;
                        break;
                    case 1:
                        Console.WriteLine("Entering Bank Account creation...");
                        Bank.createAccount();
                        break;
                    case 2:
                        Console.WriteLine("Entering Bank Account deletion...");
                        Bank.deleteAccount();
                        break;
                    case 3:
                        Console.WriteLine("Entering Withdraw Money menu...");
                        Bank.withdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Entering Wtihdraw Money menu...");
                        Bank.depositMoney();
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
