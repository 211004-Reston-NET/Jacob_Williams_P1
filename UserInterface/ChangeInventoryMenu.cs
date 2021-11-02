using System;
using BusinessLogic;
using Models;

namespace UserInterface
{
    public class ChangeInventoryMenu : IMenu
    {
        private ILineItemsBL _itemBL;
        private IChangeInvBL _invBL;

        public ChangeInventoryMenu(ILineItemsBL p_itemBL, IChangeInvBL p_invBL)
        {
            this._itemBL = p_itemBL;
            this._invBL = p_invBL;
        }

        
        public void Menu()
        {
            Console.WriteLine("Welcome To The Change Inventory Menu");
            Console.WriteLine("====================================");
            Console.WriteLine("Please Reference Our Database For A List Of Line Items And Their IDs");
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
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please Enter An Appropriate Line Item ID");
                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        return MenuType.ChangeInventoryMenu;
                    }
                    return MenuType.ChangeInventoryMenu;
                default:
                    Console.WriteLine("Please Enter An Appropriate ID");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadLine();
                    return MenuType.ChangeInventoryMenu;
            }
        }
    }
}