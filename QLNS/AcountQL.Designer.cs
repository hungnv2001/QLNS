namespace QLNS
{
    partial class AcountQL
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
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dtgv_staff = new DataGridView();
            bt_cal = new Button();
            bt_del = new Button();
            bt_edit = new Button();
            bt_add = new Button();
            tabPage2 = new TabPage();
            bt_cancel = new Button();
            bt_save = new Button();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            tx_rePass = new TextBox();
            tx_newPass = new TextBox();
            tx_displayAD = new TextBox();
            tx_userAD = new TextBox();
            panel1 = new Panel();
            lb_user = new Label();
            label8 = new Label();
            tx_user = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tx_pass = new TextBox();
            tx_displayName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_staff).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._52092357656_07cbdfd16e_c;
            pictureBox1.Location = new Point(625, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(41, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(578, 646);
            tabControl1.TabIndex = 6;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.TabIndexChanged += tabControl1_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(dtgv_staff);
            tabPage1.Controls.Add(bt_cal);
            tabPage1.Controls.Add(bt_del);
            tabPage1.Controls.Add(bt_edit);
            tabPage1.Controls.Add(bt_add);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(570, 613);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nhân viên";
            // 
            // dtgv_staff
            // 
            dtgv_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_staff.Location = new Point(6, 156);
            dtgv_staff.Name = "dtgv_staff";
            dtgv_staff.ReadOnly = true;
            dtgv_staff.RowHeadersWidth = 51;
            dtgv_staff.RowTemplate.Height = 29;
            dtgv_staff.Size = new Size(558, 454);
            dtgv_staff.TabIndex = 3;
            dtgv_staff.CellClick += dtgv_staff_CellClick;
            // 
            // bt_cal
            // 
            bt_cal.Location = new Point(441, 43);
            bt_cal.Name = "bt_cal";
            bt_cal.Size = new Size(94, 45);
            bt_cal.TabIndex = 2;
            bt_cal.Text = "Huỷ";
            bt_cal.UseVisualStyleBackColor = true;
            bt_cal.Click += bt_cal_Click;
            // 
            // bt_del
            // 
            bt_del.Location = new Point(303, 43);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(94, 45);
            bt_del.TabIndex = 2;
            bt_del.Text = "Xoá";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(165, 43);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(94, 45);
            bt_edit.TabIndex = 1;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(27, 43);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(94, 45);
            bt_add.TabIndex = 0;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(bt_cancel);
            tabPage2.Controls.Add(bt_save);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tx_rePass);
            tabPage2.Controls.Add(tx_newPass);
            tabPage2.Controls.Add(tx_displayAD);
            tabPage2.Controls.Add(tx_userAD);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(570, 613);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bản thân";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(322, 515);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(94, 45);
            bt_cancel.TabIndex = 13;
            bt_cancel.Text = "Huỷ";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(150, 515);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(94, 45);
            bt_save.TabIndex = 12;
            bt_save.Text = "Lưu";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(87, 390);
            label4.Name = "label4";
            label4.Size = new Size(221, 28);
            label4.TabIndex = 11;
            label4.Text = "Nhập lại lại mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(87, 292);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 10;
            label5.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(87, 189);
            label7.Name = "label7";
            label7.Size = new Size(129, 28);
            label7.TabIndex = 9;
            label7.Text = "Tên hiển thị:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(88, 80);
            label6.Name = "label6";
            label6.Size = new Size(157, 28);
            label6.TabIndex = 9;
            label6.Text = "Tên đăng nhập:";
            // 
            // tx_rePass
            // 
            tx_rePass.Location = new Point(82, 430);
            tx_rePass.Name = "tx_rePass";
            tx_rePass.PasswordChar = '*';
            tx_rePass.Size = new Size(391, 27);
            tx_rePass.TabIndex = 8;
            // 
            // tx_newPass
            // 
            tx_newPass.Location = new Point(82, 331);
            tx_newPass.Name = "tx_newPass";
            tx_newPass.PasswordChar = '*';
            tx_newPass.Size = new Size(391, 27);
            tx_newPass.TabIndex = 7;
            // 
            // tx_displayAD
            // 
            tx_displayAD.Location = new Point(82, 242);
            tx_displayAD.Name = "tx_displayAD";
            tx_displayAD.Size = new Size(391, 27);
            tx_displayAD.TabIndex = 6;
            // 
            // tx_userAD
            // 
            tx_userAD.Location = new Point(83, 133);
            tx_userAD.Name = "tx_userAD";
            tx_userAD.ReadOnly = true;
            tx_userAD.Size = new Size(391, 27);
            tx_userAD.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_user);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tx_user);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tx_pass);
            panel1.Controls.Add(tx_displayName);
            panel1.Location = new Point(625, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 388);
            panel1.TabIndex = 7;
            // 
            // lb_user
            // 
            lb_user.AutoSize = true;
            lb_user.Location = new Point(282, 34);
            lb_user.Name = "lb_user";
            lb_user.Size = new Size(50, 20);
            lb_user.TabIndex = 8;
            lb_user.Text = "label3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 50);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 7;
            label8.Text = "Tên đăng nhập:";
            // 
            // tx_user
            // 
            tx_user.Location = new Point(39, 101);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(391, 27);
            tx_user.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 252);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 151);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 3;
            label1.Text = "Tên hiển thị:";
            // 
            // tx_pass
            // 
            tx_pass.Location = new Point(39, 303);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(391, 27);
            tx_pass.TabIndex = 1;
            // 
            // tx_displayName
            // 
            tx_displayName.Location = new Point(37, 202);
            tx_displayName.Name = "tx_displayName";
            tx_displayName.Size = new Size(391, 27);
            tx_displayName.TabIndex = 0;
            // 
            // AcountQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1175, 670);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "AcountQL";
            Text = "AcountQL";
            Load += AcountQL_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_staff).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dtgv_staff;
        private Button bt_cal;
        private Button bt_del;
        private Button bt_edit;
        private Button bt_add;
        private TabPage tabPage2;
        private Button bt_cancel;
        private Button bt_save;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox tx_rePass;
        private TextBox tx_newPass;
        private TextBox tx_displayAD;
        private TextBox tx_userAD;
        private Panel panel1;
        private Label label8;
        private TextBox tx_user;
        private Label label2;
        private Label label1;
        private TextBox tx_pass;
        private TextBox tx_displayName;
        private Label lb_user;
    }
}