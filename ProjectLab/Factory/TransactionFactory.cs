using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Factory
{
    public class TransactionFactory
    {
        
        public static HeaderTransaction CreateHeaderTransac(int userId)
        {
            HeaderTransaction ht = new HeaderTransaction();
            ht.UserId = userId;
            ht.TransactionDate = DateTime.Now.ToString("dd-mm-yyy");
            return ht;
        }

        public static DetailTransaction CreateDetailTransac(Cart c, int transacId)
        {
            DetailTransaction dt = new DetailTransaction();
            
            dt.TransactionId = transacId;
            dt.MedicineId = c.MedicineId;
            dt.Quantity = c.Quantity;

            return dt;
        }
    }
}