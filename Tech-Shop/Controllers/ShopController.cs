using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tech_Shop.DB;
using Tech_Shop.DB.Models;
using Tech_Shop.Models;

namespace Tech_Shop.Controllers
{
    public class ShopController : Controller
    {
        
        public ActionResult Index(string category ,int? page)
        {
            //if category is not set
            if(category == null)
            {
                using (var db = new DataContext())
                {
                    var allproducts = db.Products.ToList();
                    return View("NoCategory");
                }
                
            }

            try
            {
                //page by default
                if(page == null)
                {
                    page = 1;
                }

                using (var db = new DataContext())
                {
                    int itemsToSkip = ((int)page - 1) * 12;
                    ViewBag.Page = page;
                    ViewBag.Category = category;

                    var products = db.Products
                        .Where(p => p.Category == category)
                        .OrderBy(p => p.Name)
                        .Skip(itemsToSkip)
                        .Take(12)
                        .ToList();

                    if (products.First().Type == "Computer")
                    {
                        products.ForEach(p => p.ComputerSpecification = p.ComputerSpecification);
                    }

                    //if client enter incorrect category
                    if(products.Count == 0)
                    {                     
                        return View("PageNotFound");
                    }

                    return View(products);
                }
            }
            //if category or page are invalid
            catch (Exception e)
            {
                throw e;
                return RedirectToAction("Index","Home");
            }
         
            
        }

        public ActionResult ViewProduct(int? id)
        {
            if(id == null)
            {
                return View("PageNotFound");
            }

            try
            {
                using (var db = new DataContext())
                {
                    var product = db.Products.Find(id);
                    if (product == null)
                    {
                        return View("PageNotFound");
                    }
                    product.ComputerSpecification = product.ComputerSpecification;

                    return View(product);
                }
            }
            catch (Exception)
            {

                return View("PageNotFound");
            }
        
           
        }

        [HttpPost]
        public ActionResult PurchaseStart()
        {
            return View("Purchase");
        }

        [HttpPost]
        public ActionResult PurchaseFinish(PurchaseData data)
        {
            try
            {
                using (var db = new DataContext())
                {
                    HttpCookie aCookie = Request.Cookies["Items"];
                    string cookiesItems = aCookie.Value.Replace("%20", " ");
                    var cartItems = cookiesItems.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var order = new Order()
                    {
                        clientName = data.fullName,
                        clientPhone = data.mobilePhone,
                        Adress = data.adress,
                        City = data.city,
                        OrderedProducts = string.Join(" ", cartItems)
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.InputError = "All fields are required!";
                return View("Purchase");
                
            }
       
           

           
        }

      
    }

}