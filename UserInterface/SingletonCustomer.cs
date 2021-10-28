using Models;

namespace UserInterface
{
    public class SingletonCustomer
    {
        public static Customer customer = new Customer();
        public static StoreFront storeFront = new StoreFront();
    }
}
