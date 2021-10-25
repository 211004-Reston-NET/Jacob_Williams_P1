namespace UserInterface
{
    public enum MenuType
    {
        MainMenu,
        AddCustomer,
        StoreFront,
        Locations,
        Exit,
    }


    public interface IMenu
    {
        //Displays Menu of current class and the choices user can make
        void Menu();
        //records what user inputs and changes menu accordingly
        MenuType UserChoice();
    }
}