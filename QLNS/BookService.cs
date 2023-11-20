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
    public partial class BookService : Form
    {
        public BookService()
        {
            InitializeComponent();
        }
        string _query = @"select ID, name as N'Tên sách', author as N'Tác giả', bookLoan as N'Giá mượn/ngày', bookPrice as N'Giá bán', totalQuantity as N'Tổng số', actualQuantity as N'Thực tế', type as N'Loại sách' from book where id not in (select ID from book where (hide like 1))";
        public void LoadBook(string query)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dtgv_customer.DataSource = data;
            dtgv_customer.Columns[0].Visible = false;
            dtgv_customer.Columns[1].Width = 250;
            dtgv_customer.Columns[7].Width = 200;
        }

        private void BookService_Load(object sender, EventArgs e)
        {
            LoadBook(_query);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int index = dtgv_customer.CurrentRow.Index;
            DataGridViewRow row = dtgv_customer.Rows[index];
            string ID = row.Cells[0].Value.ToString();
            string query = $"Update book set hide = 1 where ID = {Convert.ToInt32(ID)}";
            DataProvider.Instance.ExcuteNonQuery(query);
            LoadBook(_query);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int index = dtgv_customer.CurrentRow.Index;
            string name = dtgv_customer.Rows[index].Cells[1].Value.ToString();
            string author = dtgv_customer.Rows[index].Cells[2].Value.ToString();
            string bookLoan = dtgv_customer.Rows[index].Cells[3].Value.ToString();
            string bookPrice = dtgv_customer.Rows[index].Cells[4].Value.ToString();
            string totalQuantity = dtgv_customer.Rows[index].Cells[5].Value.ToString();
            string actualQuantity = dtgv_customer.Rows[index].Cells[6].Value.ToString();
            string type = dtgv_customer.Rows[index].Cells[7].Value.ToString();
            string query = $"insert into book(name, author, bookLoan, bookPrice, totalQuantity, actualQuantity, type) values(N'{name}',N'{author}',{Convert.ToInt32(bookLoan)},{Convert.ToInt32(bookPrice)},{Convert.ToInt32(totalQuantity)},{Convert.ToInt32(actualQuantity)},N'{type}')";
            DataProvider.Instance.ExcuteNonQuery(query);
            LoadBook(_query);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int index = dtgv_customer.CurrentRow.Index;
            DataGridViewRow row = dtgv_customer.Rows[index];
            string ID = row.Cells[0].Value.ToString();
            string name = dtgv_customer.Rows[index].Cells[1].Value.ToString();
            string author = dtgv_customer.Rows[index].Cells[2].Value.ToString();
            string bookLoan = dtgv_customer.Rows[index].Cells[3].Value.ToString();
            string bookPrice = dtgv_customer.Rows[index].Cells[4].Value.ToString();
            string totalQuantity = dtgv_customer.Rows[index].Cells[5].Value.ToString();
            string actualQuantity = dtgv_customer.Rows[index].Cells[6].Value.ToString();
            string type = dtgv_customer.Rows[index].Cells[7].Value.ToString();
            string query = $"update book set name = N'{name}', author = N'{author}', bookLoan = {Convert.ToInt32(bookLoan)}, bookPrice = {Convert.ToInt32(bookPrice)}, totalQuantity = {Convert.ToInt32(totalQuantity)}, actualQuantity = {Convert.ToInt32(actualQuantity)}, type = N'{type}' where ID = {Convert.ToInt32(ID)}";
            DataProvider.Instance.ExcuteNonQuery(query);
            LoadBook(_query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = $"select ID, name, author, bookLoan, bookPrice, totalQuantity, actualQuantity, type from book where name like N'%{txtSearch.Text.ToLower()}%' and ID not in (select ID from book where (hide like 1))";
            LoadBook(query);
        }
    }
}
