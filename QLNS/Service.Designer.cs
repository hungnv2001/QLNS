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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_service = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_delAll = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_serviceBook = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.id_cusment = new System.Windows.Forms.TextBox();
            this.bt_searchCusment = new System.Windows.Forms.Button();
            this.tx_nameCusment = new System.Windows.Forms.TextBox();
            this.bt_createCusment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_tutal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.tx_namett = new System.Windows.Forms.TextBox();
            this.tx_sum = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.grb_power = new System.Windows.Forms.GroupBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.bt_addBook = new System.Windows.Forms.Button();
            this.dtgv_book = new System.Windows.Forms.DataGridView();
            this.tx_search = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel_service.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_serviceBook)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grb_power.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-page.gif");
            this.imageList1.Images.SetKeyName(1, "icons8-open-book.gif");
            this.imageList1.Images.SetKeyName(2, "icons8-person.gif");
            this.imageList1.Images.SetKeyName(3, "icons8-person.gif");
            this.imageList1.Images.SetKeyName(4, "return (2).png");
            this.imageList1.Images.SetKeyName(5, "exit.png");
            this.imageList1.Images.SetKeyName(6, "guide-book.png");
            // 
            // panel_service
            // 
            this.panel_service.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_service.Controls.Add(this.panel4);
            this.panel_service.Controls.Add(this.panel3);
            this.panel_service.Controls.Add(this.panel2);
            this.panel_service.Controls.Add(this.bt_search);
            this.panel_service.Controls.Add(this.grb_power);
            this.panel_service.Controls.Add(this.bt_addBook);
            this.panel_service.Controls.Add(this.dtgv_book);
            this.panel_service.Controls.Add(this.tx_search);
            this.panel_service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_service.Location = new System.Drawing.Point(0, 0);
            this.panel_service.Name = "panel_service";
            this.panel_service.Size = new System.Drawing.Size(1175, 670);
            this.panel_service.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.bt_delAll);
            this.panel4.Controls.Add(this.bt_del);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtgv_serviceBook);
            this.panel4.Location = new System.Drawing.Point(3, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 278);
            this.panel4.TabIndex = 18;
            // 
            // bt_delAll
            // 
            this.bt_delAll.Location = new System.Drawing.Point(555, 7);
            this.bt_delAll.Name = "bt_delAll";
            this.bt_delAll.Size = new System.Drawing.Size(94, 29);
            this.bt_delAll.TabIndex = 25;
            this.bt_delAll.Text = "Xoá hết";
            this.bt_delAll.UseVisualStyleBackColor = true;
            this.bt_delAll.Click += new System.EventHandler(this.bt_delAll_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(430, 5);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(86, 30);
            this.bt_del.TabIndex = 24;
            this.bt_del.Text = "Xoá bớt";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Danh sách đã chọn";
            // 
            // dtgv_serviceBook
            // 
            this.dtgv_serviceBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_serviceBook.Location = new System.Drawing.Point(37, 42);
            this.dtgv_serviceBook.Name = "dtgv_serviceBook";
            this.dtgv_serviceBook.RowHeadersWidth = 51;
            this.dtgv_serviceBook.RowTemplate.Height = 29;
            this.dtgv_serviceBook.Size = new System.Drawing.Size(658, 213);
            this.dtgv_serviceBook.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.id_cusment);
            this.panel3.Controls.Add(this.bt_searchCusment);
            this.panel3.Controls.Add(this.tx_nameCusment);
            this.panel3.Controls.Add(this.bt_createCusment);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(720, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 242);
            this.panel3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Thông tin khách hàng";
            // 
            // id_cusment
            // 
            this.id_cusment.Location = new System.Drawing.Point(22, 50);
            this.id_cusment.Name = "id_cusment";
            this.id_cusment.PlaceholderText = "Id khách hàng";
            this.id_cusment.Size = new System.Drawing.Size(118, 27);
            this.id_cusment.TabIndex = 0;
            // 
            // bt_searchCusment
            // 
            this.bt_searchCusment.Location = new System.Drawing.Point(178, 50);
            this.bt_searchCusment.Name = "bt_searchCusment";
            this.bt_searchCusment.Size = new System.Drawing.Size(104, 29);
            this.bt_searchCusment.TabIndex = 16;
            this.bt_searchCusment.Text = "Tìm";
            this.bt_searchCusment.UseVisualStyleBackColor = true;
            this.bt_searchCusment.Click += new System.EventHandler(this.bt_searchCusment_Click);
            // 
            // tx_nameCusment
            // 
            this.tx_nameCusment.Enabled = false;
            this.tx_nameCusment.Location = new System.Drawing.Point(58, 103);
            this.tx_nameCusment.Name = "tx_nameCusment";
            this.tx_nameCusment.Size = new System.Drawing.Size(214, 27);
            this.tx_nameCusment.TabIndex = 1;
            // 
            // bt_createCusment
            // 
            this.bt_createCusment.Location = new System.Drawing.Point(301, 50);
            this.bt_createCusment.Name = "bt_createCusment";
            this.bt_createCusment.Size = new System.Drawing.Size(90, 80);
            this.bt_createCusment.TabIndex = 11;
            this.bt_createCusment.Text = "Tạo thẻ   hội viên";
            this.bt_createCusment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bt_tutal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Controls.Add(this.tx_namett);
            this.panel2.Controls.Add(this.tx_sum);
            this.panel2.Location = new System.Drawing.Point(720, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 342);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên khách hàng:";
            // 
            // bt_tutal
            // 
            this.bt_tutal.Location = new System.Drawing.Point(58, 275);
            this.bt_tutal.Name = "bt_tutal";
            this.bt_tutal.Size = new System.Drawing.Size(98, 44);
            this.bt_tutal.TabIndex = 25;
            this.bt_tutal.Text = "Tính tiền";
            this.bt_tutal.UseVisualStyleBackColor = true;
            this.bt_tutal.Click += new System.EventHandler(this.bt_tutal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền:";
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(244, 275);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(106, 44);
            this.bt_Save.TabIndex = 15;
            this.bt_Save.Text = "Thanh toán";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // tx_namett
            // 
            this.tx_namett.Enabled = false;
            this.tx_namett.Location = new System.Drawing.Point(41, 126);
            this.tx_namett.Name = "tx_namett";
            this.tx_namett.Size = new System.Drawing.Size(317, 27);
            this.tx_namett.TabIndex = 13;
            // 
            // tx_sum
            // 
            this.tx_sum.Enabled = false;
            this.tx_sum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tx_sum.ForeColor = System.Drawing.Color.Red;
            this.tx_sum.Location = new System.Drawing.Point(42, 205);
            this.tx_sum.Name = "tx_sum";
            this.tx_sum.Size = new System.Drawing.Size(317, 38);
            this.tx_sum.TabIndex = 14;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(479, 56);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(94, 29);
            this.bt_search.TabIndex = 14;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_seach_Click);
            // 
            // grb_power
            // 
            this.grb_power.Controls.Add(this.lb_name);
            this.grb_power.Location = new System.Drawing.Point(868, 28);
            this.grb_power.Name = "grb_power";
            this.grb_power.Size = new System.Drawing.Size(270, 55);
            this.grb_power.TabIndex = 13;
            this.grb_power.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(47, 24);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "label5";
            // 
            // bt_addBook
            // 
            this.bt_addBook.Location = new System.Drawing.Point(605, 58);
            this.bt_addBook.Name = "bt_addBook";
            this.bt_addBook.Size = new System.Drawing.Size(94, 27);
            this.bt_addBook.TabIndex = 8;
            this.bt_addBook.Text = "Thêm";
            this.bt_addBook.UseVisualStyleBackColor = true;
            this.bt_addBook.Click += new System.EventHandler(this.bt_addBook_Click);
            // 
            // dtgv_book
            // 
            this.dtgv_book.AllowUserToAddRows = false;
            this.dtgv_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_book.Location = new System.Drawing.Point(41, 132);
            this.dtgv_book.Name = "dtgv_book";
            this.dtgv_book.RowHeadersWidth = 51;
            this.dtgv_book.RowTemplate.Height = 29;
            this.dtgv_book.Size = new System.Drawing.Size(662, 216);
            this.dtgv_book.TabIndex = 6;
            // 
            // tx_search
            // 
            this.tx_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_search.Location = new System.Drawing.Point(40, 56);
            this.tx_search.Name = "tx_search";
            this.tx_search.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tx_search.Size = new System.Drawing.Size(404, 27);
            this.tx_search.TabIndex = 2;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1175, 670);
            this.Controls.Add(this.panel_service);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel_service.ResumeLayout(false);
            this.panel_service.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_serviceBook)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grb_power.ResumeLayout(false);
            this.grb_power.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

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
        private Button bt_search;
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