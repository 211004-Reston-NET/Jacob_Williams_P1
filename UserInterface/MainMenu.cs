using System;

namespace UserInterface
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("----- Welcome to Games Galore -----");
            Console.WriteLine("   Where Real Life Is An XP Waste");
            Console.WriteLine("");
            Console.WriteLine("[1] - Login Using Existing Account");
            Console.WriteLine("[2] - Create New Account");
            Console.WriteLine("[3] - Go To StoreFront Menu");
            Console.WriteLine("[4] - Order History Menu");
            Console.WriteLine("[5] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("       Welcome Back!");
                    Console.WriteLine("Please Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.LoginMenu;
                case "2":
                    return MenuType.AddCustomer;
                case "3":
                    return MenuType.StoreFrontMenu;
                case "4":
                    return MenuType.OrderHistoryMenu;
                case "5":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please Select From The Options Provided");
                    Console.WriteLine("Please Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
                    
            }
        }
    }
}