using System;

namespace UserInterface
{
    public class Locations : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("----- Store Locations -----");
            Console.WriteLine("");
            Console.WriteLine("Please Choose The Location Nearest You,");
            Console.WriteLine("Or From One Of The Other Options Below");
            Console.WriteLine("");
            Console.WriteLine("[1] - 156 McBurnie Rd. Presque Isle, ME");
            Console.WriteLine("[2] - 351 E Monte Vista Ave. Turlock, CA");
            Console.WriteLine("[3] - Return To Main Menu");
            Console.WriteLine("[4] - Return to Store Front Menu");
            Console.WriteLine("[5] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    // Console.WriteLine("testing");
                    // Console.ReadLine();
                    return MenuType.Locations;
                case "2":
                    // Console.WriteLine("testing2");
                    // Console.ReadLine();
                    return MenuType.Locations;
                case "3":
                    // Console.WriteLine("testing");
                    // Console.ReadLine();
                    return MenuType.MainMenu;
                case "4":
                    // Console.WriteLine("testing");
                    // Console.ReadLine();
                    return MenuType.StoreFront;
                case "5":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please Select From The List Of Options Provided");
                    Console.WriteLine("Please Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.Locations;
            }
        }
    }
}