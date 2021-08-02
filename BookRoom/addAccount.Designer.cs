
namespace BookRoom
{
    partial class addAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTentaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaxacnhan = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // tbxTentaikhoan
            // 
            this.tbxTentaikhoan.Location = new System.Drawing.Point(221, 41);
            this.tbxTentaikhoan.Name = "tbxTentaikhoan";
            this.tbxTentaikhoan.Size = new System.Drawing.Size(199, 22);
            this.tbxTentaikhoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khảu:";
            // 
            // tbxMatkhau
            // 
            this.tbxMatkhau.Location = new System.Drawing.Point(221, 98);
            this.tbxMatkhau.Name = "tbxMatkhau";
            this.tbxMatkhau.PasswordChar = '*';
            this.tbxMatkhau.Size = new System.Drawing.Size(199, 22);
            this.tbxMatkhau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã xác nhận:";
            // 
            // tbxMaxacnhan
            // 
            this.tbxMaxacnhan.Location = new System.Drawing.Point(221, 278);
            this.tbxMaxacnhan.Name = "tbxMaxacnhan";
            this.tbxMaxacnhan.Size = new System.Drawing.Size(199, 22);
            this.tbxMaxacnhan.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.Image")));
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(199, 415);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(143, 47);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ Và Tên:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(221, 155);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(199, 22);
            this.tbxName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(221, 217);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(199, 22);
            this.tbxEmail.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.tbxTentaikhoan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.tbxMatkhau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxMaxacnhan);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 335);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(151, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thêm tài khoản";
            // 
            // addAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(525, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "addAccount";
            this.Text = "addAccount";
            this.Load += new System.EventHandler(this.addAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTentaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaxacnhan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}