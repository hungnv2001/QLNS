using Microsoft.VisualBasic.ApplicationServices;
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

namespace QLNS
{
    public partial class AcountQL : Form
    {
        DataTable user;
        public AcountQL()
        {
            InitializeComponent();
            lb_user.Hide();
        }
        public AcountQL(DataTable me)
        {
            InitializeComponent();
            lb_user.Hide();
            user = me;
            GetAcount(user);
        }

        private void GetAcount(DataTable me)
        {
            tx_userAD.Text = me.Rows[0]["userLogin"].ToString();
            tx_displayAD.Text = me.Rows[0]["userName"].ToString();
            tx_newPass.Text = me.Rows[0]["passWord"].ToString();
        }

        private void AcountQL_Load(object sender, EventArgs e)
        {
            Show();
        }
        private void Show()
        {
            dtgv_staff.DataSource = DataProvider.Instance.ExcuteQuery("select * from acount where  userLogin not in(select userLogin from acount where  (hide like 1) or powerAcount like 1)");
            dtgv_staff.Columns[4].Visible = false;
        }

        private void dtgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_user.Text = dtgv_staff.CurrentRow.Cells[0].Value.ToString();
            lb_user.Text = dtgv_staff.CurrentRow.Cells[0].Value.ToString();
            tx_displayName.Text = dtgv_staff.CurrentRow.Cells[1].Value.ToString();
            tx_pass.Text = dtgv_staff.CurrentRow.Cells[2].Value.ToString();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"insert into acount values('{tx_user.Text}',N'{tx_displayName.Text}','{tx_pass.Text}',0,NULL)";
                bool result = DataProvider.Instance.ExcuteNonQuery(query) == 1;
                if (result)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thành công");
            }
            Show();
        }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            tx_user.Text = "";
            tx_displayName.Text = "";
            tx_pass.Text = "";
            lb_user.Text = "";
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"update acount set userName = N'{tx_displayName.Text}', passWord = '{tx_pass.Text}' where userLogin like '{lb_user.Text}'";
                bool result = DataProvider.Instance.ExcuteNonQuery(query) == 1;
                if (result)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thành công");
            }
            Show();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"delete acount where userLogin='{lb_user.Text}'";
                bool result = DataProvider.Instance.ExcuteNonQuery(query) == 1;
                if (result)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thành công");
            }
            Show();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_newPass.Text != tx_rePass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng");
                    return;
                }
                string query = $"update acount set userName = N'{tx_displayAD.Text}', passWord = '{tx_newPass.Text}' where userLogin like '{tx_userAD.Text}'";
                bool result = DataProvider.Instance.ExcuteNonQuery(query) == 1;
                tx_rePass.Text = "";
                if (result)
                {
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
            string userLogin = user.Rows[0]["userLogin"].ToString();
            GetAcount(DataProvider.Instance.ExcuteQuery($"select * from acount where  userLogin not in(select userLogin from acount where  (hide like 1)) and userLogin='{userLogin}'"));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{tabControl1.SelectedIndex}");
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
