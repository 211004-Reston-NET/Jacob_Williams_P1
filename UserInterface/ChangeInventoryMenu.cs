using System;
using System.Collections.Generic;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class ChangeInventoryMenu : IMenu
    {
        private ILineItemsBL _itemBL;
        private IChangeInvBL _invBL;
        private LineItemsBL _lineItems;

        public ChangeInventoryMenu(ILineItemsBL p_itemBL, IChangeInvBL p_invBL)
        {
            this._itemBL = p_itemBL;
            this._invBL = p_invBL;
        }

        
        public void Menu()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 1");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 2");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 3");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 4");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 5");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 6");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 7");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 8");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 9");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 10");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 11");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 12");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 13");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 14");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 15");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 16");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 17");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 18");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 19");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 20");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 21");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 22");
            Console.WriteLine("=========================");
            
            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 23");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 24");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 25");
            Console.WriteLine("=========================");

            Console.WriteLine("=========================");
            Console.WriteLine("Line Item ID: 26");
            Console.WriteLine("=========================");

            Console.WriteLine("Welcome To The Replenish Invetory Menu");
            Console.WriteLine("========================================");
            Console.WriteLine("Please Select From The Following Options");
            Console.WriteLine("[1] - Select A Line Item ID To Replenish");
            Console.WriteLine("[2] - Return To Main Menu");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter The LineItem ID You Want To Change");
                    try
                    {
                        int revId = Int32.Parse(Console.ReadLine());
                        LineItems itemFound = _itemBL.GetLineItemById(revId);
                        
                        Console.WriteLine("Input How Many You Want To Add");
                        int addedInv = Int32.Parse(Console.ReadLine());
                        _invBL.UpdateInventory(itemFound, addedInv);
                        Console.WriteLine("###########################################");
                        Console.WriteLine($"{addedInv} Successfully Added To Inventory");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Please Press Enter To Continue");
                        Console.WriteLine("###########################################");
                        Console.ReadLine();
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please Enter An Appropriate Line Item ID");
                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        return MenuType.ChangeInventoryMenu;
                    }
                    return MenuType.ChangeInventoryMenu;
                case "2":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please Enter An Appropriate ID");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.ChangeInventoryMenu;
            }
        }
    }
}