using ProjectLab.Dataset;
using ProjectLab.Model;
using ProjectLab.Report;
using ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Controller
{
    public class TransactionController
    {
        private static DataSet TransacData()
        {
            DataSet ds = new DataSet();

            List<User> all = UserRepository.GetAllMember();

            for(int a=0; a < all.Count; a++)
            {
                var headerTransaction = ds.HeaderTransaction;
                var headerUser = ds.User;
                var detailTransaction = ds.DetailTransaction;
                var detailMed = ds.Medicine;

                var addUser = headerUser.NewRow();
                addUser["UserId"] = all[a].UserId;
                addUser["Name"] = all[a].Name;
                headerUser.Rows.Add(addUser);

                decimal count = 0;
                foreach(HeaderTransaction ht in all[a].HeaderTransactions)
                {
                    var header = headerTransaction.NewRow();
                    header["TransactionId"] = ht.TransactionId;
                    header["UserId"] = ht.UserId;
                    header["TransactionDate"] = ht.TransactionDate;
                    

                    foreach(DetailTransaction dt in ht.DetailTransactions)
                    {
                        var detail = detailTransaction.NewRow();
                        detail["TransactionId"] = dt.TransactionId;
                        detail["MedicineId"] = dt.MedicineId;
                        detail["Quantity"] = dt.Quantity;
                        

                        var med = detailMed.NewRow();
                        med["MedicineId"] = dt.Medicine.MedicineId;
                        med["Name"] = dt.Medicine.Name;
                        med["Price"] = dt.Medicine.Price;
                        detailMed.Rows.Add(med);

                        detail["SubTotal"] = (dt.Quantity * dt.Medicine.Price).ToString();
                        count += dt.Quantity * dt.Medicine.Price;
                        detailTransaction.Rows.Add(detail);

                    }

                    header["GrandTotal"] = count;
                    headerTransaction.Rows.Add(header);
                }
            }

            return ds;
        }

        public static TransactionReport CrystalReport()
        {
            TransactionReport tr = new TransactionReport();
            tr.SetDataSource(TransacData());
            return tr;
        }
    }
}