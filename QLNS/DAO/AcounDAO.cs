using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    internal class AcountDAO
    {
        public AcountDAO()
        {

        }
        public DataTable Login(string user, string password)
        {
            
            string query = $"exec sp_Login [{user}],[{password}]";
            DataTable result= DataProvider.Instance.ExcuteQuery(query);

            return result;
        }
        //test
        

    }
}
