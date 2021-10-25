using System;

namespace UserInterface
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("[1] - Create New Account");
            Console.WriteLine("[2] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.AddCustomer;
                case "2":
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