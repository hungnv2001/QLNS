using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    public class SumDAO
    {
        private static SumDAO instance;

        public static SumDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SumDAO();
                }; return instance;
            }
            private set => instance = value;
        }
        private SumDAO() { }
        public string CountDay(string str) {
            string query = $"declare @tong int exec sp_SumDay '{str}' , @tong out select @tong as 'kq'";
            var result = DataProvider.Instance.ExcuteQuery(query).Rows[0]["kq"].ToString();
            if (result=="0")
            {
                result = "1" ;
            }
            return result;
        }
    }
}
