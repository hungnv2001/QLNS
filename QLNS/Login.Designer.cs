namespace QLNS
{
    partial class Login
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
            panel1 = new Panel();
            bt_exit = new Button();
            bt_login = new Button();
            tx_pass = new TextBox();
            tx_user = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_exit);
            panel1.Controls.Add(bt_login);
            panel1.Controls.Add(tx_pass);
            panel1.Controls.Add(tx_user);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 317);
            panel1.TabIndex = 0;
            // 
            // bt_exit
            // 
            bt_exit.Location = new Point(456, 234);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(94, 29);
            bt_exit.TabIndex = 4;
            bt_exit.Text = "Thoát";
            bt_exit.UseVisualStyleBackColor = true;
            bt_exit.Click += bt_exit_Click;
            // 
            // bt_login
            // 
            bt_login.Location = new Point(338, 234);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(94, 29);
            bt_login.TabIndex = 3;
            bt_login.Text = "Đăng nhập";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // tx_pass
            // 
            tx_pass.Location = new Point(289, 157);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(244, 27);
            tx_pass.TabIndex = 2;
            tx_pass.Text = "1";
            tx_pass.UseSystemPasswordChar = true;
            // 
            // tx_user
            // 
            tx_user.Location = new Point(289, 95);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(249, 27);
            tx_user.TabIndex = 1;
            tx_user.Text = "hungnv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 157);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 21);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(641, 317);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_exit;
        private Button bt_login;
        private TextBox tx_pass;
        private TextBox tx_user;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}