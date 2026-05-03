namespace HotelAssignment
{
    partial class DashboardForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.manage_rooms_btn = new System.Windows.Forms.Button();
            this.manage_reservations_btn = new System.Windows.Forms.Button();
            this.manage_guests_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.overview_grp = new System.Windows.Forms.GroupBox();
            this.stat_checkins_today_lbl = new System.Windows.Forms.Label();
            this.stat_pending_reservations_lbl = new System.Windows.Forms.Label();
            this.stat_available_rooms_lbl = new System.Windows.Forms.Label();
            this.stat_total_reservations_lbl = new System.Windows.Forms.Label();
            this.stat_total_rooms_lbl = new System.Windows.Forms.Label();
            this.stat_total_guests_lbl = new System.Windows.Forms.Label();
            this.refresh_overview_btn = new System.Windows.Forms.Button();
            this.overview_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 51);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome, Admin 👋";
            // 
            // manage_rooms_btn
            // 
            this.manage_rooms_btn.Location = new System.Drawing.Point(729, 311);
            this.manage_rooms_btn.Name = "manage_rooms_btn";
            this.manage_rooms_btn.Size = new System.Drawing.Size(384, 92);
            this.manage_rooms_btn.TabIndex = 2;
            this.manage_rooms_btn.Text = "Manage Rooms";
            this.manage_rooms_btn.UseVisualStyleBackColor = true;
            // 
            // manage_reservations_btn
            // 
            this.manage_reservations_btn.Location = new System.Drawing.Point(729, 413);
            this.manage_reservations_btn.Name = "manage_reservations_btn";
            this.manage_reservations_btn.Size = new System.Drawing.Size(384, 92);
            this.manage_reservations_btn.TabIndex = 3;
            this.manage_reservations_btn.Text = "Manage Reservations";
            this.manage_reservations_btn.UseVisualStyleBackColor = true;
            // 
            // manage_guests_btn
            // 
            this.manage_guests_btn.Location = new System.Drawing.Point(729, 208);
            this.manage_guests_btn.Name = "manage_guests_btn";
            this.manage_guests_btn.Size = new System.Drawing.Size(384, 92);
            this.manage_guests_btn.TabIndex = 1;
            this.manage_guests_btn.Text = "Manage Guests";
            this.manage_guests_btn.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(1002, 554);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(111, 53);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            // 
            // overview_grp
            // 
            this.overview_grp.Controls.Add(this.stat_checkins_today_lbl);
            this.overview_grp.Controls.Add(this.stat_pending_reservations_lbl);
            this.overview_grp.Controls.Add(this.stat_available_rooms_lbl);
            this.overview_grp.Controls.Add(this.stat_total_reservations_lbl);
            this.overview_grp.Controls.Add(this.stat_total_rooms_lbl);
            this.overview_grp.Controls.Add(this.stat_total_guests_lbl);
            this.overview_grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_grp.Location = new System.Drawing.Point(115, 194);
            this.overview_grp.Name = "overview_grp";
            this.overview_grp.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.overview_grp.Size = new System.Drawing.Size(540, 311);
            this.overview_grp.TabIndex = 5;
            this.overview_grp.TabStop = false;
            this.overview_grp.Text = "Overview";
            this.overview_grp.Enter += new System.EventHandler(this.overview_grp_Enter);
            // 
            // stat_checkins_today_lbl
            // 
            this.stat_checkins_today_lbl.AutoSize = true;
            this.stat_checkins_today_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_checkins_today_lbl.Location = new System.Drawing.Point(20, 242);
            this.stat_checkins_today_lbl.Name = "stat_checkins_today_lbl";
            this.stat_checkins_today_lbl.Size = new System.Drawing.Size(446, 31);
            this.stat_checkins_today_lbl.TabIndex = 5;
            this.stat_checkins_today_lbl.Text = "Reservations with check-in today: --";
            // 
            // stat_pending_reservations_lbl
            // 
            this.stat_pending_reservations_lbl.AutoSize = true;
            this.stat_pending_reservations_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_pending_reservations_lbl.Location = new System.Drawing.Point(20, 202);
            this.stat_pending_reservations_lbl.Name = "stat_pending_reservations_lbl";
            this.stat_pending_reservations_lbl.Size = new System.Drawing.Size(302, 31);
            this.stat_pending_reservations_lbl.TabIndex = 4;
            this.stat_pending_reservations_lbl.Text = "Pending reservations: --";
            // 
            // stat_available_rooms_lbl
            // 
            this.stat_available_rooms_lbl.AutoSize = true;
            this.stat_available_rooms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_available_rooms_lbl.Location = new System.Drawing.Point(20, 162);
            this.stat_available_rooms_lbl.Name = "stat_available_rooms_lbl";
            this.stat_available_rooms_lbl.Size = new System.Drawing.Size(296, 31);
            this.stat_available_rooms_lbl.TabIndex = 3;
            this.stat_available_rooms_lbl.Text = "Available rooms now: --";
            // 
            // stat_total_reservations_lbl
            // 
            this.stat_total_reservations_lbl.AutoSize = true;
            this.stat_total_reservations_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_total_reservations_lbl.Location = new System.Drawing.Point(20, 122);
            this.stat_total_reservations_lbl.Name = "stat_total_reservations_lbl";
            this.stat_total_reservations_lbl.Size = new System.Drawing.Size(264, 31);
            this.stat_total_reservations_lbl.TabIndex = 2;
            this.stat_total_reservations_lbl.Text = "Total reservations: --";
            // 
            // stat_total_rooms_lbl
            // 
            this.stat_total_rooms_lbl.AutoSize = true;
            this.stat_total_rooms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_total_rooms_lbl.Location = new System.Drawing.Point(20, 82);
            this.stat_total_rooms_lbl.Name = "stat_total_rooms_lbl";
            this.stat_total_rooms_lbl.Size = new System.Drawing.Size(190, 31);
            this.stat_total_rooms_lbl.TabIndex = 1;
            this.stat_total_rooms_lbl.Text = "Total rooms: --";
            // 
            // stat_total_guests_lbl
            // 
            this.stat_total_guests_lbl.AutoSize = true;
            this.stat_total_guests_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_total_guests_lbl.Location = new System.Drawing.Point(20, 42);
            this.stat_total_guests_lbl.Name = "stat_total_guests_lbl";
            this.stat_total_guests_lbl.Size = new System.Drawing.Size(196, 31);
            this.stat_total_guests_lbl.TabIndex = 0;
            this.stat_total_guests_lbl.Text = "Total guests: --";
            // 
            // refresh_overview_btn
            // 
            this.refresh_overview_btn.Location = new System.Drawing.Point(102, 549);
            this.refresh_overview_btn.Name = "refresh_overview_btn";
            this.refresh_overview_btn.Size = new System.Drawing.Size(541, 58);
            this.refresh_overview_btn.TabIndex = 7;
            this.refresh_overview_btn.Text = "Refresh";
            this.refresh_overview_btn.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 681);
            this.Controls.Add(this.refresh_overview_btn);
            this.Controls.Add(this.overview_grp);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.manage_guests_btn);
            this.Controls.Add(this.manage_reservations_btn);
            this.Controls.Add(this.manage_rooms_btn);
            this.Controls.Add(this.label3);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.overview_grp.ResumeLayout(false);
            this.overview_grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button manage_rooms_btn;
        private System.Windows.Forms.Button manage_reservations_btn;
        private System.Windows.Forms.Button manage_guests_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.GroupBox overview_grp;
        private System.Windows.Forms.Label stat_total_guests_lbl;
        private System.Windows.Forms.Label stat_total_rooms_lbl;
        private System.Windows.Forms.Label stat_total_reservations_lbl;
        private System.Windows.Forms.Label stat_available_rooms_lbl;
        private System.Windows.Forms.Label stat_pending_reservations_lbl;
        private System.Windows.Forms.Label stat_checkins_today_lbl;
        private System.Windows.Forms.Button refresh_overview_btn;
    }
}
