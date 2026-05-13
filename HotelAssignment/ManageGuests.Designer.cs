namespace HotelAssignment
{
    partial class ManageGuests
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
            this.guests_pnl = new System.Windows.Forms.Panel();
            this.guests_dgv = new System.Windows.Forms.DataGridView();
            this.action_buttons_pnl = new System.Windows.Forms.Panel();
            this.add_guest_btn = new System.Windows.Forms.Button();
            this.delete_guest_btn = new System.Windows.Forms.Button();
            this.refresh_guest_btn = new System.Windows.Forms.Button();
            this.guest_fields_pnl = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label_first_name = new System.Windows.Forms.Label();
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.label_last_name = new System.Windows.Forms.Label();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guests_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guests_dgv)).BeginInit();
            this.action_buttons_pnl.SuspendLayout();
            this.guest_fields_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // guests_pnl
            // 
            this.guests_pnl.Controls.Add(this.guests_dgv);
            this.guests_pnl.Controls.Add(this.action_buttons_pnl);
            this.guests_pnl.Controls.Add(this.guest_fields_pnl);
            this.guests_pnl.Controls.Add(this.header_pnl);
            this.guests_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guests_pnl.Location = new System.Drawing.Point(0, 0);
            this.guests_pnl.Name = "guests_pnl";
            this.guests_pnl.Size = new System.Drawing.Size(1200, 757);
            this.guests_pnl.TabIndex = 0;
            // 
            // guests_dgv
            // 
            this.guests_dgv.AllowUserToAddRows = false;
            this.guests_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guests_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guests_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guests_dgv.Location = new System.Drawing.Point(0, 358);
            this.guests_dgv.MultiSelect = false;
            this.guests_dgv.Name = "guests_dgv";
            this.guests_dgv.ReadOnly = true;
            this.guests_dgv.RowHeadersWidth = 62;
            this.guests_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guests_dgv.Size = new System.Drawing.Size(1200, 334);
            this.guests_dgv.TabIndex = 0;
            this.guests_dgv.SelectionChanged += new System.EventHandler(this.guests_dgv_SelectionChanged);
            // 
            // action_buttons_pnl
            // 
            this.action_buttons_pnl.Controls.Add(this.add_guest_btn);
            this.action_buttons_pnl.Controls.Add(this.delete_guest_btn);
            this.action_buttons_pnl.Controls.Add(this.refresh_guest_btn);
            this.action_buttons_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.action_buttons_pnl.Location = new System.Drawing.Point(0, 692);
            this.action_buttons_pnl.Name = "action_buttons_pnl";
            this.action_buttons_pnl.Padding = new System.Windows.Forms.Padding(12, 6, 12, 10);
            this.action_buttons_pnl.Size = new System.Drawing.Size(1200, 65);
            this.action_buttons_pnl.TabIndex = 2;
            // 
            // add_guest_btn
            // 
            this.add_guest_btn.Location = new System.Drawing.Point(44, 8);
            this.add_guest_btn.Name = "add_guest_btn";
            this.add_guest_btn.Size = new System.Drawing.Size(213, 47);
            this.add_guest_btn.TabIndex = 7;
            this.add_guest_btn.Text = "Add";
            this.add_guest_btn.UseVisualStyleBackColor = true;
            this.add_guest_btn.Click += new System.EventHandler(this.add_guest_btn_Click);
            // 
            // delete_guest_btn
            // 
            this.delete_guest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_guest_btn.ForeColor = System.Drawing.Color.Red;
            this.delete_guest_btn.Location = new System.Drawing.Point(1024, 8);
            this.delete_guest_btn.Name = "delete_guest_btn";
            this.delete_guest_btn.Size = new System.Drawing.Size(130, 47);
            this.delete_guest_btn.TabIndex = 9;
            this.delete_guest_btn.Text = "Delete";
            this.delete_guest_btn.UseVisualStyleBackColor = true;
            this.delete_guest_btn.Click += new System.EventHandler(this.delete_guest_btn_Click);
            // 
            // refresh_guest_btn
            // 
            this.refresh_guest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_guest_btn.Location = new System.Drawing.Point(797, 7);
            this.refresh_guest_btn.Name = "refresh_guest_btn";
            this.refresh_guest_btn.Size = new System.Drawing.Size(213, 47);
            this.refresh_guest_btn.TabIndex = 8;
            this.refresh_guest_btn.Text = "Refresh";
            this.refresh_guest_btn.UseVisualStyleBackColor = true;
            this.refresh_guest_btn.Click += new System.EventHandler(this.refresh_guest_btn_Click);
            // 
            // guest_fields_pnl
            // 
            this.guest_fields_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.guest_fields_pnl.Controls.Add(this.save_btn);
            this.guest_fields_pnl.Controls.Add(this.clear_btn);
            this.guest_fields_pnl.Controls.Add(this.label_first_name);
            this.guest_fields_pnl.Controls.Add(this.first_name_txt);
            this.guest_fields_pnl.Controls.Add(this.label_last_name);
            this.guest_fields_pnl.Controls.Add(this.last_name_txt);
            this.guest_fields_pnl.Controls.Add(this.label_phone);
            this.guest_fields_pnl.Controls.Add(this.phone_txt);
            this.guest_fields_pnl.Controls.Add(this.label_email);
            this.guest_fields_pnl.Controls.Add(this.email_txt);
            this.guest_fields_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.guest_fields_pnl.Location = new System.Drawing.Point(0, 79);
            this.guest_fields_pnl.Name = "guest_fields_pnl";
            this.guest_fields_pnl.Padding = new System.Windows.Forms.Padding(12, 8, 12, 10);
            this.guest_fields_pnl.Size = new System.Drawing.Size(1200, 279);
            this.guest_fields_pnl.TabIndex = 1;
            this.guest_fields_pnl.Visible = false;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(44, 181);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(211, 58);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.ForeColor = System.Drawing.Color.Red;
            this.clear_btn.Location = new System.Drawing.Point(277, 181);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(91, 58);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.add_guest_btn_Click);
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Location = new System.Drawing.Point(47, 27);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(133, 25);
            this.label_first_name.TabIndex = 0;
            this.label_first_name.Text = "First name *:";
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(44, 55);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(397, 31);
            this.first_name_txt.TabIndex = 1;
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Location = new System.Drawing.Point(462, 24);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(132, 25);
            this.label_last_name.TabIndex = 0;
            this.label_last_name.Text = "Last name *:";
            // 
            // last_name_txt
            // 
            this.last_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.last_name_txt.Location = new System.Drawing.Point(467, 55);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(597, 31);
            this.last_name_txt.TabIndex = 2;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(44, 100);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(80, 25);
            this.label_phone.TabIndex = 0;
            this.label_phone.Text = "Phone:";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(44, 133);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(397, 31);
            this.phone_txt.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(462, 100);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(71, 25);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Email:";
            // 
            // email_txt
            // 
            this.email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_txt.Location = new System.Drawing.Point(467, 133);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(597, 31);
            this.email_txt.TabIndex = 4;
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.search_btn);
            this.header_pnl.Controls.Add(this.search_txt);
            this.header_pnl.Controls.Add(this.search_lbl);
            this.header_pnl.Controls.Add(this.back_btn);
            this.header_pnl.Controls.Add(this.label3);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(0, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.header_pnl.Size = new System.Drawing.Size(1200, 79);
            this.header_pnl.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Location = new System.Drawing.Point(1096, 18);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(92, 39);
            this.search_btn.TabIndex = 13;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Location = new System.Drawing.Point(848, 22);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(230, 31);
            this.search_txt.TabIndex = 12;
            this.search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_txt_KeyDown);
            // 
            // search_lbl
            // 
            this.search_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(766, 25);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(80, 25);
            this.search_lbl.TabIndex = 0;
            this.search_lbl.Text = "Search:";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(52, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 39);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Guests";
            // 
            // ManageGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.guests_pnl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ManageGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guests";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.guests_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guests_dgv)).EndInit();
            this.action_buttons_pnl.ResumeLayout(false);
            this.guest_fields_pnl.ResumeLayout(false);
            this.guest_fields_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.header_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel guests_pnl;
        private System.Windows.Forms.DataGridView guests_dgv;
        private System.Windows.Forms.Panel guest_fields_pnl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Panel action_buttons_pnl;
        private System.Windows.Forms.Button add_guest_btn;
        private System.Windows.Forms.Button delete_guest_btn;
        private System.Windows.Forms.Button refresh_guest_btn;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
    }
}
