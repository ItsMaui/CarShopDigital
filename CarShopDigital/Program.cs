using System;

namespace CarShopDigital
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Car Shop Digital!");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Login as Admin");
            Console.WriteLine("2. Login as Customer");
            Console.WriteLine("3. Exit");
            Console.WriteLine("==================================");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AdminLogin();
                    break;
                case "2":
                    CustomerLogin();
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option!, Please try again.");
                    Main(args);
                    break;
            }
        }

        static void AdminLogin()
        {
            Console.Clear();
            Console.Write("Enter admin username: ");
            string adminUsername = Console.ReadLine();

            Console.Write("Enter admin password: ");
            string adminPassword = Console.ReadLine();

            // TODO: Basic Authentication (TODO: Implement proper authentication using AuthService)
            if (adminUsername == "admin" && adminPassword == "admin")
            {
                Console.WriteLine("Welcome Admin!");
                // TODO: move to admin menu
            }
            else
            {
                Console.WriteLine("Invalid username or password, Please try again.");
                AdminLogin();
            }
        }

        static void CustomerLogin()
        {
            Console.Clear();
            Console.Write("Enter customer ID: ");
            string customerID = Console.ReadLine();

            Console.Write("Enter customer password: ");
            string customerPassword = Console.ReadLine();

            // TODO: Basic Authentication (TODO: Implement proper authentication using AuthService)
            if (!string.IsNullOrEmpty(customerID) && !string.IsNullOrEmpty(customerPassword))
            {
                Console.WriteLine($"Welcome Customer {customerID}!");
                // TODO: move to customer menu
            }
            else
            {
                Console.WriteLine("Invalid ID or password, Please try again.");
                CustomerLogin();
            }
        }
    }
}