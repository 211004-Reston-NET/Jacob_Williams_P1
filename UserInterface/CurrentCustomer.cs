using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class CurrentCustomer : IMenu
    {
        private ICustomerBL _custBL;
        public CurrentCustomer(ICustomerBL p_custBL)
        {
            this._custBL = p_custBL;
        }

        public void Menu()
        {
            List<Customer> listOfCust = _custBL.GetCustomer(ShowCustomer._findCustName);

            Console.WriteLine("This is the search result");
            foreach (Customer cust in listOfCust)
            {
                Console.WriteLine("============");
                Console.WriteLine("");
                Console.WriteLine("============");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowCustomer;
                default:
                    Console.WriteLine("Please input a valud reponse");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.CurrentCustomer;
            }
        }
    }
}