namespace HotelAssignment
{
    partial class ChangePasswordForm
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
            this.change_pwd_pnl = new System.Windows.Forms.Panel();
            this.new_pwd_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_new_pwd_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.change_pwd_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // change_pwd_pnl
            // 
            this.change_pwd_pnl.Controls.Add(this.new_pwd_txt);
            this.change_pwd_pnl.Controls.Add(this.label4);
            this.change_pwd_pnl.Controls.Add(this.confirm_new_pwd_txt);
            this.change_pwd_pnl.Controls.Add(this.label2);
            this.change_pwd_pnl.Controls.Add(this.label3);
            this.change_pwd_pnl.Controls.Add(this.login_btn);
            this.change_pwd_pnl.Controls.Add(this.label1);
            this.change_pwd_pnl.Location = new System.Drawing.Point(200, 73);
            this.change_pwd_pnl.Name = "change_pwd_pnl";
            this.change_pwd_pnl.Size = new System.Drawing.Size(511, 449);
            this.change_pwd_pnl.TabIndex = 5;
            // 
            // new_pwd_txt
            // 
            this.new_pwd_txt.Location = new System.Drawing.Point(6, 194);
            this.new_pwd_txt.Name = "new_pwd_txt";
            this.new_pwd_txt.Size = new System.Drawing.Size(484, 31);
            this.new_pwd_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(-3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 73);
            this.label4.TabIndex = 4;
            this.label4.Text = "You will not be able to reset your password, memorize it very well";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // confirm_new_pwd_txt
            // 
            this.confirm_new_pwd_txt.Location = new System.Drawing.Point(6, 296);
            this.confirm_new_pwd_txt.Name = "confirm_new_pwd_txt";
            this.confirm_new_pwd_txt.Size = new System.Drawing.Size(484, 31);
            this.confirm_new_pwd_txt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change Your Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(6, 381);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(484, 65);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 596);
            this.Controls.Add(this.change_pwd_pnl);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.change_pwd_pnl.ResumeLayout(false);
            this.change_pwd_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel change_pwd_pnl;
        private System.Windows.Forms.TextBox new_pwd_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirm_new_pwd_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
    }
}