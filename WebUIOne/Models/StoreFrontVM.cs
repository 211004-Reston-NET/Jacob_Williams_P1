using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIOne.Models
{
    public class StoreFrontVM
    {
        public StoreFrontVM()
        {

        }
        public StoreFrontVM(StoreFront p_store)
        {
            this.StoreFrontId = p_store.StoreFrontId;
            this.StoreFrontName = p_store.StoreFrontName;
            this.StoreFrontAddress = p_store.StoreFrontAddress;
        }

        public int StoreFrontId { get; set; }

        [Required]
        public string StoreFrontName { get; set; }
        [Required]
        public string StoreFrontAddress { get; set; }
      
    }
}
