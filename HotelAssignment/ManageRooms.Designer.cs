namespace HotelAssignment
{
    partial class ManageRooms
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
            this.rooms_pnl = new System.Windows.Forms.Panel();
            this.rooms_dgv = new System.Windows.Forms.DataGridView();
            this.action_buttons_pnl = new System.Windows.Forms.Panel();
            this.add_room_btn = new System.Windows.Forms.Button();
            this.delete_room_btn = new System.Windows.Forms.Button();
            this.refresh_room_btn = new System.Windows.Forms.Button();
            this.room_fields_pnl = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label_room_number = new System.Windows.Forms.Label();
            this.room_number_txt = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.status_cmb = new System.Windows.Forms.ComboBox();
            this.label_floor = new System.Windows.Forms.Label();
            this.floor_cmb = new System.Windows.Forms.ComboBox();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_dgv)).BeginInit();
            this.action_buttons_pnl.SuspendLayout();
            this.room_fields_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // rooms_pnl
            // 
            this.rooms_pnl.Controls.Add(this.rooms_dgv);
            this.rooms_pnl.Controls.Add(this.action_buttons_pnl);
            this.rooms_pnl.Controls.Add(this.room_fields_pnl);
            this.rooms_pnl.Controls.Add(this.header_pnl);
            this.rooms_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rooms_pnl.Location = new System.Drawing.Point(0, 0);
            this.rooms_pnl.Name = "rooms_pnl";
            this.rooms_pnl.Size = new System.Drawing.Size(1200, 757);
            this.rooms_pnl.TabIndex = 0;
            // 
            // rooms_dgv
            // 
            this.rooms_dgv.AllowUserToAddRows = false;
            this.rooms_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rooms_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rooms_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rooms_dgv.Location = new System.Drawing.Point(0, 358);
            this.rooms_dgv.MultiSelect = false;
            this.rooms_dgv.Name = "rooms_dgv";
            this.rooms_dgv.ReadOnly = true;
            this.rooms_dgv.RowHeadersWidth = 62;
            this.rooms_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rooms_dgv.Size = new System.Drawing.Size(1200, 334);
            this.rooms_dgv.TabIndex = 0;
            this.rooms_dgv.SelectionChanged += new System.EventHandler(this.rooms_dgv_SelectionChanged);
            // 
            // action_buttons_pnl
            // 
            this.action_buttons_pnl.Controls.Add(this.add_room_btn);
            this.action_buttons_pnl.Controls.Add(this.delete_room_btn);
            this.action_buttons_pnl.Controls.Add(this.refresh_room_btn);
            this.action_buttons_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.action_buttons_pnl.Location = new System.Drawing.Point(0, 692);
            this.action_buttons_pnl.Name = "action_buttons_pnl";
            this.action_buttons_pnl.Padding = new System.Windows.Forms.Padding(12, 6, 12, 10);
            this.action_buttons_pnl.Size = new System.Drawing.Size(1200, 65);
            this.action_buttons_pnl.TabIndex = 2;
            // 
            // add_room_btn
            // 
            this.add_room_btn.Location = new System.Drawing.Point(44, 8);
            this.add_room_btn.Name = "add_room_btn";
            this.add_room_btn.Size = new System.Drawing.Size(213, 47);
            this.add_room_btn.TabIndex = 7;
            this.add_room_btn.Text = "Add";
            this.add_room_btn.UseVisualStyleBackColor = true;
            this.add_room_btn.Click += new System.EventHandler(this.add_room_btn_Click);
            // 
            // delete_room_btn
            // 
            this.delete_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_room_btn.ForeColor = System.Drawing.Color.Red;
            this.delete_room_btn.Location = new System.Drawing.Point(1030, 9);
            this.delete_room_btn.Name = "delete_room_btn";
            this.delete_room_btn.Size = new System.Drawing.Size(130, 47);
            this.delete_room_btn.TabIndex = 9;
            this.delete_room_btn.Text = "Delete";
            this.delete_room_btn.UseVisualStyleBackColor = true;
            this.delete_room_btn.Click += new System.EventHandler(this.delete_room_btn_Click);
            // 
            // refresh_room_btn
            // 
            this.refresh_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_room_btn.Location = new System.Drawing.Point(803, 8);
            this.refresh_room_btn.Name = "refresh_room_btn";
            this.refresh_room_btn.Size = new System.Drawing.Size(213, 47);
            this.refresh_room_btn.TabIndex = 8;
            this.refresh_room_btn.Text = "Refresh";
            this.refresh_room_btn.UseVisualStyleBackColor = true;
            this.refresh_room_btn.Click += new System.EventHandler(this.refresh_room_btn_Click);
            // 
            // room_fields_pnl
            // 
            this.room_fields_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.room_fields_pnl.Controls.Add(this.save_btn);
            this.room_fields_pnl.Controls.Add(this.clear_btn);
            this.room_fields_pnl.Controls.Add(this.label_room_number);
            this.room_fields_pnl.Controls.Add(this.room_number_txt);
            this.room_fields_pnl.Controls.Add(this.label_status);
            this.room_fields_pnl.Controls.Add(this.status_cmb);
            this.room_fields_pnl.Controls.Add(this.label_floor);
            this.room_fields_pnl.Controls.Add(this.floor_cmb);
            this.room_fields_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.room_fields_pnl.Location = new System.Drawing.Point(0, 79);
            this.room_fields_pnl.Name = "room_fields_pnl";
            this.room_fields_pnl.Padding = new System.Windows.Forms.Padding(12, 8, 12, 10);
            this.room_fields_pnl.Size = new System.Drawing.Size(1200, 279);
            this.room_fields_pnl.TabIndex = 1;
            this.room_fields_pnl.Visible = false;
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
            this.clear_btn.Click += new System.EventHandler(this.add_room_btn_Click);
            // 
            // label_room_number
            // 
            this.label_room_number.AutoSize = true;
            this.label_room_number.Location = new System.Drawing.Point(47, 27);
            this.label_room_number.Name = "label_room_number";
            this.label_room_number.Size = new System.Drawing.Size(166, 25);
            this.label_room_number.TabIndex = 0;
            this.label_room_number.Text = "Room number *:";
            // 
            // room_number_txt
            // 
            this.room_number_txt.Location = new System.Drawing.Point(44, 55);
            this.room_number_txt.Name = "room_number_txt";
            this.room_number_txt.Size = new System.Drawing.Size(397, 31);
            this.room_number_txt.TabIndex = 1;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(462, 24);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(93, 25);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "Status *:";
            // 
            // status_cmb
            // 
            this.status_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cmb.FormattingEnabled = true;
            this.status_cmb.Location = new System.Drawing.Point(467, 55);
            this.status_cmb.Name = "status_cmb";
            this.status_cmb.Size = new System.Drawing.Size(597, 33);
            this.status_cmb.TabIndex = 2;
            // 
            // label_floor
            // 
            this.label_floor.AutoSize = true;
            this.label_floor.Location = new System.Drawing.Point(44, 100);
            this.label_floor.Name = "label_floor";
            this.label_floor.Size = new System.Drawing.Size(81, 25);
            this.label_floor.TabIndex = 0;
            this.label_floor.Text = "Floor *:";
            // 
            // floor_cmb
            // 
            this.floor_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor_cmb.FormattingEnabled = true;
            this.floor_cmb.Location = new System.Drawing.Point(44, 133);
            this.floor_cmb.Name = "floor_cmb";
            this.floor_cmb.Size = new System.Drawing.Size(397, 33);
            this.floor_cmb.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(294, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Rooms";
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.rooms_pnl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ManageRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            this.rooms_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rooms_dgv)).EndInit();
            this.action_buttons_pnl.ResumeLayout(false);
            this.room_fields_pnl.ResumeLayout(false);
            this.room_fields_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.header_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rooms_pnl;
        private System.Windows.Forms.DataGridView rooms_dgv;
        private System.Windows.Forms.Panel room_fields_pnl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label_room_number;
        private System.Windows.Forms.TextBox room_number_txt;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox status_cmb;
        private System.Windows.Forms.Label label_floor;
        private System.Windows.Forms.ComboBox floor_cmb;
        private System.Windows.Forms.Panel action_buttons_pnl;
        private System.Windows.Forms.Button add_room_btn;
        private System.Windows.Forms.Button delete_room_btn;
        private System.Windows.Forms.Button refresh_room_btn;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
    }
}
