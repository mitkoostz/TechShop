using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tech_Shop.DB;

namespace Tech_Shop.Controllers
{
    public class ShopCartController : Controller
    {
        
        public ActionResult Index()
        {

            using (var db = new DataContext())
            {
                 
                HttpCookie aCookie = Request.Cookies["Items"];
                if (aCookie != null)
                {
                    string cookiesItems = aCookie.Value.Replace("%20"," ");
                    var items = cookiesItems.Split(new[] {' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var ItemsInCart = new List<Product>();
                    foreach (var item in items)
                    {
                        var itemToInt = int.Parse(item);
                        var currentItem = db.Products.Where(p => p.Id == itemToInt ).First();
                        ItemsInCart.Add(currentItem);
                    }

                    if(ItemsInCart.Count == 0)
                    {
                        return View("ShopCartEmpty");
                    }


                    return View("ShopCart", ItemsInCart);
                }
                else
                {
                    return View("ShopCartEmpty");
                }
            }

            
        }
    }
}