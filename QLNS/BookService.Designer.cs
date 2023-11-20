namespace QLNS
{
    partial class BookService
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
            dtgv_customer = new DataGridView();
            label1 = new Label();
            bt_delete = new Button();
            bt_edit = new Button();
            bt_add = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_customer).BeginInit();
            SuspendLayout();
            // 
            // dtgv_customer
            // 
            dtgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_customer.Location = new Point(12, 238);
            dtgv_customer.Name = "dtgv_customer";
            dtgv_customer.RowHeadersWidth = 51;
            dtgv_customer.RowTemplate.Height = 29;
            dtgv_customer.Size = new Size(1151, 420);
            dtgv_customer.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(799, 140);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 5;
            label1.Text = "Tìm sách";
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(433, 121);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(94, 45);
            bt_delete.TabIndex = 9;
            bt_delete.Text = "Xoá";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(266, 121);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(94, 45);
            bt_edit.TabIndex = 7;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(71, 121);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 45);
            bt_add.TabIndex = 6;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(923, 139);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sách";
            txtSearch.Size = new Size(227, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // BookService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1175, 670);
            Controls.Add(txtSearch);
            Controls.Add(bt_delete);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(label1);
            Controls.Add(dtgv_customer);
            Name = "BookService";
            Text = "BookService";
            Load += BookService_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_customer;
        private Label label1;
        private Button bt_delete;
        private Button bt_edit;
        private Button bt_add;
        private TextBox txtSearch;
    }
}