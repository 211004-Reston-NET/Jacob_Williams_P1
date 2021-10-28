using System;

namespace UserInterface
{
    public class StoreFrontMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("    Welcome To The StoreFront Menu");
            Console.WriteLine("Please Choose The Store Closest To You");
            Console.WriteLine("[1] - 156 McBurnie Rd. Presque Isle, ME");
            Console.WriteLine("[2] - 351 E Monte Vist Ave. Turlock, CA");
            Console.WriteLine("[3] - Return To The MainMenu");
            Console.WriteLine("[4] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.MaineLocationMenu;
                case "2":
                    return MenuType.CaliforniaLocationMenu;
                case "3":
                    return MenuType.MainMenu;
                case "4":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please Input A Valid Reponse");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.StoreFrontMenu;

            }
        }
    }
}