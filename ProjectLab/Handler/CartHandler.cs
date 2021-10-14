using ProjectLab.Model;
using ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectLab.Handler
{
    public class CartHandler
    {
        public static bool CreateCart(int userId, int medId, int qty)
        {
            return CartRepository.CreateCart(userId, medId, qty);
        }

        public static List<Cart> GetAllData()
        {
            return CartRepository.GetAllData();
        }

        public static DataTable ShowCart()
        {
            return MedicineRepository.medCart(GetAllData());
        }

        public static bool RemoveCart()
        {
            return CartRepository.RemoveCart();
        }

        public static bool RemoveItem(int id)
        {
            return CartRepository.RemoveItem(id);
        }
    }
}