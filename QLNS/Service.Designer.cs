namespace QLNS
{
    partial class Service
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            imageList1 = new ImageList(components);
            panel_service = new Panel();
            panel4 = new Panel();
            bt_delAll = new Button();
            bt_del = new Button();
            label2 = new Label();
            dtgv_serviceBook = new DataGridView();
            panel3 = new Panel();
            label5 = new Label();
            id_cusment = new TextBox();
            bt_searchCusment = new Button();
            tx_nameCusment = new TextBox();
            bt_createCusment = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            bt_tutal = new Button();
            label3 = new Label();
            bt_Save = new Button();
            tx_namett = new TextBox();
            tx_sum = new TextBox();
            grb_power = new GroupBox();
            lb_name = new Label();
            bt_addBook = new Button();
            dtgv_book = new DataGridView();
            tx_search = new TextBox();
            bindingSource1 = new BindingSource(components);
            panel_service.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_serviceBook).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            grb_power.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_book).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-home-page.gif");
            imageList1.Images.SetKeyName(1, "icons8-open-book.gif");
            imageList1.Images.SetKeyName(2, "icons8-person.gif");
            imageList1.Images.SetKeyName(3, "icons8-person.gif");
            imageList1.Images.SetKeyName(4, "return (2).png");
            imageList1.Images.SetKeyName(5, "exit.png");
            imageList1.Images.SetKeyName(6, "guide-book.png");
            // 
            // panel_service
            // 
            panel_service.BackColor = SystemColors.ActiveCaption;
            panel_service.Controls.Add(panel4);
            panel_service.Controls.Add(panel3);
            panel_service.Controls.Add(panel2);
            panel_service.Controls.Add(grb_power);
            panel_service.Controls.Add(bt_addBook);
            panel_service.Controls.Add(dtgv_book);
            panel_service.Controls.Add(tx_search);
            panel_service.Dock = DockStyle.Fill;
            panel_service.Location = new Point(0, 0);
            panel_service.Name = "panel_service";
            panel_service.Size = new Size(1175, 670);
            panel_service.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(bt_delAll);
            panel4.Controls.Add(bt_del);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dtgv_serviceBook);
            panel4.Location = new Point(3, 370);
            panel4.Name = "panel4";
            panel4.Size = new Size(718, 278);
            panel4.TabIndex = 18;
            // 
            // bt_delAll
            // 
            bt_delAll.Location = new Point(555, 7);
            bt_delAll.Name = "bt_delAll";
            bt_delAll.Size = new Size(94, 29);
            bt_delAll.TabIndex = 25;
            bt_delAll.Text = "Xoá hết";
            bt_delAll.UseVisualStyleBackColor = true;
            bt_delAll.Click += bt_delAll_Click;
            // 
            // bt_del
            // 
            bt_del.Location = new Point(430, 5);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(86, 30);
            bt_del.TabIndex = 24;
            bt_del.Text = "Xoá bớt";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 4);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 23;
            label2.Text = "Danh sách đã chọn";
            // 
            // dtgv_serviceBook
            // 
            dtgv_serviceBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_serviceBook.Location = new Point(37, 42);
            dtgv_serviceBook.Name = "dtgv_serviceBook";
            dtgv_serviceBook.RowHeadersWidth = 51;
            dtgv_serviceBook.RowTemplate.Height = 29;
            dtgv_serviceBook.Size = new Size(658, 213);
            dtgv_serviceBook.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(id_cusment);
            panel3.Controls.Add(bt_searchCusment);
            panel3.Controls.Add(tx_nameCusment);
            panel3.Controls.Add(bt_createCusment);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(720, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(418, 242);
            panel3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 17);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 17;
            label5.Text = "Thông tin khách hàng";
            // 
            // id_cusment
            // 
            id_cusment.Location = new Point(22, 50);
            id_cusment.Name = "id_cusment";
            id_cusment.PlaceholderText = "Id khách hàng";
            id_cusment.Size = new Size(118, 27);
            id_cusment.TabIndex = 0;
            // 
            // bt_searchCusment
            // 
            bt_searchCusment.Location = new Point(178, 50);
            bt_searchCusment.Name = "bt_searchCusment";
            bt_searchCusment.Size = new Size(104, 29);
            bt_searchCusment.TabIndex = 16;
            bt_searchCusment.Text = "Tìm";
            bt_searchCusment.UseVisualStyleBackColor = true;
            bt_searchCusment.Click += bt_searchCusment_Click;
            // 
            // tx_nameCusment
            // 
            tx_nameCusment.Enabled = false;
            tx_nameCusment.Location = new Point(58, 103);
            tx_nameCusment.Name = "tx_nameCusment";
            tx_nameCusment.Size = new Size(214, 27);
            tx_nameCusment.TabIndex = 1;
            // 
            // bt_createCusment
            // 
            bt_createCusment.BackColor = SystemColors.ActiveCaption;
            bt_createCusment.Location = new Point(301, 50);
            bt_createCusment.Name = "bt_createCusment";
            bt_createCusment.Size = new Size(90, 80);
            bt_createCusment.TabIndex = 11;
            bt_createCusment.Text = "Tạo thẻ   hội viên";
            bt_createCusment.UseVisualStyleBackColor = false;
            bt_createCusment.Click += bt_createCusment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 110);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(bt_tutal);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(bt_Save);
            panel2.Controls.Add(tx_namett);
            panel2.Controls.Add(tx_sum);
            panel2.Location = new Point(720, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 342);
            panel2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 90);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 16;
            label4.Text = "Tên khách hàng:";
            // 
            // bt_tutal
            // 
            bt_tutal.Location = new Point(58, 275);
            bt_tutal.Name = "bt_tutal";
            bt_tutal.Size = new Size(98, 44);
            bt_tutal.TabIndex = 25;
            bt_tutal.Text = "Tính tiền";
            bt_tutal.UseVisualStyleBackColor = true;
            bt_tutal.Click += bt_tutal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 178);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 17;
            label3.Text = "Tổng tiền:";
            // 
            // bt_Save
            // 
            bt_Save.Location = new Point(244, 275);
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
            tx_namett.Location = new Point(41, 126);
            tx_namett.Name = "tx_namett";
            tx_namett.Size = new Size(317, 27);
            tx_namett.TabIndex = 13;
            // 
            // tx_sum
            // 
            tx_sum.Enabled = false;
            tx_sum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tx_sum.ForeColor = Color.Red;
            tx_sum.Location = new Point(42, 205);
            tx_sum.Name = "tx_sum";
            tx_sum.Size = new Size(317, 38);
            tx_sum.TabIndex = 14;
            tx_sum.TextChanged += tx_sum_TextChanged;
            // 
            // grb_power
            // 
            grb_power.Controls.Add(lb_name);
            grb_power.Location = new Point(868, 28);
            grb_power.Name = "grb_power";
            grb_power.Size = new Size(270, 55);
            grb_power.TabIndex = 13;
            grb_power.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.Location = new Point(47, 24);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(63, 25);
            lb_name.TabIndex = 0;
            lb_name.Text = "label5";
            // 
            // bt_addBook
            // 
            bt_addBook.Location = new Point(605, 58);
            bt_addBook.Name = "bt_addBook";
            bt_addBook.Size = new Size(94, 27);
            bt_addBook.TabIndex = 8;
            bt_addBook.Text = "Thêm";
            bt_addBook.UseVisualStyleBackColor = true;
            bt_addBook.Click += bt_addBook_Click;
            // 
            // dtgv_book
            // 
            dtgv_book.AllowUserToAddRows = false;
            dtgv_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_book.Location = new Point(41, 132);
            dtgv_book.Name = "dtgv_book";
            dtgv_book.RowHeadersWidth = 51;
            dtgv_book.RowTemplate.Height = 29;
            dtgv_book.Size = new Size(662, 216);
            dtgv_book.TabIndex = 6;
            // 
            // tx_search
            // 
            tx_search.BackColor = Color.WhiteSmoke;
            tx_search.Location = new Point(40, 59);
            tx_search.Name = "tx_search";
            tx_search.PlaceholderText = "Nhập tên sách hoặc tác giả...";
            tx_search.ScrollBars = ScrollBars.Both;
            tx_search.Size = new Size(507, 27);
            tx_search.TabIndex = 2;
            tx_search.TextChanged += tx_search_TextChanged;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1175, 670);
            Controls.Add(panel_service);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Service";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service";
            Load += Service_Load;
            panel_service.ResumeLayout(false);
            panel_service.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_serviceBook).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            grb_power.ResumeLayout(false);
            grb_power.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_book).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Panel panel_service;
        private Button bt_addBook;
        private DataGridView dtgv_book;
        private Label label1;
        private TextBox tx_search;
        private TextBox tx_nameCusment;
        private TextBox id_cusment;
        private Button bt_createCusment;
        private GroupBox grb_power;
        private Label lb_name;
        private BindingSource bindingSource1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Button bt_Save;
        private TextBox tx_namett;
        private TextBox tx_sum;
        private Button bt_searchCusment;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Button bt_del;
        private Button bt_tutal;
        private Label label2;
        private DataGridView dtgv_serviceBook;
        private Button bt_delAll;
    }
}