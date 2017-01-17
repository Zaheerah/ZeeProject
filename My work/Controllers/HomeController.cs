using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_work.Models;

namespace My_work.Controllers
{
    public class HomeController : Controller
    {
        public static ProductDetails productInfo = new ProductDetails();
        static CartItems Cart = new CartItems();
        
    

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Products(string ItemNum)
        {
            productInfo.ProInfo();
            return View(productInfo.getProInfo(ItemNum));
        }

        public ActionResult ProductDetails()
        {

            productInfo.ProInfo();
            return View(productInfo.pro);


        }
        public ActionResult CartItems()
        {
            List<CartDetails> myList = Session["prof"] as List<CartDetails>;
            return View(myList);
        }
        public ActionResult CartDetails()
        {
            return View();
        }


        public ActionResult AddToCart(string ItemNum)
        {
            //psudocode
            

            if (Session["Prof"] == null)
            {
                Session["prof"] = Cart;
            }

            //Check if item is already in cart
            bool found = false;
            int indexOfFound = -1;
            for (int i = 0; i < Cart.getItems().Count; i++)
            {
                CartDetails p = Cart.getItems()[i];
                if (p.ItemNumber.Equals(ItemNum, StringComparison.Ordinal))
                {
                    found = true;
                    indexOfFound = i;
                    break;
                }
            }

            //if not, add to card
            //Else increase quantity by ones
            if (found)
            {
                Cart.incrementQuantity(indexOfFound);
                //Cart.getTotal();

            } else {
                CartDetails product = new CartDetails();

                Products item = productInfo.getProInfo(ItemNum);
                product.ItemNumber = item.ItemNumber;
                product.productName = item.ProductName;
                product.Description = item.ProductDiscription;
                product.Quantity = 1;
                product.subTotal = item.ProPrice;
                product.total = Cart.getTotal();
                    
              
                
                Cart.addProduct(product);
                ViewBag.MyCarts = Cart.catDetails.Count();
                Session["prof"] = Cart.catDetails;
            }
            
            
            var list = Session["cart"] as CartItems;
            return View("Product");
        }
     
        public ActionResult Delete(string ItemNumber)
        {
            List<CartDetails> listo = Session["prof"] as List<CartDetails>;
            var item = listo.SingleOrDefault(x => x.ItemNumber == ItemNumber);
            if (item != null)
                listo.Remove(item);
            return RedirectToAction("CartItems", "Home");
        }

        }
    }

