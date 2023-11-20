using Microsoft.VisualBasic.ApplicationServices;
using QLNS.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class AcountNV : Form
    {
        DataTable users;
        public AcountNV()
        {
            InitializeComponent();
        }
        public AcountNV(DataTable me)
        {
            InitializeComponent();
            users = me;
            GetAcount(me);
        }
        private void GetAcount(DataTable me)
        {
            tx_nameAD.Text = me.Rows[0]["userLogin"].ToString();
            tx_displayAD.Text = me.Rows[0]["userName"].ToString();
            tx_newpass.Text = me.Rows[0]["passWord"].ToString();
        }


        private void bt_del_Click(object sender, EventArgs e)
        {
            int index = dtgv_customer.CurrentRow.Index;
            DataGridViewRow row = dtgv_customer.Rows[index];
            string ID = row.Cells[0].Value.ToString();
            string query = $"update customer set hide = 1 where ID = {Convert.ToInt32(ID)}";
            DataProvider.Instance.ExcuteNonQuery(query);
            Load_Customer();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int index = dtgv_customer.CurrentRow.Index;
            DataGridViewRow row = dtgv_customer.Rows[index];
            string ID = row.Cells[0].Value.ToString();
            string query = $"update customer set name = N'{txtName.Text}', phoneNum = '{txtSDT.Text}', email = '{txtEmail.Text}' where ID = {Convert.ToInt32(ID)}";
            DataProvider.Instance.ExcuteNonQuery(query);
            Load_Customer();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string query = $"Insert into customer values (N'{txtName.Text}','{txtSDT.Text}', '{txtEmail.Text}',NULL) ";
            DataProvider.Instance.ExcuteNonQuery(query);
            Load_Customer();
        }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
        }


        private void AcountNV_Load(object sender, EventArgs e)
        {
            Load_Customer();
        }
        public void Load_Customer()
        {
            string query = "select ID, name, phoneNum, email from customer where  id not in(select id from customer where (hide like 1))";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgv_customer.DataSource = data;
            dtgv_customer.Columns[0].Width = 45;
            dtgv_customer.Columns[3].Width = 245;
        }

        private void dtgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgv_customer.CurrentRow.Index;
            DataGridViewRow row = dtgv_customer.Rows[index];
            txtName.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
        }
        private void bt_save_Click(object sender, EventArgs e  )
        {
            try
            {
                if (tx_newpass.Text != tx_rePass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng");
                    return;
                }
                string query = $"update acount set userName = N'{tx_displayAD.Text}', passWord = '{tx_newpass.Text}' where userLogin like '{tx_nameAD.Text}'";
                bool result = DataProvider.Instance.ExcuteNonQuery(query) == 1;
                tx_rePass.Text = "";
                if (result)
                {
                    users.Rows[0]["userName"] = tx_displayAD.Text;
                    MessageBox.Show("Thành công");
                   
                }
                else
                {
                    MessageBox.Show("Suýt hành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại");

            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            string userLogin = users.Rows[0]["userLogin"].ToString();
            GetAcount(DataProvider.Instance.ExcuteQuery($"select * from acount where  userLogin not in(select userLogin from acount where  (hide like 1)) and userLogin='{userLogin}'"));
        }
    }
}
