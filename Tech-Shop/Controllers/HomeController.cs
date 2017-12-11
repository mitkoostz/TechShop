using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tech_Shop.DB;

namespace Tech_Shop.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
                return View();
                     
        }
           
 
        [HttpPost]
        public ActionResult Search(string searched)
        {
            if(searched == null || searched == "")
            {
                return View("SearchNoResults");
            }

            using (var db = new DataContext())
            {
                var matchedProducts = db.Products.Where(p => p.Name.Contains(searched)).ToList();

                if(matchedProducts.Count == 0)
                {
                    ViewBag.Searched = searched;
                    return View("SearchNoResults");
                }

                ViewBag.Searched = searched;
                return View(matchedProducts);
                


            }

        }
  
    }
}