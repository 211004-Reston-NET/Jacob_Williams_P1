using System.IO;
using BusinessLogic;
using DataLogic;
using DataLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UserInterface
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //This is the class that came from Microsoft.Extensions.Configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //This gets the current cirectory of the user interface file path
                .AddJsonFile("appsetting.json") //This adds the appsetting.json file in our user interface
                .Build(); // this builds the configuration
            
            DbContextOptions<Project_0_DatabaseContext> options =  new DbContextOptionsBuilder<Project_0_DatabaseContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;

            switch (p_menu)
            {
                // case MenuType.Locations:
                //     return new Locations();
                // case MenuType.RepInventoryMenu:
                //     return new RepInventoryMenu(new LineItemsBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.ChangeInventoryMenu:
                    return new ChangeInventoryMenu(new LineItemsBL(new RepositoryCloud(new Project_0_DatabaseContext(options))), new ChangeInvBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.OrderHistoryMenu:
                    return new OrderHistoryMenu(new OrderHistoryBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.CheckOutMenu:
                    return new CheckOutMenu();
                case MenuType.OrderMenu:
                    return new OrderMenu(new OrderBL(new RepositoryCloud(new Project_0_DatabaseContext(options))), new LineItemsBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.ProductMenu:
                    return new ProductMenu(new ProductBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.CaliforniaLocationMenu:
                    return new CaliforniaLocationMenu();
                case MenuType.MaineLocationMenu:
                    return new MaineLocationMenu();
                case MenuType.LoginMenu:
                    return new LoginMenu(new CustomerBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreFrontMenu:
                    return new StoreFrontMenu(new StoreFrontBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.ShowCustomer:
                    return new ShowCustomer(new CustomerBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.AddCustomer:
                    return new AddCustomer(new CustomerBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                case MenuType.CurrentCustomer:
                    return new CurrentCustomer(new CustomerBL(new RepositoryCloud(new Project_0_DatabaseContext(options))));
                default:
                    return null;
            }
        }
    }
}