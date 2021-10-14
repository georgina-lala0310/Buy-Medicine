using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Factory
{
    public class MedicineFactory
    {
        public static Medicine CreateMedicine(string name, string desc, int stock, int price)
        {
            Medicine m = new Medicine();
            m.Name = name;
            m.Description = desc;
            m.Stock = stock;
            m.Price = price;
            return m;
        }
    }
}