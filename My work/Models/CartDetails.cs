using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_work.Models
{
    public class CartDetails
    {
        public string ItemNumber { get; set; }
        public string productName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double subTotal { get; set; }
        public double total { get; set; }


    }
}