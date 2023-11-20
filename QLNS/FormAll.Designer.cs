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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAll));
            panel1 = new Panel();
            bt_acount = new Button();
            imageList1 = new ImageList(components);
            bt_servive = new Button();
            bt_exit = new Button();
            bt_returnBook = new Button();
            bt_bookService = new Button();
            pnlBody = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_acount);
            panel1.Controls.Add(bt_servive);
            panel1.Controls.Add(bt_exit);
            panel1.Controls.Add(bt_returnBook);
            panel1.Controls.Add(bt_bookService);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 120);
            panel1.TabIndex = 2;
            // 
            // bt_acount
            // 
            bt_acount.ImageIndex = 3;
            bt_acount.ImageList = imageList1;
            bt_acount.Location = new Point(744, 12);
            bt_acount.Name = "bt_acount";
            bt_acount.Size = new Size(122, 99);
            bt_acount.TabIndex = 0;
            bt_acount.Text = "Tài khoản";
            bt_acount.TextAlign = ContentAlignment.BottomCenter;
            bt_acount.UseVisualStyleBackColor = true;
            bt_acount.Click += bt_acount_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "exit.png");
            imageList1.Images.SetKeyName(1, "guide-book.png");
            imageList1.Images.SetKeyName(2, "icons8-open-book.gif");
            imageList1.Images.SetKeyName(3, "icons8-person.gif");
            imageList1.Images.SetKeyName(4, "return (2).png");
            // 
            // bt_servive
            // 
            bt_servive.ImageIndex = 1;
            bt_servive.ImageList = imageList1;
            bt_servive.Location = new Point(42, 12);
            bt_servive.Name = "bt_servive";
            bt_servive.Size = new Size(122, 99);
            bt_servive.TabIndex = 0;
            bt_servive.Text = "Dịch vụ";
            bt_servive.TextAlign = ContentAlignment.BottomCenter;
            bt_servive.UseVisualStyleBackColor = true;
            bt_servive.Click += bt_servive_Click;
            // 
            // bt_exit
            // 
            bt_exit.ImageIndex = 0;
            bt_exit.ImageList = imageList1;
            bt_exit.Location = new Point(978, 12);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(122, 99);
            bt_exit.TabIndex = 0;
            bt_exit.Text = "Thoát";
            bt_exit.TextAlign = ContentAlignment.BottomCenter;
            bt_exit.UseVisualStyleBackColor = true;
            bt_exit.Click += bt_exit_Click;
            // 
            // bt_returnBook
            // 
            bt_returnBook.ImageIndex = 4;
            bt_returnBook.ImageList = imageList1;
            bt_returnBook.Location = new Point(276, 12);
            bt_returnBook.Name = "bt_returnBook";
            bt_returnBook.Size = new Size(122, 99);
            bt_returnBook.TabIndex = 0;
            bt_returnBook.Text = "Trả sách";
            bt_returnBook.TextAlign = ContentAlignment.BottomCenter;
            bt_returnBook.UseVisualStyleBackColor = true;
            bt_returnBook.Click += bt_returnBook_Click;
            // 
            // bt_bookService
            // 
            bt_bookService.Enabled = false;
            bt_bookService.ImageIndex = 2;
            bt_bookService.ImageList = imageList1;
            bt_bookService.Location = new Point(510, 12);
            bt_bookService.Name = "bt_bookService";
            bt_bookService.Size = new Size(122, 99);
            bt_bookService.TabIndex = 0;
            bt_bookService.Text = "Quản lý sách";
            bt_bookService.TextAlign = ContentAlignment.BottomCenter;
            bt_bookService.UseVisualStyleBackColor = true;
            bt_bookService.Click += bt_bookService_Click;
            // 
            // pnlBody
            // 
            pnlBody.Location = new Point(0, 117);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1175, 670);
            pnlBody.TabIndex = 3;
            // 
            // FormAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1175, 784);
            Controls.Add(pnlBody);
            Controls.Add(panel1);
            Name = "FormAll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà sách";
            FormClosing += FormAll_FormClosing;
            Load += FormAll_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
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