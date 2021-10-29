using System;

namespace UserInterface
{
    public class CaliforniaLocationMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome To Our California Location");
            Console.WriteLine("How Would You Like To Proceed?");
            Console.WriteLine("[1] - View Our Products");
            Console.WriteLine("[2] - Return To Main Menu");
            Console.WriteLine("[3] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.ProductMenu;
                case "2":
                    return MenuType.MainMenu;
                case "3":
                    return MenuType.Exit;
                default:
                    return MenuType.MainMenu;
            }
        }
    }
}