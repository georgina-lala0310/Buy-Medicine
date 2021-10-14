using ProjectLab.Factory;
using ProjectLab.Handler;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectLab.Repository
{
    public class TransactionRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        static int transacId;
        public static bool CreateHeaderTransac(int id)
        {
            HeaderTransaction ht = TransactionFactory.CreateHeaderTransac(id);
            db.HeaderTransactions.Add(ht);
            db.SaveChanges();
            transacId = ht.TransactionId;
            return true;
        }

        public static bool CreateDetailTransac(List<Cart> c)
        {
            for(int a=0; a < c.Count; a++)
            {
                DetailTransaction dt = TransactionFactory.CreateDetailTransac(c[a], transacId);
                db.DetailTransactions.Add(dt);
                db.SaveChanges();
            }
            return true;
        }

        public static List<HeaderTransaction> GetAllHeader()
        {
            User u = (User)HttpContext.Current.Session["User"];
            List <HeaderTransaction> ht = (from x in db.HeaderTransactions where u.UserId == x.UserId
                                          select x).ToList();

            return ht;
        }

        public static List<DetailTransaction> GetAllDetail()
        {
            List<DetailTransaction> dt = (from x in db.DetailTransactions
                                          where x.TransactionId==x.HeaderTransaction.TransactionId
                                          select x).ToList();
            return dt;
        }

        public static HeaderTransaction GetHeaderbyId()
        {
            User u = (User)HttpContext.Current.Session["User"];
            HeaderTransaction ht = (from x in db.HeaderTransactions where
                                    x.UserId == u.UserId select x).FirstOrDefault();
            return ht;
        }

        
        //public static DataTable listTransacHistory()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("MedicineName");
        //    dt.Columns.Add("Quantity");
        //    dt.Columns.Add("Date");
        //    dt.Columns.Add("Subtotal");

        //    List<HeaderTransaction> ht = GetAllHeader();
        //    List<DetailTransaction> detail = GetAllDetail();

        //    //Console.WriteLine(ht.Count);
        //    //Console.WriteLine(detail.Count);
        //    HeaderTransaction htt = GetHeaderbyId();

           
        //        for(int b = 0; b < detail.Count; b++)
        //        {
        //            dt.Rows.Add(MedicineHandler.reqMed(detail[b].MedicineId).Name,
        //                detail[b].Quantity, htt.TransactionDate,
        //                MedicineHandler.reqMed(detail[b].MedicineId).Price * detail[b].Quantity);
        //        }
            
        //    return dt;
        //}

        public static object listTransacHis(int id)
        {
            var list = (from ht in db.HeaderTransactions join dt in db.DetailTransactions
                        on ht.TransactionId equals dt.TransactionId
                        where id==ht.UserId
                        select new
                            {
                                MedicineName = dt.Medicine.Name,
                                Quantity = dt.Quantity,
                                TransactionDate = ht.TransactionDate,
                                SubTotal = (dt.Quantity * dt.Medicine.Price).ToString()
                            }
                        ).ToList();
            return list;
        }


    }
}