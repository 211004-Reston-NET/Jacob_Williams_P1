using System.IO;
using BusinessLogic;
using DataLogic;

namespace UserInterface
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new StoreMenu();
                case MenuType.ShowCustomer:
                    return new ShowCustomer(new CustomerBL(new Repository()));
                case MenuType.AddCustomer:
                    return new AddCustomer(new CustomerBL(new Repository()));
                case MenuType.CurrentCustomer:
                    return new CurrentCustomer(new CustomerBL(new Repository()));
                default:
                    return null;
            }
        }
    }
}