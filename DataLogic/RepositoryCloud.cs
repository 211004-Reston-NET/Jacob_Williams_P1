using System.Collections.Generic;
using Model = Models;
using DataLogic;
using Models;
using Entity = DataLogic.Entities;
using System.Linq;

namespace DataLogic
{


    public class RepositoryCloud : IRepository
    {
        private Entity.Project_0_DatabaseContext _context;
        public RepositoryCloud(Entity.Project_0_DatabaseContext p_context)
        {
            _context = p_context;
        }
        public Model.Customer AddCustomer(Model.Customer p_cust)
        {
            _context.Customers.Add
            (
                new Entity.Customer()
                {
                    CustomerName = p_cust.Name,
                    CustomerAddress = p_cust.Address,
                    CustomerEmail = p_cust.Email,
                    CustomerPhonenumber = p_cust.PhoneNumber,                   
                }
            );
            _context.SaveChanges();
            return p_cust;
        }

        public List<Model.Customer> GetAllCustomer()
        {
            return _context.Customers.Select(cust => 
                new Model.Customer()
                {
                    Name = cust.CustomerName,
                    Address = cust.CustomerAddress,
                    Email = cust.CustomerEmail,
                    PhoneNumber = cust.CustomerPhonenumber,
                    CustomerId = cust.CustomerId,
                }
            
            ).ToList();
        }

        public List<Model.LineItems> GetAllLineItems(int p_storeId)
        {
            return _context.LineItems
            .Where(item => item.StoreFront.StoreFrontId == p_storeId)
            .Select(item =>
                new Models.LineItems()
                {
                    ProductId = item.ProductId,
                    LineItemQuantity = item.LineItemQuantity,
                    LineItemId = item.LineItemId,
                    StoreFrontId = item.StoreFrontId
                }
                ).ToList();
        }

        public List<LineItems> GetAllLineItems()
        {
            throw new System.NotImplementedException();
            //???
        }

        public List<Model.StoreFront> GetStoreFrontList(Model.StoreFront store)
        {
            return _context.StoreFronts.Select(store => new Models.StoreFront()
            {
                StoreFrontName = store.StoreFrontName,
                StoreFrontAddress = store.StoreFrontAddress,
                StoreFrontId = store.StoreFrontId,
            }
            ).ToList();
        }

        public List<StoreFront> GetStoreFrontList()
        {
            throw new System.NotImplementedException();
            //???
        }

        // public List<Product> GetAllProduct()
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}