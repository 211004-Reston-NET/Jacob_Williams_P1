using System;
using BusinessLogic;
using DataLogic;

namespace UserInterface
{
    public class OrderMenu : IMenu
    {
        private OrderBL _orderBL;
        public OrderMenu(OrderBL p_orderBL)
        {
            _orderBL = p_orderBL;
        }
        public void Menu()
        {
            Console.WriteLine($"OrdersId -{SingletonCustomer.order.OrdersId}");
            Console.WriteLine($"TotalPrice -{SingletonCustomer.order.TotalPrice}");
            Console.WriteLine($"StoreFrontId -{SingletonCustomer.order.StoreFrontId}");
            Console.WriteLine($"CustomerId -{SingletonCustomer.order.CustomerId}");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("OrderID");
                    SingletonCustomer.order.OrdersId = Convert.ToInt32(Console.ReadLine());
                    return MenuType.OrderMenu;
                case "2":
                    Console.WriteLine("TotalPrice");
                    SingletonCustomer.order.TotalPrice = Convert.ToInt32(Console.ReadLine());
                    return MenuType.OrderMenu;
                case "3":
                    Console.WriteLine("StoreFrontId");
                    SingletonCustomer.order.StoreFrontId = Convert.ToInt32(Console.ReadLine());
                    return MenuType.OrderMenu;
                case "4":
                    Console.WriteLine("CustomerId");
                    SingletonCustomer.order.CustomerId = Convert.ToInt32(Console.ReadLine());
                    return MenuType.OrderMenu;
                default:
                    Console.WriteLine("Please Select From The Options Provided");
                    Console.WriteLine("Please Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.OrderMenu;

            }
        }
    }
}