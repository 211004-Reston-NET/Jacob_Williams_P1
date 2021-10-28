using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    //This should link up with the name of a customer we want to find?
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
            //I'll want to change this whole page to stores rather than customers
            Console.WriteLine("List of Customers");
            List<Customer> listOfCustomers = _custBL.GetAllCustomer();
            foreach (Customer cust in listOfCustomers)
            {
            Console.WriteLine("============");
            Console.WriteLine("cust");
            Console.WriteLine("============");
            }
            Console.WriteLine("[1] - Search For A Customer by Name");
            Console.WriteLine("[2] - Select A Customer Based on Id");
            Console.WriteLine("[0] - Return to Main Menu");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Customer you want to find");
                    _findCustName = Console.ReadLine();
                    return MenuType.CurrentCustomer;
                case "2":
                    Console.WriteLine("Enter the ID of the restaurant you want to find");
                    return MenuType.ShowCustomer; //// <-- this needs jesus
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;
            }

        }
    }
}