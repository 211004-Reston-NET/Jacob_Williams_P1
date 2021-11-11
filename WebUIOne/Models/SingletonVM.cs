using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIOne.Models
{
    public class SingletonVM
    {
        public static Customer customer = new Customer();
        public static Order placeOrder = new Order();
    }
}
