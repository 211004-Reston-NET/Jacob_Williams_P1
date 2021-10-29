using System;
using System.Collections.Generic;
using DataLogic.Entities;
using Models;

namespace BusinessLogic
{
    public interface IStoreFrontBL
    {
        /// <summary>
        /// This will get the two storefronts 
        /// </summary>
        /// <returns></returns>
        List<Models.StoreFront> GetStoreFrontList();
    }
}