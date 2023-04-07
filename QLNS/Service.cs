using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class Service : Form
    {
        DataTable user;
        public Service()
        {
            InitializeComponent();
        }
        public Service(DataTable InforUser)
        {
            InitializeComponent();
            user = InforUser;
        }

        private void Service_Load(object sender, EventArgs e)
        {
            Load_All_Book();
            //ShowName();
            CreateSVBook();
        }

        private void CreateSVBook()
        {
            DataGridViewTextBoxColumn dgvcId = new DataGridViewTextBoxColumn();
            dgvcId.HeaderText = "Id";
            DataGridViewTextBoxColumn dgvcName = new DataGridViewTextBoxColumn();
            dgvcName.HeaderText = "Tên sách";
            DataGridViewTextBoxColumn dgvcAuthor = new DataGridViewTextBoxColumn();
            dgvcAuthor.HeaderText = "Tác giả";
            DataGridViewTextBoxColumn dgvcAmount = new DataGridViewTextBoxColumn();
            dgvcAmount.HeaderText = "Số lượng";
            DataGridViewTextBoxColumn dgvcType = new DataGridViewTextBoxColumn();
            dgvcType.HeaderText = "Loại dịch vụ";
            DataGridViewTextBoxColumn dgvcTutal = new DataGridViewTextBoxColumn();
            dgvcTutal.HeaderText = "Đơn giá";
            dtgv_serviceBook.Columns.Add(dgvcId);
            dtgv_serviceBook.Columns.Add(dgvcName);
            dtgv_serviceBook.Columns.Add(dgvcAuthor);
            dtgv_serviceBook.Columns.Add(dgvcAmount);
            dtgv_serviceBook.Columns.Add(dgvcType);
            dtgv_serviceBook.Columns.Add(dgvcTutal);
            dtgv_serviceBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_serviceBook.AllowUserToAddRows = false;
            dtgv_serviceBook.Columns[0].Visible = false;
        }

        private void ShowName()
        {
            string power = user.Rows[0]["powerAcount"].ToString();
            if (power == "True")
            {
                power = "Quản lý";
 //               bt_acount.Enabled = true;
                
            }
            else
            {
                power = "Nhân viên";
            }
            grb_power.Text = power;
            lb_name.Text = user.Rows[0]["userName"].ToString();

        }
        private void Addcol()
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn col2 = new DataGridViewCheckBoxColumn();


            dtgv_book.Columns.Add(col);
            dtgv_book.Columns.Add(col2);

            dtgv_book.Columns[6].HeaderText = "Mua";
            dtgv_book.Columns[7].HeaderText = "Mượn";
            dtgv_book.Columns[5].Width = 50;
            dtgv_book.Columns[6].Width = 40;
            dtgv_book.Columns[7].Width = 40;
            dtgv_book.Columns[0].Visible = false;
            dtgv_book.Columns[1].Visible = false;
            dtgv_book.Columns[2].Visible = false;
        }
        private void Load_All_Book()
        {
            DataTable dt_book = DataProvider.Instance.ExcuteQuery("select id,bookPrice,bookLoan, name as N'Tên sách',author as N'Tác giả', actualQuantity as N'Số lượng' from book");
            dtgv_book.DataSource = dt_book;
            Addcol();


        }

        private void bt_seach_Click(object sender, EventArgs e)
        {
            dtgv_book.Columns.Clear();
            string query = $"select id,bookPrice,bookLoan, name as N'Tên sách',author as N'Tác giả', actualQuantity as N'Số lượng'  from book where name like N'%{tx_search.Text.Trim()}%' or author like N'%{tx_search.Text.Trim()}%'";
            dtgv_book.DataSource = DataProvider.Instance.ExcuteQuery(query);
            Addcol();
        }

        private void bt_searchCusment_Click(object sender, EventArgs e)
        {
            string query = $"select name from customer where id={id_cusment.Text}";
            tx_nameCusment.Text = DataProvider.Instance.ExcuteQuery(query).Rows[0]["name"].ToString();
        }

        private void bt_addBook_Click(object sender, EventArgs e)
        {
            DelSum();
            CheckBuy();
            CheckLoan();


        }
        private void CheckBuy()
        {
            for (int i = 0; i <= dtgv_book.Rows.Count - 1; i++)
            {
                bool checkedCell = false;
                bool rowAlreadyExist = false;
                try
                {
                    checkedCell = (bool)dtgv_book.Rows[i].Cells[6].Value;
                }
                catch (Exception)
                {
                    continue;
                }
                //  bool checkedCell2 = (bool)dtgv_book.Rows[i].Cells[5].Value;

                if (checkedCell == true)
                {
                    DataGridViewRow row = dtgv_book.Rows[i];

                    if (dtgv_serviceBook.Rows.Count != 0)
                    {
                        for (int j = 0; j <= dtgv_serviceBook.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dtgv_serviceBook.Rows[j].Cells[0].Value.ToString() && dtgv_serviceBook.Rows[j].Cells[4].Value.ToString() == "Mua")
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }
                        if (rowAlreadyExist == false)
                        {
                            dtgv_serviceBook.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(), "1", "Mua", row.Cells[1].Value.ToString()
                                                   );
                        }
                    }

                    else
                    {
                        dtgv_serviceBook.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(), "1", "Mua", row.Cells[1].Value.ToString());
                    }
                }
            }
        }
        private void CheckLoan()
        {
            for (int i = 0; i <= dtgv_book.Rows.Count - 1; i++)
            {
                bool checkedCell = false;
                bool rowAlreadyExist = false;
                try
                {
                    checkedCell = (bool)dtgv_book.Rows[i].Cells[7].Value;
                }
                catch (Exception)
                {
                    continue;
                }
                //  bool checkedCell2 = (bool)dtgv_book.Rows[i].Cells[5].Value;

                if (checkedCell == true)
                {
                    DataGridViewRow row = dtgv_book.Rows[i];

                    if (dtgv_serviceBook.Rows.Count != 0)
                    {
                        for (int j = 0; j <= dtgv_serviceBook.Rows.Count - 1; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dtgv_serviceBook.Rows[j].Cells[0].Value.ToString() && dtgv_serviceBook.Rows[j].Cells[4].Value.ToString() == "Mượn")
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }
                        if (rowAlreadyExist == false)
                        {
                            dtgv_serviceBook.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(), "1", "Mượn", row.Cells[1].Value.ToString()
                                                   );
                        }
                    }

                    else
                    {
                        dtgv_serviceBook.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(), "1", "Mượn", row.Cells[1].Value.ToString());
                    }
                }
            }
        }

        private void DelSum()
        {
            for (int i = 0; i < dtgv_serviceBook.Rows.Count; i++)
            {
                if (dtgv_serviceBook.Rows[i].Cells[0].Value.ToString() == "id")
                {
                    dtgv_serviceBook.Rows.RemoveAt(i);
                    break;

                }
            }
        }
        private void bt_tutal_Click(object sender, EventArgs e)
        {
            DelSum();
            int count = 0;
            tx_namett.Text = tx_nameCusment.Text;
            int tong = Sum(ref count);
            dtgv_serviceBook.Rows.Add("id", "Tổng tiền:", "", count, "", tong);
            tx_sum.Text = tong.ToString();
        }

        private int Sum(ref int count)
        {

            int all = 0;
            for (int i = 0; i < dtgv_serviceBook.Rows.Count; i++)
            {
                count += int.Parse(dtgv_serviceBook.Rows[i].Cells[3].Value.ToString());
                all += int.Parse(dtgv_serviceBook.Rows[i].Cells[3].Value.ToString()) * int.Parse(dtgv_serviceBook.Rows[i].Cells[5].Value.ToString());
            }
            return all;
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            DelSum();
            if (this.dtgv_serviceBook.SelectedRows.Count > 0)
            {
                int x = int.Parse(dtgv_serviceBook.SelectedCells[0].Value.ToString());
                if (dtgv_serviceBook.SelectedCells[4].Value.ToString() == "Mua")
                {
                    for (int i = 0; i < dtgv_book.Rows.Count; i++)
                    {
                        if (int.Parse(dtgv_book.Rows[i].Cells[0].Value.ToString()) == x)
                        {
                            dtgv_book.Rows[i].Cells[6].Value = false;
                            break;
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < dtgv_book.Rows.Count; i++)
                    {
                        if (int.Parse(dtgv_book.Rows[i].Cells[0].Value.ToString()) == x)
                        {
                            dtgv_book.Rows[i].Cells[7].Value = false;
                            break;
                        }
                    }
                }

                dtgv_serviceBook.Rows.RemoveAt(this.dtgv_serviceBook.SelectedRows[0].Index);
            }
        }

        private void bt_delAll_Click(object sender, EventArgs e)
        {
            dtgv_serviceBook.Rows.Clear();
            for (int i = 0; i < dtgv_book.Rows.Count; i++)
            {  
                    dtgv_book.Rows[i].Cells[6].Value = false;
                    dtgv_book.Rows[i].Cells[7].Value = false;
                    
               
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
                    string idNV = user.Rows[0]["userlogin"].ToString();
                    int idCustomer = int.Parse(id_cusment.Text);
                    string date =  System.DateTime.Now.ToShortDateString();
            try
            {
                for (int i = 0; i < dtgv_serviceBook.Rows.Count-1; i++)
                {
                    int idBook = int.Parse(dtgv_serviceBook.Rows[i].Cells[0].Value.ToString());
                    int amount = int.Parse(dtgv_serviceBook.Rows[i].Cells[3].Value.ToString());
                    int type = dtgv_serviceBook.Rows[i].Cells[4].Value.ToString()=="Mua"?1:0;
                    int price = int.Parse(dtgv_serviceBook.Rows[i].Cells[5].Value.ToString());
                    string query = $"exec sp_InsertService {idBook},'{idNV}',{idCustomer},{amount},'{date}',{type},{price}";
                    var result = DataProvider.Instance.ExcuteNonQuery(query);
                    if (result==1)
                    {
                        MessageBox.Show("Thành công");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kiểm tra lại dữ liệu");
            }
        }

        private void bt_returnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
