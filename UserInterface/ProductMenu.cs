using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class ProductMenu : IMenu
    {
        private ProductBL _productBL;
        public ProductMenu(ProductBL p_productBL)
        {
            _productBL = p_productBL;
        }
        public void Menu()
        {
            List<Product> listOfProduct = _productBL.GetAllProduct();
            Console.WriteLine("    Welcome To The StoreFront Menu");
            foreach (Product item in listOfProduct)
            {
                Console.WriteLine(item);
                Console.WriteLine("----------------");
            }
            Console.WriteLine(" Welcome To The Product Menu");
            Console.WriteLine(" ===========================");
            Console.WriteLine(" ===========================");
            Console.WriteLine("Please Select Option To Proceed");
            Console.WriteLine("[1] - Place An Order");
            Console.WriteLine("[2] - Return To Main Menu");
            Console.WriteLine("[3] - Exit");
            
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.ProductMenu;
                case "2":
                    return MenuType.MainMenu;
                case "3":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please Input A Valid Reponse");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.ProductMenu;

            }
        }
    }
}