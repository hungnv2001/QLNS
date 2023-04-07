namespace QLNS
{
    partial class FormAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_acount = new System.Windows.Forms.Button();
            this.bt_servive = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_returnBook = new System.Windows.Forms.Button();
            this.bt_bookService = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_acount);
            this.panel1.Controls.Add(this.bt_servive);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_returnBook);
            this.panel1.Controls.Add(this.bt_bookService);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 120);
            this.panel1.TabIndex = 2;
            // 
            // bt_acount
            // 
            this.bt_acount.ImageIndex = 3;
            this.bt_acount.ImageList = this.imageList1;
            this.bt_acount.Location = new System.Drawing.Point(744, 12);
            this.bt_acount.Name = "bt_acount";
            this.bt_acount.Size = new System.Drawing.Size(122, 99);
            this.bt_acount.TabIndex = 0;
            this.bt_acount.Text = "Tài khoản";
            this.bt_acount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_acount.UseVisualStyleBackColor = true;
            // 
            // bt_servive
            // 
            this.bt_servive.ImageIndex = 1;
            this.bt_servive.ImageList = this.imageList1;
            this.bt_servive.Location = new System.Drawing.Point(42, 12);
            this.bt_servive.Name = "bt_servive";
            this.bt_servive.Size = new System.Drawing.Size(122, 99);
            this.bt_servive.TabIndex = 0;
            this.bt_servive.Text = "Dịch vụ";
            this.bt_servive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_servive.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.ImageIndex = 0;
            this.bt_exit.ImageList = this.imageList1;
            this.bt_exit.Location = new System.Drawing.Point(978, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(122, 99);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_exit.UseVisualStyleBackColor = true;
            // 
            // bt_returnBook
            // 
            this.bt_returnBook.ImageIndex = 4;
            this.bt_returnBook.ImageList = this.imageList1;
            this.bt_returnBook.Location = new System.Drawing.Point(276, 12);
            this.bt_returnBook.Name = "bt_returnBook";
            this.bt_returnBook.Size = new System.Drawing.Size(122, 99);
            this.bt_returnBook.TabIndex = 0;
            this.bt_returnBook.Text = "Trả sách";
            this.bt_returnBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_returnBook.UseVisualStyleBackColor = true;
            // 
            // bt_bookService
            // 
            this.bt_bookService.Enabled = false;
            this.bt_bookService.ImageIndex = 2;
            this.bt_bookService.ImageList = this.imageList1;
            this.bt_bookService.Location = new System.Drawing.Point(510, 12);
            this.bt_bookService.Name = "bt_bookService";
            this.bt_bookService.Size = new System.Drawing.Size(122, 99);
            this.bt_bookService.TabIndex = 0;
            this.bt_bookService.Text = "Quản lý sách";
            this.bt_bookService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_bookService.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exit.png");
            this.imageList1.Images.SetKeyName(1, "guide-book.png");
            this.imageList1.Images.SetKeyName(2, "icons8-open-book.gif");
            this.imageList1.Images.SetKeyName(3, "icons8-person.gif");
            this.imageList1.Images.SetKeyName(4, "return (2).png");
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(0, 117);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1175, 670);
            this.pnlBody.TabIndex = 3;
            // 
            // FormAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 784);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.Name = "FormAll";
            this.Text = "FormAll";
            this.Load += new System.EventHandler(this.FormAll_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button bt_acount;
        private Button bt_servive;
        private Button bt_exit;
        private Button bt_returnBook;
        private Button bt_bookService;
        private ImageList imageList1;
        private Panel pnlBody;
    }
}