using System;

namespace UserInterface
{
    public class CheckOutMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome To The CheckOutMenu");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"|||||| You Owe Us {SingletonCustomer.order.TotalPrice} ||||||");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please Select From Our Options");
            Console.WriteLine("");
            Console.WriteLine("===========================");
            Console.WriteLine("[1] - Pay Required Amount");
            Console.WriteLine("[2] - Angrily Storm Out");
            Console.WriteLine("===========================");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("We Appreciate Your Business And Look Forward To Seeing You Again!");
                    Console.WriteLine("");
                    return MenuType.Exit;
                case "2":
                    Console.WriteLine("We Are Sorry You Are Unsatisfied... Please Enjoy The Rest Of Your Day");
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please Select From The Options Listed");
                    return MenuType.CheckOutMenu;
            }
        }
    }
}