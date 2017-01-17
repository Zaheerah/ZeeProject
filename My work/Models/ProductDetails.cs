using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace My_work.Models
{
    public class ProductDetails
    {
        public List<Products> pro = new List<Products>();
        Products pr1 = new Products();
        Products pr2 = new Products();
        Products pr3 = new Products();
        Products pr4 = new Products();
        Products pr5 = new Products();
        Products pr6 = new Products();


        public void ProInfo()
        {
            pro.Clear();
            // pic1

            pr1.ProductName = "Weeding decor 2";
            pr1.ProductDiscription = "life worth weeding decor a bride could wish for";
            pr1.ProPrice = 10000.00;
            pr1.ItemNumber = "125516";
            pro.Add(pr1);

            // pic2
            
            pr2.ProductName = "Cherish weeding decor";
            pr2.ProductDiscription = "a weeding decor with style ";
            pr2.ProPrice = 12000.00;
            pr2.ItemNumber = "1255112";
            pro.Add(pr2);

            // pic3

            pr3.ProductName = "Weeding decor 2";
            pr3.ProductDiscription = " romantic-design-luxury-wedd and white weeding decoration ";
            pr3.ProPrice = 18000.00;
            pr3.ItemNumber = "125517";
            pro.Add(pr3);

            // pic4

            pr4.ProductName = "Party event decor 2";
            pr4.ProductDiscription = "part event for afte parties and formal parties ";
            pr4.ProPrice = 18000.00;
            pr4.ItemNumber = "125518";
            pro.Add(pr4);

            // pic5

            pr5.ProductName = "Party event decor 1";
            pr5.ProductDiscription = "part event for afte parties or graduations";
            pr5.ProPrice = 16000.00;
            pr5.ItemNumber = "1255119"; 
            pro.Add(pr5);

            // pic6

            pr6.ProductName= "Wedding Decor Classic";
            pr6.ProductDiscription = " weeding decor with an extra suprise for the bride";
            pr6.ProPrice = 13000.00;
            pr6.ItemNumber = "1255110";
            pro.Add(pr6);

        }
        public Products getProInfo(string ProductName)

        {
            ProInfo();

            Products filter = null;
            foreach (Products item in pro)
            {
                if (item.ItemNumber == ProductName)
                {
                    filter = item;
                }
            }

            return filter;

        }
    }
}