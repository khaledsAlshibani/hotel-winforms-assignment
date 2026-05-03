namespace HotelAssignment
{
    partial class ManageReservations
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
            this.reservations_pnl = new System.Windows.Forms.Panel();
            this.reservations_dgv = new System.Windows.Forms.DataGridView();
            this.action_buttons_pnl = new System.Windows.Forms.Panel();
            this.add_reservation_btn = new System.Windows.Forms.Button();
            this.delete_reservation_btn = new System.Windows.Forms.Button();
            this.refresh_reservation_btn = new System.Windows.Forms.Button();
            this.reservation_fields_pnl = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label_guest = new System.Windows.Forms.Label();
            this.guest_cmb = new System.Windows.Forms.ComboBox();
            this.label_room = new System.Windows.Forms.Label();
            this.room_cmb = new System.Windows.Forms.ComboBox();
            this.label_check_in = new System.Windows.Forms.Label();
            this.check_in_dtp = new System.Windows.Forms.DateTimePicker();
            this.label_check_out = new System.Windows.Forms.Label();
            this.check_out_dtp = new System.Windows.Forms.DateTimePicker();
            this.label_status = new System.Windows.Forms.Label();
            this.status_cmb = new System.Windows.Forms.ComboBox();
            this.label_cost_per_day = new System.Windows.Forms.Label();
            this.cost_per_day_txt = new System.Windows.Forms.TextBox();
            this.total_preview_lbl = new System.Windows.Forms.Label();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reservations_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservations_dgv)).BeginInit();
            this.action_buttons_pnl.SuspendLayout();
            this.reservation_fields_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservations_pnl
            // 
            this.reservations_pnl.Controls.Add(this.reservations_dgv);
            this.reservations_pnl.Controls.Add(this.action_buttons_pnl);
            this.reservations_pnl.Controls.Add(this.reservation_fields_pnl);
            this.reservations_pnl.Controls.Add(this.header_pnl);
            this.reservations_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservations_pnl.Location = new System.Drawing.Point(0, 0);
            this.reservations_pnl.Name = "reservations_pnl";
            this.reservations_pnl.Size = new System.Drawing.Size(1200, 757);
            this.reservations_pnl.TabIndex = 0;
            // 
            // reservations_dgv
            // 
            this.reservations_dgv.AllowUserToAddRows = false;
            this.reservations_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservations_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservations_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservations_dgv.Location = new System.Drawing.Point(0, 439);
            this.reservations_dgv.MultiSelect = false;
            this.reservations_dgv.Name = "reservations_dgv";
            this.reservations_dgv.ReadOnly = true;
            this.reservations_dgv.RowHeadersWidth = 62;
            this.reservations_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservations_dgv.Size = new System.Drawing.Size(1200, 253);
            this.reservations_dgv.TabIndex = 0;
            this.reservations_dgv.SelectionChanged += new System.EventHandler(this.reservations_dgv_SelectionChanged);
            // 
            // action_buttons_pnl
            // 
            this.action_buttons_pnl.Controls.Add(this.add_reservation_btn);
            this.action_buttons_pnl.Controls.Add(this.delete_reservation_btn);
            this.action_buttons_pnl.Controls.Add(this.refresh_reservation_btn);
            this.action_buttons_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.action_buttons_pnl.Location = new System.Drawing.Point(0, 692);
            this.action_buttons_pnl.Name = "action_buttons_pnl";
            this.action_buttons_pnl.Padding = new System.Windows.Forms.Padding(12, 6, 12, 10);
            this.action_buttons_pnl.Size = new System.Drawing.Size(1200, 65);
            this.action_buttons_pnl.TabIndex = 2;
            // 
            // add_reservation_btn
            // 
            this.add_reservation_btn.Location = new System.Drawing.Point(44, 8);
            this.add_reservation_btn.Name = "add_reservation_btn";
            this.add_reservation_btn.Size = new System.Drawing.Size(213, 47);
            this.add_reservation_btn.TabIndex = 7;
            this.add_reservation_btn.Text = "Add";
            this.add_reservation_btn.UseVisualStyleBackColor = true;
            this.add_reservation_btn.Click += new System.EventHandler(this.add_reservation_btn_Click);
            // 
            // delete_reservation_btn
            // 
            this.delete_reservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_reservation_btn.ForeColor = System.Drawing.Color.Red;
            this.delete_reservation_btn.Location = new System.Drawing.Point(1016, 9);
            this.delete_reservation_btn.Name = "delete_reservation_btn";
            this.delete_reservation_btn.Size = new System.Drawing.Size(130, 47);
            this.delete_reservation_btn.TabIndex = 9;
            this.delete_reservation_btn.Text = "Delete";
            this.delete_reservation_btn.UseVisualStyleBackColor = true;
            this.delete_reservation_btn.Click += new System.EventHandler(this.delete_reservation_btn_Click);
            // 
            // refresh_reservation_btn
            // 
            this.refresh_reservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_reservation_btn.Location = new System.Drawing.Point(789, 8);
            this.refresh_reservation_btn.Name = "refresh_reservation_btn";
            this.refresh_reservation_btn.Size = new System.Drawing.Size(213, 47);
            this.refresh_reservation_btn.TabIndex = 8;
            this.refresh_reservation_btn.Text = "Refresh";
            this.refresh_reservation_btn.UseVisualStyleBackColor = true;
            this.refresh_reservation_btn.Click += new System.EventHandler(this.refresh_reservation_btn_Click);
            // 
            // reservation_fields_pnl
            // 
            this.reservation_fields_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.reservation_fields_pnl.Controls.Add(this.save_btn);
            this.reservation_fields_pnl.Controls.Add(this.clear_btn);
            this.reservation_fields_pnl.Controls.Add(this.label_guest);
            this.reservation_fields_pnl.Controls.Add(this.guest_cmb);
            this.reservation_fields_pnl.Controls.Add(this.label_room);
            this.reservation_fields_pnl.Controls.Add(this.room_cmb);
            this.reservation_fields_pnl.Controls.Add(this.label_check_in);
            this.reservation_fields_pnl.Controls.Add(this.check_in_dtp);
            this.reservation_fields_pnl.Controls.Add(this.label_check_out);
            this.reservation_fields_pnl.Controls.Add(this.check_out_dtp);
            this.reservation_fields_pnl.Controls.Add(this.label_status);
            this.reservation_fields_pnl.Controls.Add(this.status_cmb);
            this.reservation_fields_pnl.Controls.Add(this.label_cost_per_day);
            this.reservation_fields_pnl.Controls.Add(this.cost_per_day_txt);
            this.reservation_fields_pnl.Controls.Add(this.total_preview_lbl);
            this.reservation_fields_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservation_fields_pnl.Location = new System.Drawing.Point(0, 79);
            this.reservation_fields_pnl.Name = "reservation_fields_pnl";
            this.reservation_fields_pnl.Padding = new System.Windows.Forms.Padding(12, 8, 12, 10);
            this.reservation_fields_pnl.Size = new System.Drawing.Size(1200, 360);
            this.reservation_fields_pnl.TabIndex = 1;
            this.reservation_fields_pnl.Visible = false;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(44, 285);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(211, 58);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.ForeColor = System.Drawing.Color.Red;
            this.clear_btn.Location = new System.Drawing.Point(277, 285);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(91, 58);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.add_reservation_btn_Click);
            // 
            // label_guest
            // 
            this.label_guest.AutoSize = true;
            this.label_guest.Location = new System.Drawing.Point(47, 27);
            this.label_guest.Name = "label_guest";
            this.label_guest.Size = new System.Drawing.Size(89, 25);
            this.label_guest.TabIndex = 0;
            this.label_guest.Text = "Guest *:";
            // 
            // guest_cmb
            // 
            this.guest_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guest_cmb.FormattingEnabled = true;
            this.guest_cmb.Location = new System.Drawing.Point(44, 55);
            this.guest_cmb.Name = "guest_cmb";
            this.guest_cmb.Size = new System.Drawing.Size(397, 33);
            this.guest_cmb.TabIndex = 1;
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Location = new System.Drawing.Point(462, 24);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(88, 25);
            this.label_room.TabIndex = 0;
            this.label_room.Text = "Room *:";
            // 
            // room_cmb
            // 
            this.room_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.room_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_cmb.FormattingEnabled = true;
            this.room_cmb.Location = new System.Drawing.Point(467, 55);
            this.room_cmb.Name = "room_cmb";
            this.room_cmb.Size = new System.Drawing.Size(597, 33);
            this.room_cmb.TabIndex = 2;
            // 
            // label_check_in
            // 
            this.label_check_in.AutoSize = true;
            this.label_check_in.Location = new System.Drawing.Point(44, 100);
            this.label_check_in.Name = "label_check_in";
            this.label_check_in.Size = new System.Drawing.Size(116, 25);
            this.label_check_in.TabIndex = 0;
            this.label_check_in.Text = "Check in *:";
            // 
            // check_in_dtp
            // 
            this.check_in_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.check_in_dtp.Location = new System.Drawing.Point(44, 133);
            this.check_in_dtp.Name = "check_in_dtp";
            this.check_in_dtp.Size = new System.Drawing.Size(397, 31);
            this.check_in_dtp.TabIndex = 3;
            // 
            // label_check_out
            // 
            this.label_check_out.AutoSize = true;
            this.label_check_out.Location = new System.Drawing.Point(462, 100);
            this.label_check_out.Name = "label_check_out";
            this.label_check_out.Size = new System.Drawing.Size(129, 25);
            this.label_check_out.TabIndex = 0;
            this.label_check_out.Text = "Check out *:";
            // 
            // check_out_dtp
            // 
            this.check_out_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_out_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.check_out_dtp.Location = new System.Drawing.Point(467, 133);
            this.check_out_dtp.Name = "check_out_dtp";
            this.check_out_dtp.Size = new System.Drawing.Size(597, 31);
            this.check_out_dtp.TabIndex = 4;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(44, 175);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(93, 25);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "Status *:";
            // 
            // status_cmb
            // 
            this.status_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cmb.FormattingEnabled = true;
            this.status_cmb.Location = new System.Drawing.Point(44, 205);
            this.status_cmb.Name = "status_cmb";
            this.status_cmb.Size = new System.Drawing.Size(397, 33);
            this.status_cmb.TabIndex = 5;
            // 
            // label_cost_per_day
            // 
            this.label_cost_per_day.AutoSize = true;
            this.label_cost_per_day.Location = new System.Drawing.Point(462, 175);
            this.label_cost_per_day.Name = "label_cost_per_day";
            this.label_cost_per_day.Size = new System.Drawing.Size(113, 25);
            this.label_cost_per_day.TabIndex = 0;
            this.label_cost_per_day.Text = "cost/day *:";
            // 
            // cost_per_day_txt
            // 
            this.cost_per_day_txt.Location = new System.Drawing.Point(467, 205);
            this.cost_per_day_txt.Name = "cost_per_day_txt";
            this.cost_per_day_txt.Size = new System.Drawing.Size(140, 31);
            this.cost_per_day_txt.TabIndex = 6;
            // 
            // total_preview_lbl
            // 
            this.total_preview_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.total_preview_lbl.Location = new System.Drawing.Point(620, 201);
            this.total_preview_lbl.Name = "total_preview_lbl";
            this.total_preview_lbl.Size = new System.Drawing.Size(568, 40);
            this.total_preview_lbl.TabIndex = 0;
            this.total_preview_lbl.Text = "Total: not set yet";
            this.total_preview_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.back_btn);
            this.header_pnl.Controls.Add(this.label3);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(0, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.header_pnl.Size = new System.Drawing.Size(1200, 79);
            this.header_pnl.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(402, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Reservations";
            // 
            // ManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.reservations_pnl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ManageReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.ManageReservations_Load);
            this.reservations_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservations_dgv)).EndInit();
            this.action_buttons_pnl.ResumeLayout(false);
            this.reservation_fields_pnl.ResumeLayout(false);
            this.reservation_fields_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.header_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reservations_pnl;
        private System.Windows.Forms.DataGridView reservations_dgv;
        private System.Windows.Forms.Panel reservation_fields_pnl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label_guest;
        private System.Windows.Forms.ComboBox guest_cmb;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.ComboBox room_cmb;
        private System.Windows.Forms.Label label_check_in;
        private System.Windows.Forms.DateTimePicker check_in_dtp;
        private System.Windows.Forms.Label label_check_out;
        private System.Windows.Forms.DateTimePicker check_out_dtp;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox status_cmb;
        private System.Windows.Forms.Label label_cost_per_day;
        private System.Windows.Forms.TextBox cost_per_day_txt;
        private System.Windows.Forms.Label total_preview_lbl;
        private System.Windows.Forms.Panel action_buttons_pnl;
        private System.Windows.Forms.Button add_reservation_btn;
        private System.Windows.Forms.Button delete_reservation_btn;
        private System.Windows.Forms.Button refresh_reservation_btn;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
    }
}
