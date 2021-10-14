using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int medId, int qty)
        {
            Cart c = new Cart();
            c.UserId = userId;
            c.MedicineId = medId;
            c.Quantity = qty;
            return c;
        }
    }
}