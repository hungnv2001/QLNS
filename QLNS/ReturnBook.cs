using QLNS.DAO; using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;  namespace QLNS {     public partial class ReturnBook : Form     {         public ReturnBook()         {             InitializeComponent();         }          private void ReturnBook_Load(object sender, EventArgs e)         {             Load_f();          }         private void Load_f()         {             string query = "exec sp_FindReturn 0";             dtgv_bookBorrow.DataSource = DataProvider.Instance.ExcuteQuery(query);             // dtgv_bookBorrow.Columns[0].Visible = false;             tx_coc.Text = "";             tx_sv.Text = "";             tx_re.Text = "";             tx_search.Text = "";          }         private void AddColum()         {             DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();             colum.HeaderText = "Số ngày";             DataGridViewTextBoxColumn colum2 = new DataGridViewTextBoxColumn();             colum2.HeaderText = "Thành tiền";             dtgv_bookBorrow.Columns.Add(colum);             dtgv_bookBorrow.Columns.Add(colum2);          }          private void button1_Click(object sender, EventArgs e)         {


            try
            {
                string query = $"exec sp_FindReturn {tx_search.Text}";
                var result = DataProvider.Instance.ExcuteQuery(query);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Khách này chưa mượn sách");
                    tx_coc.Text = "0";
                    tx_sv.Text = "0";
                    tx_re.Text = "0";
                    return;
                }
                dtgv_bookBorrow.DataSource = null;
                dtgv_bookBorrow.Columns.Clear();
                dtgv_bookBorrow.DataSource = result;
                dtgv_bookBorrow.Columns[0].Visible = false;

                AddColum();
                CountDay();
                SumTutal();
                string query2 = $"select name from customer where id={tx_search.Text}";
                tx_namett.Text = DataProvider.Instance.ExcuteQuery(query2).Rows[0]["name"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("ID khách hàng nhập bị lỗi!");
                tx_coc.Text = "0";
                tx_sv.Text = "0";
                tx_re.Text = "0";
            }         }          private void SumTutal()         {             int sumBook = 0;             int sumDes = 0;             int sum = 0;             for (int i = 0; i < dtgv_bookBorrow.Rows.Count - 1; i++)             {                 sumDes += int.Parse(dtgv_bookBorrow.Rows[i].Cells[5].Value.ToString());                 sum += int.Parse(dtgv_bookBorrow.Rows[i].Cells[8].Value.ToString());             }             tx_coc.Text = sumDes.ToString();             tx_sv.Text = sum.ToString();             tx_re.Text = (sumDes - sum).ToString();         }          private void CountDay()         {             int sum = 0;             int sumdes = 0;             for (int i = 0; i < dtgv_bookBorrow.Rows.Count - 1; i++)             {                 var result = SumDAO.Instance.CountDay(dtgv_bookBorrow.Rows[i].Cells[3].Value.ToString());                 dtgv_bookBorrow.Rows[i].Cells[7].Value = result;                 sum = int.Parse(dtgv_bookBorrow.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtgv_bookBorrow.Rows[i].Cells[7].Value.ToString());                 if (sum > int.Parse(dtgv_bookBorrow.Rows[i].Cells[5].Value.ToString()))                 {                     sum = int.Parse(dtgv_bookBorrow.Rows[i].Cells[5].Value.ToString());                 }                 dtgv_bookBorrow.Rows[i].Cells[8].Value = (sum).ToString();              }         }          private void dtgv_bookBorrow_CellClick(object sender, DataGridViewCellEventArgs e)         {              int index = dtgv_bookBorrow.CurrentRow.Index;             DataGridViewRow row = dtgv_bookBorrow.Rows[index];         }         //            private void bt_Save_Click(object sender, EventArgs e)         {             try             {                 for (int i = 0; i < dtgv_bookBorrow.Rows.Count - 1; i++)                 {                     int sum = 0;                     int sumdes = 0;                     string query = $"declare @tong int exec sp_SumDay '{dtgv_bookBorrow.Rows[i].Cells[3].Value.ToString()}' , @tong out select @tong as 'kq'";                     var result1 = int.Parse(DataProvider.Instance.ExcuteQuery(query).Rows[0]["kq"].ToString());                     sumdes = int.Parse(dtgv_bookBorrow.Rows[i].Cells[5].Value.ToString());                     sum = int.Parse(dtgv_bookBorrow.Rows[i].Cells[8].Value.ToString());                     if (sum > int.Parse(dtgv_bookBorrow.Rows[i].Cells[5].Value.ToString()))                     {                         sum = int.Parse(dtgv_bookBorrow.Rows[i].Cells[5].Value.ToString());                     }                     string id = dtgv_bookBorrow.Rows[i].Cells[0].Value.ToString();                     var result2 = (sumdes - sum);                     string query2 = $"EXEC sp_ReturnBook {id},{result1}, {result2}";                      var result3 = DataProvider.Instance.ExcuteNonQuery(query2) == 1;                 }                 MessageBox.Show("Thành công");             }             catch (Exception)             {                  MessageBox.Show("Thất bại");             }          }     } } 