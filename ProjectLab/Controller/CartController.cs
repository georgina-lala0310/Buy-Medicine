using ProjectLab.Handler;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Controller
{
    public class CartController
    {
        public static string AddToCart(Medicine m, string qty, int userId)
        {
            string lblMessage = "";
            int error = 0;
            int qtyInt;
            if (qty == null)
            {
                lblMessage += "Quantity cannot be empty\r\n";
                error++;
            }
            if (qty.Any(char.IsLetter))
            {
                lblMessage += "Quantity can be filled by numeric only\r\n";
                error++;
            }
            if (int.Parse(qty) <= 0)
            {
                lblMessage += "Quantity must be more than 0\r\n";
                error++;
            }
            if (int.Parse(qty) > m.Stock)
            {
                lblMessage += "Quantity must be less than equals with stock\r\n";
                error++;
            }
            if (error == 0)
            {
                qtyInt = int.Parse(qty);
                lblMessage = "";
                CartHandler.CreateCart(userId, m.MedicineId, qtyInt);
                HttpContext.Current.Response.Redirect("~/View/ViewPage/ViewCart.aspx");
            }
            return lblMessage;
        }
    }
}