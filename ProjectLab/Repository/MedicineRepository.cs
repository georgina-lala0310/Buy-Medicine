using ProjectLab.Factory;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProjectLab.Repository
{
    public class MedicineRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        static int lastId = 0;
        public static bool InsertMed(string name, string desc, int stock, int price)
        {
            Medicine m = MedicineFactory.CreateMedicine(name, desc, stock, price);
            db.Medicines.Add(m);
            db.SaveChanges();
            lastId = m.MedicineId;
            return true;
        }

        public static List<Medicine> searchMed(string name)
        {
            List<Medicine> result = (from x in db.Medicines
                                     where x.Name.Contains(name)
                                     select x).ToList();
            return result;
        }

        public static List<Medicine> GetAllMed()
        {
            List<Medicine> result = (from x in db.Medicines select x).ToList();
            return result;
        }

        public static List<Medicine> randomMed()
        {
            List<Medicine> all = GetAllMed();

            Random rand = new Random();
            List<Medicine> randomList = new List<Medicine>();

            if (lastId != 0)
            {
                if (all.Count > 5)
                {
                    while (randomList.Count <= 5)
                    {
                        var med = all[rand.Next(1, lastId)];
                        if (med != null)
                        {
                            Medicine m = med;

                            if (!randomList.Contains(m))
                            {
                                randomList.Add(m);
                            }
                        }
                    }
                    return randomList;
                }
            }
            return all;
        }

        public static Medicine reqMed(int id)
        {
            Medicine res = (from x in db.Medicines where x.MedicineId==id select x).FirstOrDefault();
            return res;
        }

        public static string UpdateMed(Medicine m, string name, string desc,
            int stock, int price)
        {
            m.Name = name;
            m.Description = desc;
            m.Stock = stock;
            m.Price = price;
            db.SaveChanges();
            return "Update succeed";
        }

        public static bool DeleteMed(int id)
        {
            Medicine m = reqMed(id);
            db.Medicines.Remove(m);
            db.SaveChanges();
            return true;
        }

        public static DataTable medCart(List<Cart> c)
        {
            List<Cart> tempC = c;
            List<Medicine> all = GetAllMed();

            DataTable dt = new DataTable();
            dt.Columns.Add("MedicineId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Sub Total");

            for (int a = 0; a < tempC.Count; a++)
            {
                for (int b = 0; b < all.Count; b++)
                {
                    if (tempC[a].MedicineId == all[b].MedicineId)
                    {
                        dt.Rows.Add(tempC[a].MedicineId, all[b].Name, all[b].Price, 
                            tempC[a].Quantity, all[b].Price*tempC[a].Quantity);
                    }
                }
            }
            return dt;
        }

        public static bool minusStock(List<Cart> c)
        {
            List<Medicine> all = GetAllMed();
            for(int a=0; a < c.Count; a++)
            {
                for(int b = 0; b < all.Count; b++)
                {
                    if (c[a].MedicineId == all[b].MedicineId)
                    {
                        all[b].Stock -= c[a].Quantity;
                        db.SaveChanges();
                        break;
                    }
                }
            }
            return true;
        }
    }
}