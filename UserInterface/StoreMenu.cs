using System;

namespace UserInterface
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome To The Customer Menu");
            Console.WriteLine("Please Enter A command");
            Console.WriteLine("[3] - List Of Stores");
            Console.WriteLine("[2] - Choose A Store");
            Console.WriteLine("[1] - Buy A Product");
            Console.WriteLine("[0] - Go To MainMenu");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "3":
                    return MenuType.ShowCustomer;
                case "2":
                    return MenuType.AddCustomer;
                case "1":
                    return MenuType.CurrentCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please Input A Valid Reponse");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.CustomerMenu;
            }
        }
    }
}