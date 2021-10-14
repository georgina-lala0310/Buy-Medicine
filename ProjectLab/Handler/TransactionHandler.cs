using ProjectLab.Model;
using ProjectLab.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectLab.Handler
{
    public class TransactionHandler
    {
        public static bool CreateHeaderTransac(int userId)
        {
            return TransactionRepository.CreateHeaderTransac(userId);
        }

        public static bool CreateDetailTransac(List<Cart> c)
        {
            return TransactionRepository.CreateDetailTransac(c);
        }

        //public static DataTable showTransacHistory()
        //{
        //    return TransactionRepository.listTransacHistory();
        //}

        public static object showTransacHis(int id)
        {
            return TransactionRepository.listTransacHis(id);
        }
    }
}