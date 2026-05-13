namespace HotelAssignment
{
    partial class ReportsForm
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
            this.reports_pnl = new System.Windows.Forms.Panel();
            this.reports_tab = new System.Windows.Forms.TabControl();
            this.tab_single_table = new System.Windows.Forms.TabPage();
            this.single_main_layout = new System.Windows.Forms.TableLayoutPanel();
            this.single_report_dgv = new System.Windows.Forms.DataGridView();
            this.single_top_pnl = new System.Windows.Forms.Panel();
            this.run_single_report_btn = new System.Windows.Forms.Button();
            this.single_table_cmb = new System.Windows.Forms.ComboBox();
            this.single_table_lbl = new System.Windows.Forms.Label();
            this.tab_guest_history = new System.Windows.Forms.TabPage();
            this.guest_hist_main_layout = new System.Windows.Forms.TableLayoutPanel();
            this.guest_hist_res_dgv = new System.Windows.Forms.DataGridView();
            this.hist_combo_pnl = new System.Windows.Forms.Panel();
            this.run_guest_history_btn = new System.Windows.Forms.Button();
            this.guest_history_cmb = new System.Windows.Forms.ComboBox();
            this.guest_pick_lbl = new System.Windows.Forms.Label();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reports_pnl.SuspendLayout();
            this.reports_tab.SuspendLayout();
            this.tab_single_table.SuspendLayout();
            this.single_main_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_report_dgv)).BeginInit();
            this.single_top_pnl.SuspendLayout();
            this.tab_guest_history.SuspendLayout();
            this.guest_hist_main_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest_hist_res_dgv)).BeginInit();
            this.hist_combo_pnl.SuspendLayout();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // reports_pnl
            // 
            this.reports_pnl.Controls.Add(this.reports_tab);
            this.reports_pnl.Controls.Add(this.header_pnl);
            this.reports_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports_pnl.Location = new System.Drawing.Point(0, 0);
            this.reports_pnl.Name = "reports_pnl";
            this.reports_pnl.Size = new System.Drawing.Size(1200, 757);
            this.reports_pnl.TabIndex = 0;
            // 
            // reports_tab
            // 
            this.reports_tab.Controls.Add(this.tab_single_table);
            this.reports_tab.Controls.Add(this.tab_guest_history);
            this.reports_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports_tab.Location = new System.Drawing.Point(0, 79);
            this.reports_tab.Name = "reports_tab";
            this.reports_tab.Padding = new System.Drawing.Point(12, 4);
            this.reports_tab.SelectedIndex = 0;
            this.reports_tab.Size = new System.Drawing.Size(1200, 678);
            this.reports_tab.TabIndex = 1;
            // 
            // tab_single_table
            // 
            this.tab_single_table.Controls.Add(this.single_main_layout);
            this.tab_single_table.Location = new System.Drawing.Point(4, 39);
            this.tab_single_table.Name = "tab_single_table";
            this.tab_single_table.Padding = new System.Windows.Forms.Padding(8);
            this.tab_single_table.Size = new System.Drawing.Size(1192, 635);
            this.tab_single_table.TabIndex = 0;
            this.tab_single_table.Text = "Single table report";
            this.tab_single_table.UseVisualStyleBackColor = true;
            // 
            // single_main_layout
            // 
            this.single_main_layout.ColumnCount = 1;
            this.single_main_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.single_main_layout.Controls.Add(this.single_report_dgv, 0, 1);
            this.single_main_layout.Controls.Add(this.single_top_pnl, 0, 0);
            this.single_main_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.single_main_layout.Location = new System.Drawing.Point(8, 8);
            this.single_main_layout.Name = "single_main_layout";
            this.single_main_layout.RowCount = 2;
            this.single_main_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.single_main_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.single_main_layout.Size = new System.Drawing.Size(1184, 619);
            this.single_main_layout.TabIndex = 0;
            // 
            // single_report_dgv
            // 
            this.single_report_dgv.AllowUserToAddRows = false;
            this.single_report_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.single_report_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.single_report_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.single_report_dgv.Location = new System.Drawing.Point(3, 64);
            this.single_report_dgv.MultiSelect = false;
            this.single_report_dgv.Name = "single_report_dgv";
            this.single_report_dgv.ReadOnly = true;
            this.single_report_dgv.RowHeadersWidth = 62;
            this.single_report_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.single_report_dgv.Size = new System.Drawing.Size(1178, 552);
            this.single_report_dgv.TabIndex = 1;
            // 
            // single_top_pnl
            // 
            this.single_top_pnl.Controls.Add(this.single_table_lbl);
            this.single_top_pnl.Controls.Add(this.single_table_cmb);
            this.single_top_pnl.Controls.Add(this.run_single_report_btn);
            this.single_top_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.single_top_pnl.Location = new System.Drawing.Point(3, 3);
            this.single_top_pnl.MinimumSize = new System.Drawing.Size(0, 55);
            this.single_top_pnl.Name = "single_top_pnl";
            this.single_top_pnl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.single_top_pnl.Size = new System.Drawing.Size(1178, 55);
            this.single_top_pnl.TabIndex = 0;
            // 
            // run_single_report_btn
            // 
            this.run_single_report_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.run_single_report_btn.Location = new System.Drawing.Point(1042, 6);
            this.run_single_report_btn.Name = "run_single_report_btn";
            this.run_single_report_btn.Size = new System.Drawing.Size(130, 40);
            this.run_single_report_btn.TabIndex = 2;
            this.run_single_report_btn.Text = "Run report";
            this.run_single_report_btn.UseVisualStyleBackColor = true;
            this.run_single_report_btn.Click += new System.EventHandler(this.run_single_report_btn_Click);
            // 
            // single_table_cmb
            // 
            this.single_table_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.single_table_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.single_table_cmb.FormattingEnabled = true;
            this.single_table_cmb.Items.AddRange(new object[] {
            "Guests",
            "Rooms",
            "Reservations"});
            this.single_table_cmb.Location = new System.Drawing.Point(164, 10);
            this.single_table_cmb.Margin = new System.Windows.Forms.Padding(3, 3, 148, 3);
            this.single_table_cmb.Name = "single_table_cmb";
            this.single_table_cmb.Size = new System.Drawing.Size(860, 33);
            this.single_table_cmb.TabIndex = 1;
            // 
            // single_table_lbl
            // 
            this.single_table_lbl.AutoSize = true;
            this.single_table_lbl.Location = new System.Drawing.Point(4, 14);
            this.single_table_lbl.Name = "single_table_lbl";
            this.single_table_lbl.Size = new System.Drawing.Size(149, 25);
            this.single_table_lbl.TabIndex = 0;
            this.single_table_lbl.Text = "Report table *:";
            // 
            // tab_guest_history
            // 
            this.tab_guest_history.Controls.Add(this.guest_hist_main_layout);
            this.tab_guest_history.Location = new System.Drawing.Point(4, 39);
            this.tab_guest_history.Name = "tab_guest_history";
            this.tab_guest_history.Padding = new System.Windows.Forms.Padding(8);
            this.tab_guest_history.Size = new System.Drawing.Size(1192, 635);
            this.tab_guest_history.TabIndex = 1;
            this.tab_guest_history.Text = "Guest history (joined)";
            this.tab_guest_history.UseVisualStyleBackColor = true;
            // 
            // guest_hist_main_layout
            // 
            this.guest_hist_main_layout.ColumnCount = 1;
            this.guest_hist_main_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.guest_hist_main_layout.Controls.Add(this.guest_hist_res_dgv, 0, 1);
            this.guest_hist_main_layout.Controls.Add(this.hist_combo_pnl, 0, 0);
            this.guest_hist_main_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guest_hist_main_layout.Location = new System.Drawing.Point(8, 8);
            this.guest_hist_main_layout.Name = "guest_hist_main_layout";
            this.guest_hist_main_layout.RowCount = 2;
            this.guest_hist_main_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.guest_hist_main_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.guest_hist_main_layout.Size = new System.Drawing.Size(1184, 619);
            this.guest_hist_main_layout.TabIndex = 0;
            // 
            // guest_hist_res_dgv
            // 
            this.guest_hist_res_dgv.AllowUserToAddRows = false;
            this.guest_hist_res_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guest_hist_res_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guest_hist_res_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guest_hist_res_dgv.Location = new System.Drawing.Point(3, 61);
            this.guest_hist_res_dgv.MultiSelect = false;
            this.guest_hist_res_dgv.Name = "guest_hist_res_dgv";
            this.guest_hist_res_dgv.ReadOnly = true;
            this.guest_hist_res_dgv.RowHeadersWidth = 62;
            this.guest_hist_res_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guest_hist_res_dgv.Size = new System.Drawing.Size(1178, 555);
            this.guest_hist_res_dgv.TabIndex = 1;
            // 
            // hist_combo_pnl
            // 
            this.hist_combo_pnl.Controls.Add(this.guest_pick_lbl);
            this.hist_combo_pnl.Controls.Add(this.guest_history_cmb);
            this.hist_combo_pnl.Controls.Add(this.run_guest_history_btn);
            this.hist_combo_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hist_combo_pnl.Location = new System.Drawing.Point(3, 3);
            this.hist_combo_pnl.MinimumSize = new System.Drawing.Size(0, 52);
            this.hist_combo_pnl.Name = "hist_combo_pnl";
            this.hist_combo_pnl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.hist_combo_pnl.Size = new System.Drawing.Size(1178, 52);
            this.hist_combo_pnl.TabIndex = 0;
            // 
            // run_guest_history_btn
            // 
            this.run_guest_history_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.run_guest_history_btn.Location = new System.Drawing.Point(1042, 6);
            this.run_guest_history_btn.Name = "run_guest_history_btn";
            this.run_guest_history_btn.Size = new System.Drawing.Size(130, 40);
            this.run_guest_history_btn.TabIndex = 2;
            this.run_guest_history_btn.Text = "Run report";
            this.run_guest_history_btn.UseVisualStyleBackColor = true;
            this.run_guest_history_btn.Click += new System.EventHandler(this.run_guest_history_btn_Click);
            // 
            // guest_history_cmb
            // 
            this.guest_history_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guest_history_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guest_history_cmb.FormattingEnabled = true;
            this.guest_history_cmb.Location = new System.Drawing.Point(164, 10);
            this.guest_history_cmb.Margin = new System.Windows.Forms.Padding(3, 3, 148, 3);
            this.guest_history_cmb.Name = "guest_history_cmb";
            this.guest_history_cmb.Size = new System.Drawing.Size(860, 33);
            this.guest_history_cmb.TabIndex = 1;
            // 
            // guest_pick_lbl
            // 
            this.guest_pick_lbl.AutoSize = true;
            this.guest_pick_lbl.Location = new System.Drawing.Point(4, 14);
            this.guest_pick_lbl.Name = "guest_pick_lbl";
            this.guest_pick_lbl.Size = new System.Drawing.Size(132, 25);
            this.guest_pick_lbl.TabIndex = 0;
            this.guest_pick_lbl.Text = "Pick guest *:";
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
            this.header_pnl.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(52, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 39);
            this.back_btn.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(156, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reports";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.reports_pnl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.Shown += new System.EventHandler(this.ReportsForm_Shown);
            this.Resize += new System.EventHandler(this.ReportsForm_Resize);
            this.reports_pnl.ResumeLayout(false);
            this.reports_tab.ResumeLayout(false);
            this.tab_single_table.ResumeLayout(false);
            this.single_main_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.single_report_dgv)).EndInit();
            this.single_top_pnl.ResumeLayout(false);
            this.single_top_pnl.PerformLayout();
            this.tab_guest_history.ResumeLayout(false);
            this.guest_hist_main_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guest_hist_res_dgv)).EndInit();
            this.hist_combo_pnl.ResumeLayout(false);
            this.hist_combo_pnl.PerformLayout();
            this.header_pnl.ResumeLayout(false);
            this.header_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reports_pnl;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl reports_tab;
        private System.Windows.Forms.TabPage tab_single_table;
        private System.Windows.Forms.TabPage tab_guest_history;
        private System.Windows.Forms.TableLayoutPanel single_main_layout;
        private System.Windows.Forms.Panel single_top_pnl;
        private System.Windows.Forms.Label single_table_lbl;
        private System.Windows.Forms.ComboBox single_table_cmb;
        private System.Windows.Forms.Button run_single_report_btn;
        private System.Windows.Forms.DataGridView single_report_dgv;
        private System.Windows.Forms.TableLayoutPanel guest_hist_main_layout;
        private System.Windows.Forms.Panel hist_combo_pnl;
        private System.Windows.Forms.Label guest_pick_lbl;
        private System.Windows.Forms.ComboBox guest_history_cmb;
        private System.Windows.Forms.Button run_guest_history_btn;
        private System.Windows.Forms.DataGridView guest_hist_res_dgv;
    }
}
