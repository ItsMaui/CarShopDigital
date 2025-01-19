using CarShopDigital.Menus;
using CarShopDigital.Models;
using CarShopDigital.Utils;

namespace CarShopDigital
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Car Shop Digital!");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Login as Admin");
            Console.WriteLine("2. Login as Customer");
            Console.WriteLine("3. Exit");
            Console.WriteLine("==================================");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    AdminLogin();
                    break;
                case "2":
                    await CustomerLogin();
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option!, Please try again.");
                    await Main(args);
                    break;
            }
        }

        public static void AdminLogin()
        {
            Console.Clear();
            Console.Write("Enter admin username: ");
            string adminUsername = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter admin password: ");
            string adminPassword = Console.ReadLine() ?? string.Empty;

            // TODO: Basic Authentication (TODO: Implement proper authentication using AuthService)
            if (adminUsername == "admin" && adminPassword == "admin")
            {
                Console.WriteLine("Welcome Admin!");
                // TODO: move to admin menu
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.ShowMenu();
            }
            else
            {
                Console.WriteLine("Invalid username or password, Please try again.");
                AdminLogin();
            }
        }

        static async Task CustomerLogin()
        {
            Console.Clear();
            Console.Write("Enter customer ID: ");
            int customerID = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Enter customer password: ");
            string customerPassword = Console.ReadLine() ?? string.Empty;

            if (Functions.ValidateId(customerID) && Functions.ValidatePassword(customerPassword))
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data", "users.json");
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found: {filePath}");
                    return;
                }

                List<Customer> customers = await JsonFileHandler.ReadFromJson<List<Customer>>(filePath) ?? new List<Customer>();

                var existingCustomer = customers.FirstOrDefault(c => c.Id == customerID);

                if (existingCustomer == null)
                {
                    Console.WriteLine("New customer detected. Creating account...");
                    Console.Write("Enter your full name: ");
                    string fullName = Console.ReadLine() ?? string.Empty;
                    var newCustomer = new Customer(fullName, customerID, customerPassword);
                    customers.Add(newCustomer);
                    await JsonFileHandler.WriteToJson(filePath, customers);
                    Console.WriteLine("Account created successfully!");
                }

                // CustomerMenu customerMenu = new CustomerMenu(customerID);
                // customerMenu.ShowMenu();

            }
            else
            {
                Console.WriteLine("Invalid ID or password, Please try again.");
                await CustomerLogin();
            }
        }
    }
}