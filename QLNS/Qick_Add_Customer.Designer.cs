namespace QLNS
{
    partial class Qick_Add_Customer
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
            label1 = new Label();
            tx_name = new TextBox();
            tx_phoneNum = new TextBox();
            tx_email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_save = new Button();
            bt_cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 44);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Tạo thẻ hội viên";
            // 
            // tx_name
            // 
            tx_name.Location = new Point(68, 175);
            tx_name.Name = "tx_name";
            tx_name.Size = new Size(306, 27);
            tx_name.TabIndex = 1;
            // 
            // tx_phoneNum
            // 
            tx_phoneNum.Location = new Point(68, 270);
            tx_phoneNum.Name = "tx_phoneNum";
            tx_phoneNum.Size = new Size(306, 27);
            tx_phoneNum.TabIndex = 2;
            // 
            // tx_email
            // 
            tx_email.Location = new Point(68, 365);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(306, 27);
            tx_email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 131);
            label2.Name = "label2";
            label2.Size = new Size(154, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 226);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(68, 321);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // bt_save
            // 
            bt_save.Location = new Point(100, 444);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(94, 29);
            bt_save.TabIndex = 4;
            bt_save.Text = "Lưu";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(244, 444);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(94, 29);
            bt_cancel.TabIndex = 5;
            bt_cancel.Text = "Huỷ";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // Qick_Add_Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(487, 516);
            Controls.Add(bt_cancel);
            Controls.Add(bt_save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tx_email);
            Controls.Add(tx_phoneNum);
            Controls.Add(tx_name);
            Controls.Add(label1);
            Name = "Qick_Add_Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Qick_Add_Customer";
            Load += Qick_Add_Customer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_name;
        private TextBox tx_phoneNum;
        private TextBox tx_email;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_save;
        private Button bt_cancel;
    }
}