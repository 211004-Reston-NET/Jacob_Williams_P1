using System;
using System.Collections.Generic;
using DataLogic;
using Models;

namespace BusinessLogic
{
    public class ProductBL
    {
        private IRepository _repo;
        public ProductBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public List<Product> GetAllProduct()
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            // for (int i =0; i < listOfProduct.Count; i++)
            // {
            //     listOfProduct[i].ProductName = listOfProduct[i].ProductName;
            // }
            return listOfProduct;
        }
        // public Product GetProductById(int p_productId);
        // {
        //     return listOfProduct.FirstOrDefault(prod => prod.ProductName.ToLower().Contains(p_name.ToLower())
        // }
        // public Customer GetCustomer(string p_name, string p_address)
        // {
        //     List<Customer> listOfCustomer = _repo.GetAllCustomer();
        //     return listOfCustomer.FirstOrDefault(cust => cust.Name.ToLower().Contains(p_name.ToLower()) && cust.Address.ToLower().Contains(p_address.ToLower()));
        // }
    }
}