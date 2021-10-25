using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using Models;

namespace DataLogic
{
    public class Repository : IRepository
    {
        private const string _filepath ="./..DataLogic/Database/";
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
    }
}