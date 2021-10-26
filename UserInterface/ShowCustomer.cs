using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class ShowCustomer : IMenu
    {
        private ICustomerBL _custBL;
        public static string _findCustName;

        public ShowCustomer(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }
        public void Menu()
        {
            Console.WriteLine("============");
            Console.WriteLine("");
            Console.WriteLine("============");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.CustomerMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Customer you want to find");
                    _findCustName = Console.ReadLine();
                    return MenuType.CurrentCustomer;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;
            }

        }
    }
}