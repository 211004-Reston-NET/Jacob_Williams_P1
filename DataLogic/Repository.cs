using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using Models;

namespace DataLogic
{
    public class Repository
    {
        private const string _filepath ="./../DataLogic/Database/";
        private string _jsonString;

        public Customer AddCustomer(Customer p_rest)
        {
            List<Customer> listOfCustomers = GetAllCustomer();

            listOfCustomers.Add(p_rest);
            
            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions{WriteIndented=true});

            File.WriteAllText(_filepath+"Customer.json",_jsonString);

            return p_rest;
        }

        public List<Customer> GetAllCustomer()
        {
            try
            {
                _jsonString = File.ReadAllText(_filepath+"Customer.json");
            }
            catch (System.IO.FileNotFoundException)
            {
                Customer newCust = new Customer();
                List<Customer> listOfCust = new List<Customer>();
                listOfCust.Add(newCust);

                File.WriteAllText(_filepath+"Customer.json", JsonSerializer.Serialize<List<Customer>>(listOfCust));
                _jsonString = File.ReadAllText(_filepath+"Customer.json");
            }
            catch(SystemException var)
            {
                throw var;
            }
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public List<LineItems> GetAllLineItems()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int p_id)
        {
            throw new NotImplementedException();
        }

        public LineItems GetLineItemById(int p_id)
        {
            throw new NotImplementedException();
        }

        public List<LineItems> GetLineItems(int p_storeId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByProductAndStoreFrontId(int p_productId, int p_storeId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByProductId(int p_productId)
        {
            throw new NotImplementedException();
        }

        public List<StoreFront> GetStoreFrontList()
        {
            throw new NotImplementedException();
        }

        public List<Order> OrderHistory()
        {
            throw new NotImplementedException();
        }

        public List<Order> OrderHistoryBL()
        {
            throw new NotImplementedException();
        }

        public Order PlaceOrder()
        {
            throw new NotImplementedException();
        }


        public StoreFront RepInventory(int p_lineItemId, int p_lineItemQuantity)
        {
            throw new NotImplementedException();
        }

        public LineItems UpdateInventory(LineItems p_upd)
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Customer p_customer, Order p_order)
        {
            throw new NotImplementedException();
        }
    }
}