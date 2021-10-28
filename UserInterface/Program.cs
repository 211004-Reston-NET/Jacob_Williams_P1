using System;
using BusinessLogic;
using DataLogic;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool repeat = true;

            IFactory factory = new MenuFactory();

            IMenu page = factory.GetMenu(MenuType.MainMenu);

            while (repeat)
            {
            
            Console.Clear();
        
            page.Menu();
            MenuType currentPage = page.UserChoice();

            if (currentPage == MenuType.Exit)
            {
                Console.WriteLine("Thanks For Visiting!");
                Console.WriteLine("Press Enter To Cotinue");
                Console.ReadLine();
                repeat = false;               
            }
            else
            {
                page = factory.GetMenu(currentPage);
            }
            }
        }
    }
}    
//             bool running = true;
//             IMenu page = new MainMenu();
//             while(running)
//             {
//                 Console.Clear();
//                 page.Menu();
//                 MenuType userInput = page.UserChoice();
//                 switch (userInput )
//                 {
//                     // case MenuType.CurrentCustomer:
//                     // page = new CurrentCustomer();
//                     // break;
//                     //This is the Locations Menu in Storefronts
//                     case MenuType.Locations:
//                     page = new Locations();
//                     break;
//                     //This is the StoreFront Menu
//                     case MenuType.StoreFront:
//                     page = new StoreFront();
//                     break;
//                     //This is the  MainMenu
//                     case MenuType.MainMenu:
//                     page = new MainMenu();
//                     break;
//                     //This is the AddCustomer Menu
//                     case MenuType.AddCustomer:
//                     page = new AddCustomer(new CustomerBL(new Repository()));
//                     break;
//                     //This is to Exit the application
//                     case MenuType.Exit:
//                     running = false;
//                     break;
//                     //This default return user to Main Menu
//                     default:
//                     page = new MainMenu();
//                     break;
//                 }
//             }
//         }
//     }
// }
