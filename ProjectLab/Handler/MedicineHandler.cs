using ProjectLab.Model;
using ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Handler
{
    public class MedicineHandler
    {
        public static bool InsertMed(string name, string desc, int stock, int price)
        {
            return MedicineRepository.InsertMed(name, desc, stock, price);
        }

        public static List<Medicine> GetAllMed()
        {
            return MedicineRepository.GetAllMed();
        }

        public static List<Medicine> searchMed(string name)
        {
            return MedicineRepository.searchMed(name);
        }

        public static List<Medicine> randomMed()
        {
            return MedicineRepository.randomMed();
        }

        public static Medicine reqMed(int id)
        {
            return MedicineRepository.reqMed(id);
        }

        public static string UpdateMed(Medicine m, string name, string desc,
            int stock, int price)
        {
            return MedicineRepository.UpdateMed(m, name, desc, stock, price);
        }

        public static bool DeleteMed(int id)
        {
            return MedicineRepository.DeleteMed(id);
        }

        public static bool minusStock(List<Cart> c)
        {
            return MedicineRepository.minusStock(c);
        }
    }
}