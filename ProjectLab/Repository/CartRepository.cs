using ProjectLab.Factory;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Repository
{
    public class CartRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static bool CreateCart(int userId, int medId, int qty)
        {
            Cart c = CartFactory.CreateCart(userId, medId, qty);
            db.Carts.Add(c);
            db.SaveChanges();
            return true;
        }

        public static List<Cart> GetAllData() {
            User u = (User)HttpContext.Current.Session["User"];
            List<Cart> res = (from x in db.Carts where x.UserId == u.UserId
                              select x).ToList();
            return res;
        }

        public static bool RemoveCart()
        {
            List<Cart> listC = GetAllData();
            

            for(int a = 0; a < listC.Count; a++)
            {
                Cart c = (from x in db.Carts select x).FirstOrDefault();
                db.Carts.Remove(c);
                db.SaveChanges();
            }
            
            return true;
        }

        public static bool RemoveItem(int id)
        {
            Cart c = (from x in db.Carts where x.MedicineId == id select x).FirstOrDefault();
            db.Carts.Remove(c);
            db.SaveChanges();
            return true;
        }

    }
}