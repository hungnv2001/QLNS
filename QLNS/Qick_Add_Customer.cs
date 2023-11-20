using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNS
{

    public partial class Qick_Add_Customer : Form
    {
        public Qick_Add_Customer()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tx_email.Text.Trim();
                if (email.Length == 0)
                {
                    email = "NULL";
                }
                string query = $"Insert into customer(name, phoneNum, email) values (N'{tx_name.Text}','{tx_phoneNum.Text}', '{email}') ";
                var result = DataProvider.Instance.ExcuteNonQuery(query) == 1;
                if (result)
                {
                    query = "select * from customer order by id desc";
                    var result2 = DataProvider.Instance.ExcuteQuery(query).Rows[0]["id"].ToString();
                    MessageBox.Show($"Id mới tạo là: {result2}", "Thành công");
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thành công");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Qick_Add_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
