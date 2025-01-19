namespace CarShopDigital.Menus
{
    public class CustomerDashboard
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Customer Dashboard:");
            Console.WriteLine("1. View All Cars");
            Console.WriteLine("2. Search for Cars");
            Console.WriteLine("3. Book a Car");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    ViewAllCars();
                    break;
                case "2":
                    SearchCars();
                    break;
                case "3":
                    BookCar();
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

        private static void ViewAllCars()
        {
            Console.WriteLine("Viewing all cars...");
            // Implementation for viewing all cars
        }

        private static void SearchCars()
        {
            Console.WriteLine("Searching for cars...");
            // Implementation for searching cars
        }

        private static void BookCar()
        {
            Console.WriteLine("Booking a car...");
            // Implementation for booking a car
        }

        private static void Exit()
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }

    }
}