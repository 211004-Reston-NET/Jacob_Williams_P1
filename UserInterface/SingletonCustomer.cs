using Models;

namespace UserInterface
{
    public class SingletonCustomer
    {
        public static Customer customer = new Customer();
        public static Order order = new Order();
        public static Product product = new Product();
        public static LineItems lineItems = new LineItems();
    }
}
