using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class OrderHistoryMenu : IMenu
    {
        private OrderHistoryBL _orderHistoryBL;
        public OrderHistoryMenu(OrderHistoryBL p_orderHistoryBL)
        {
            _orderHistoryBL = p_orderHistoryBL;
        }
        public void Menu()
        {
            List<Order> listOfOrder = _orderHistoryBL.OrderHistory();
            Console.WriteLine("|||||||||| Full Order History ||||||||||");
            foreach (Order item in listOfOrder)
            {
                Console.WriteLine("Order ID:");
                Console.WriteLine("===============");
                Console.WriteLine(item.OrdersId);
                Console.WriteLine("===============");
                Console.WriteLine("");
                Console.WriteLine("Customer ID:");
                Console.WriteLine("===============");
                Console.WriteLine(item.CustomerId);
                Console.WriteLine("===============");
                Console.WriteLine("");
                Console.WriteLine("Store Front ID:");
                Console.WriteLine("===============");
                Console.WriteLine(item.StoreFrontId);
                Console.WriteLine(item.Address);
                Console.WriteLine("===============");
                Console.WriteLine("");
                Console.WriteLine("Total Price:");
                Console.WriteLine("===============");
                Console.WriteLine(item.TotalPrice);
                Console.WriteLine("===============");
                Console.WriteLine("---------------");
                Console.WriteLine("===============");
            }
            Console.WriteLine("Welcome To The OrderHistoryMenu");
            Console.WriteLine("Please Enter A StoreFrontId To View Order History"); //Still need to work on history using customer/storefonrt IDs
            Console.WriteLine("[1] - McBurnie Rd Location");
            Console.WriteLine("[2] - Monte Vista Ave Location"); 
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.OrderHistoryMenu; //change these when the time comes
                case "2":
                    return MenuType.OrderHistoryMenu;
                default:
                    Console.WriteLine("Please Input A Valid Reponse");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.OrderHistoryMenu;
            }
        }
    }
}