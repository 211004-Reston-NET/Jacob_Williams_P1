using System;

namespace UserInterface
{
    public class OrderMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Please Enter The ProductId To Add Items To Your Order");
            Console.WriteLine("");
        }

        public MenuType UserChoice()
        {
            throw new NotImplementedException();
        }
    }
}