using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tech_Shop.DB
{
    public class ProductAdder
    {
        public void AddProduct()
        {
            DataContext db = new DataContext();
            db.Products.Add(new Product()
            {
                Name = " Gaming Lenovo Legion Y520-15IKBN",
                Category = "Laptops",
                Type = "Laptop",
                Price = "1.729",
                Brand = "Lenovo",
                Description = "Y520 идва с най-новото поколение процесори, 7-о поколение Intel® Core i5/i7. С 12% по-висока производителност в сравнение с предишните процесори и 17% по-добра работа в интернет чрез специализираната мултимедийна система, можете да се насладите на най-новото в гейминг производителността и игри в Мрежата. Y520 се предлага с видеокарти NVIDIA® GTX 1050/1050GTi/1060, които осигуряват плавен гейминг и подходящи кадрови честоти."

            });
            db.SaveChanges();
        }
    }
}