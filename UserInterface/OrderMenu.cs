using System;
using System.Collections.Generic;
using BusinessLogic;
using DataLogic;
using Models;

namespace UserInterface
{
    public class OrderMenu : IMenu
    {
        private OrderBL _orderBL;
        private LineItemsBL _lineItems;
        public OrderMenu(OrderBL p_orderBL, LineItemsBL p_lineItemsBL)
        {
            _orderBL = p_orderBL;
            _lineItems = p_lineItemsBL;
        }
        public void Menu()
        {
            Console.WriteLine($"OrdersId -{SingletonCustomer.order.OrdersId}");
            Console.WriteLine($"TotalPrice -{SingletonCustomer.order.TotalPrice}");
            Console.WriteLine($"StoreFrontId -{SingletonCustomer.order.StoreFrontId}");
            Console.WriteLine($"CustomerId -{SingletonCustomer.order.CustomerId}");
            Console.WriteLine("================================");
            Console.WriteLine("Please Type The Name Of The Product You Want");
            Console.WriteLine("================================");
        }

        public MenuType UserChoice()
        {
            List <LineItems> listOfLineItems = _lineItems.GetAllLineItem(SingletonCustomer.order.StoreFrontId);
            foreach(LineItems prod in listOfLineItems)
                {
                    Console.WriteLine("Product ID:");
                    Console.WriteLine("===============");
                    Console.WriteLine(prod.Product.ProductId);
                    Console.WriteLine("===============");
                    Console.WriteLine("");
                    Console.WriteLine("Product Name:");
                    Console.WriteLine("===============");
                    Console.WriteLine(prod.Product.ProductName.ToLower().Trim());
                    Console.WriteLine("===============");
                    Console.WriteLine("");
                    Console.WriteLine("Product Description:");
                    Console.WriteLine("===============");
                    Console.WriteLine(prod.Product.ProductDescription.ToLower().Trim());
                    Console.WriteLine("===============");
                    Console.WriteLine("");
                    Console.WriteLine("Product Price:");
                    Console.WriteLine("===============");
                    Console.WriteLine(prod.Product.ProductPrice);
                    Console.WriteLine("===============");
                    Console.WriteLine("---------------");
                    Console.WriteLine("===============");
                    Console.WriteLine("");           
                }
                Console.WriteLine("Please Select From Our Options Below");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("[1] - Shop Our Inventory");
                    Console.WriteLine("[2] - Return To MainMenu");         
            string userChoice = Console.ReadLine();
            {

                switch (userChoice) 
                {
                case "1":
                    Console.WriteLine("Please Type The Product Name You Would Like To Purchase");
                    string _inputName = Console.ReadLine().ToLower().Trim();
                    
                    foreach(LineItems prod in listOfLineItems)
                    {
                        if (_inputName == prod.Product.ProductName.ToLower().Trim())
                        {
                            Console.WriteLine($"How Many {_inputName} Would You Like To Buy?");
                            int _inputQuantity = int.Parse(Console.ReadLine());
                            if (_inputQuantity > prod.LineItemQuantity)
                            {
                                Console.WriteLine("Please Enter Appropriate Amount");
                            }
                            else
                            {
                                prod.LineItemQuantity -= _inputQuantity;
                                //SingletonCustomer.order.TotalPrice += (_inputQuantity * prod.Product.ProductPrice);
                                SingletonCustomer.order.LineItems.Add(prod);
                                Console.WriteLine("");
                                Console.WriteLine($"{_inputQuantity} {_inputName} have been added to your order");
                                Console.WriteLine("=========================");
                                Console.WriteLine($"Total Price Is Now: {SingletonCustomer.order.TotalPrice}");
                                Console.WriteLine("=========================");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Would You Like To Check out?");
                    Console.WriteLine("==============================");
                    Console.WriteLine("[1] - Checkout");
                    Console.WriteLine("[2] - Keep Shopping");
                    Console.WriteLine("==============================");

                    // SingletonCustomer.order.OrdersId = Convert.ToInt32(Console.ReadLine());
                    // SingletonCustomer.order.CustomerId = Convert.ToInt32(Console.ReadLine());
                    // SingletonCustomer.order.StoreFrontId = Convert.ToInt32(Console.ReadLine());
                    // SingletonCustomer.order.TotalPrice = Convert.ToInt32(Console.ReadLine());
                    
                    userChoice = Console.ReadLine();
                    switch (userChoice)
                    {
                        case "1":
                            SingletonCustomer.order.CustomerId = SingletonCustomer.customer.CustomerId;
                            _orderBL.PlaceOrder(SingletonCustomer.customer, SingletonCustomer.order);
                            return MenuType.CheckOutMenu; //change this to checkout menu
                        case "2":
                            return MenuType.OrderMenu;
                    }
                    return MenuType.OrderMenu; //change this to the checkout Menu
                case "2":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please Select From The Options Provided");
                    Console.WriteLine("Please Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.OrderMenu;
                }
            }
        }
    }
}