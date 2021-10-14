using ProjectLab.Handler;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Controller
{
    public class MedicineController
    {
        public static string InsertMed(string name, string desc, string stock, string price)
        {
            int flag = 0;
            string lblMsg = "";
            int stockInt, priceInt;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(desc) ||
                string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(price))
            {
                lblMsg += "Every box must be filled\r\n";
                flag++;
            }

            if (desc.Length < 10)
            {
                lblMsg += "Description must be longer than 10 characters\r\n";
                flag++;
            }

            if(stock.Any(char.IsLetter) || price.Any(char.IsLetter))
            {
                lblMsg += "Stock and price must be numeric\r\n";
                flag++;
            }

            if (int.Parse(stock) <= 0)
            {
                lblMsg += "Stock must be more than 0\r\n";
                flag++;
            }

            if (int.Parse(price) <= 0)
            {
                lblMsg += "Price must be more than 0\r\n";
                flag++;
            }

            if (flag == 0)
            {
                stockInt = int.Parse(stock);
                priceInt = int.Parse(price);
                MedicineHandler.InsertMed(name, desc, stockInt, priceInt);
                lblMsg = "Insert Succeed";
            }
            return lblMsg;
        }

        public static string UpdateMed(Medicine m, string name, string desc, string stock, string price)
        {
            int flag = 0;
            string lblMsg = "";
            int stockInt, priceInt;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(desc) ||
                string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(price))
            {
                lblMsg += "Every box must be filled\r\n";
                flag++;
            }

            if (desc.Length < 10)
            {
                lblMsg += "Description must be longer than 10 characters\r\n";
                flag++;
            }

            if (stock.Any(char.IsLetter) || price.Any(char.IsLetter))
            {
                lblMsg += "Stock and price must be numeric\r\n";
                flag++;
            }

            if (int.Parse(stock) <= 0)
            {
                lblMsg += "Stock must be more than 0\r\n";
                flag++;
            }

            if (int.Parse(price) <= 0)
            {
                lblMsg += "Price must be more than 0\r\n";
                flag++;
            }

            if (flag == 0)
            {
                stockInt = int.Parse(stock);
                priceInt = int.Parse(price);
                lblMsg = MedicineHandler.UpdateMed(m, name, desc, stockInt, priceInt);
            }
            return lblMsg;
        }
    }
}