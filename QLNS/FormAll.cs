using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormAll : Form
    {
        DataTable users;
        public FormAll()
        {
            InitializeComponent();
        }
        public FormAll(DataTable user)
        {
            InitializeComponent();
            users = user;
        }

        private void FormAll_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Service(users));
            Checkpower();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
           // childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
           // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Checkpower()
        {
            string power = users.Rows[0]["powerAcount"].ToString();
            if (power == "True")
            {
                bt_bookService.Enabled = true;
            }
            else
            {
                
            }
        }

        private void bt_acount_Click(object sender, EventArgs e)
        {
            if (users.Rows[0]["powerAcount"].ToString() == "True")
            {
                OpenChildForm(new AcountQL(users));
            }
            else
            {
                OpenChildForm(new AcountNV(users));
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_returnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnBook());
        }

        private void bt_bookService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookService());
        }

        private void bt_servive_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Service(users));
        }

        private void FormAll_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
