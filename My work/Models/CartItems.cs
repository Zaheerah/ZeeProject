using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using My_work.Models;
namespace My_work.Models
{
    public class CartItems
    {
        public List<CartDetails> catDetails = new List<CartDetails>();
        public double total = 0.0;
        public int totalItemsInCart = 0;

        public void addProduct(CartDetails sind)
        {
            catDetails.Add(sind);
            total += (sind.subTotal * sind.Quantity);
            totalItemsInCart += sind.Quantity;

                    //cartInfo.Add(prod);
        }

        public List<CartDetails> getItems()
        {
            return catDetails;
        }

        public double getTotal()
        {
            return total;
        }

        public void incrementQuantity(int index) {
            catDetails[index].Quantity++;
            total += catDetails[index].total;
            totalItemsInCart++;
        }

      }
}



 