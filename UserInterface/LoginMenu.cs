using System;
using BusinessLogic;

namespace UserInterface
{
    public class LoginMenu : IMenu
    {
        private CustomerBL _customerBL;
        public LoginMenu(CustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
         {
            Console.WriteLine($"Name-{SingletonCustomer.customer.Name}");
            Console.WriteLine($"Address-{SingletonCustomer.customer.Address}");
            Console.WriteLine("Login");
            Console.WriteLine("[1] - Enter Name");
            Console.WriteLine("[2] - Enter Address");
            Console.WriteLine("[3] - Login");
            Console.WriteLine("[4] - Return To Main Menu");
            Console.WriteLine("[5] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter Name");
                    SingletonCustomer.customer.Name = Console.ReadLine();
                    return MenuType.LoginMenu;
                case "2":
                    Console.WriteLine("Enter Address");
                    SingletonCustomer.customer.Address = Console.ReadLine();
                    return MenuType.LoginMenu;
                case "3":
                    SingletonCustomer.customer = _customerBL.GetCustomer(SingletonCustomer.customer.Name, SingletonCustomer.customer.Address);
                    Console.WriteLine("Customer ID:");
                    Console.WriteLine("------------");
                    Console.WriteLine(SingletonCustomer.customer.CustomerId);
                    Console.WriteLine("------------");
                    Console.WriteLine("Customer Name:");
                    Console.WriteLine("------------");
                    Console.WriteLine(SingletonCustomer.customer.Name);
                    Console.WriteLine("------------");
                    Console.WriteLine("Please Press Enter To Continue To StoreFrontMenu");
                    Console.ReadLine();
                    return MenuType.StoreFrontMenu; 
                case "4":
                    Console.WriteLine("Returning to Main Menu");
                    return MenuType.MainMenu;
                case "5":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please Select From The Options Provided");
                    Console.WriteLine("Please Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.LoginMenu;                
            }
        }
    }
}