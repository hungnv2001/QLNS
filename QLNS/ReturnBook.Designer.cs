namespace QLNS
{
    partial class ReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgv_bookBorrow = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            bt_Save = new Button();
            tx_namett = new TextBox();
            tx_re = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tx_sv = new TextBox();
            tx_coc = new TextBox();
            label2 = new Label();
            tx_search = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_bookBorrow).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_bookBorrow
            // 
            dtgv_bookBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_bookBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_bookBorrow.Location = new Point(12, 204);
            dtgv_bookBorrow.Name = "dtgv_bookBorrow";
            dtgv_bookBorrow.RowHeadersWidth = 51;
            dtgv_bookBorrow.RowTemplate.Height = 29;
            dtgv_bookBorrow.Size = new Size(750, 226);
            dtgv_bookBorrow.TabIndex = 0;
            dtgv_bookBorrow.CellClick += dtgv_bookBorrow_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(bt_Save);
            panel2.Controls.Add(tx_namett);
            panel2.Controls.Add(tx_re);
            panel2.Location = new Point(761, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 226);
            panel2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 8);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 16;
            label4.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 74);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 17;
            label5.Text = "Tổng trả lại:";
            // 
            // bt_Save
            // 
            bt_Save.Location = new Point(112, 160);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(106, 44);
            bt_Save.TabIndex = 15;
            bt_Save.Text = "Thanh toán";
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // tx_namett
            // 
            tx_namett.Enabled = false;
            tx_namett.Location = new Point(17, 36);
            tx_namett.Name = "tx_namett";
            tx_namett.Size = new Size(317, 27);
            tx_namett.TabIndex = 13;
            // 
            // tx_re
            // 
            tx_re.Enabled = false;
            tx_re.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tx_re.ForeColor = Color.Red;
            tx_re.Location = new Point(17, 102);
            tx_re.Name = "tx_re";
            tx_re.Size = new Size(317, 38);
            tx_re.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 456);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 17;
            label1.Text = "Tổng dịch vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 456);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 17;
            label3.Text = "Tổng cọc:";
            // 
            // tx_sv
            // 
            tx_sv.Enabled = false;
            tx_sv.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tx_sv.ForeColor = Color.Red;
            tx_sv.Location = new Point(412, 484);
            tx_sv.Name = "tx_sv";
            tx_sv.Size = new Size(317, 38);
            tx_sv.TabIndex = 14;
            // 
            // tx_coc
            // 
            tx_coc.Enabled = false;
            tx_coc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tx_coc.ForeColor = Color.Red;
            tx_coc.Location = new Point(24, 484);
            tx_coc.Name = "tx_coc";
            tx_coc.Size = new Size(317, 38);
            tx_coc.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(212, 107);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 17;
            label2.Text = "Id khách hàng:";
            // 
            // tx_search
            // 
            tx_search.Location = new Point(356, 108);
            tx_search.Name = "tx_search";
            tx_search.Size = new Size(333, 27);
            tx_search.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(739, 107);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1175, 670);
            Controls.Add(button1);
            Controls.Add(tx_search);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(dtgv_bookBorrow);
            Controls.Add(tx_coc);
            Controls.Add(tx_sv);
            Name = "ReturnBook";
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_bookBorrow).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_bookBorrow;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button bt_Save;
        private TextBox tx_namett;
        private TextBox tx_sv;
        private TextBox tx_coc;
        private Label label2;
        private TextBox tx_search;
        private Button button1;
        private Label label5;
        private TextBox tx_re;
    }
}