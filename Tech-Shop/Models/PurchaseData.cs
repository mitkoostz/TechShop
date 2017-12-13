using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tech_Shop.Models
{
    public class PurchaseData
    {
        [Required]
        public string fullName { get; set; }

        [Required]
        public string mobilePhone { get; set; }
    
        public string area { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string adress { get; set; }

        public List<int> items { get; set; }

        public PurchaseData()
        {
            items = new List<int>();
        }
    }
}