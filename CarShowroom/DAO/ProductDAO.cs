using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarShowroom.Models;
using Model.EF;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.DAO
{
    public class ProductDAO
    {
        ApplicationDbContext db = null;
        public ProductDAO()
        {
            db = new ApplicationDbContext();
        }

        public List<Product> ListHotProducts(int top)
        {
            return db.Products.Where(x => x.topHot != null && x.topHot > DateTime.Now).OrderByDescending(x => x.id).Take(top).ToList();
        }

    }
}