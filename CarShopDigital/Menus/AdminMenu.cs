using System;
using CarShopDigital;

namespace CarShopDigital.Menus
{
    public class AdminMenu
    {

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Admin Menu");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Remove Car");
            Console.WriteLine("3. View All Cars");
            Console.WriteLine("4. Exit");
            Console.WriteLine("==================================");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine() ?? string.Empty;
            switch (choice)
            {
                case "1":
                    AddCar();
                    break;
                case "2":
                    RemoveCar();
                    break;
                case "3":
                    ViewAllCars();
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowMenu();
                    break;
            }
        }

        private void AddCar()
        {
            Console.WriteLine("Adding a new car...");
            // Implementation for adding a car
        }

        private void RemoveCar()
        {
            Console.WriteLine("Removing a car...");
            // Implementation for removing a car
        }

        private void ViewAllCars()
        {
            Console.WriteLine("Viewing all cars...");
            // Implementation for viewing all cars
        }

        private void Exit()
        {
            Console.WriteLine("Exiting...");
            // Implementation for exiting the menu
        }
    }
}