using QLNS.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tx_user.Text.Trim().Length == 0 || tx_pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống");
                return;
            }
            DataTable result;
            bool x = false;
            try
            {
                result = Login1(tx_user.Text, tx_pass.Text);
                x = Login1(tx_user.Text, tx_pass.Text).Rows.Count == 1;
            }
            catch (Exception)
            {
                result=null;
                x= false;
                
            }
            if (x)
            {
               // Service service = new Service();
                FormAll form = new FormAll();
                this.Hide();
               // service.Show();
               form.ShowDialog();               
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }     
        private DataTable Login1(string user, string pass)
        {
            AcountDAO acount = new AcountDAO();
            return acount.Login(user,pass);
        }
      
    }
}
