using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class StoreFrontMenu : IMenu
    {
        private StoreFrontBL _storeFrontBL;
        public StoreFrontMenu(StoreFrontBL p_storeFrontBL)
        {
            _storeFrontBL = p_storeFrontBL;
        }

        public void Menu()
        {
            List<StoreFront> listOfStoreFronts = _storeFrontBL.GetStoreFrontList();
            Console.WriteLine("    Welcome To The StoreFront Menu");
            foreach (StoreFront store in listOfStoreFronts)
            {
                Console.WriteLine(store);
                Console.WriteLine("----------------");
            }
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
                    SingletonCustomer.order.StoreFrontId = 1;
                    SingletonCustomer.order.Address = "156 McBurnie Rd";
                    return MenuType.MaineLocationMenu;
                case "2":
                    SingletonCustomer.order.StoreFrontId = 2;
                    SingletonCustomer.order.Address = "351 Monte Vista Ave";
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