using System;
using System.Collections.Generic;
using Models;

namespace BusinessLogic
{
    public interface IProductBL
    {
        List<Models.Product> GetAllProduct();
        Product GetProductByProductId(int p_productId);
    }
}