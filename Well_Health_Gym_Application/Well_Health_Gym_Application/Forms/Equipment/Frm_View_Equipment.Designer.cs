
namespace Well_Health_Gym_Application.Forms.Equipment
{
    partial class Frm_View_Equipment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_View_Equipment_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_View_Equipment = new System.Windows.Forms.Button();
            this.btn_Add_Equipment = new System.Windows.Forms.Button();
            this.lbl_View_Equipment = new System.Windows.Forms.Label();
            this.dgv_Equipment_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_ID_Name = new System.Windows.Forms.TextBox();
            this.cmb_search_Equipment_By = new System.Windows.Forms.ComboBox();
            this.lbl_Serach_By = new System.Windows.Forms.Label();
            this.pnl_View_Equipment_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Equipment_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Equipment_Header
            // 
            this.pnl_View_Equipment_Header.BackColor = System.Drawing.Color.Black;
            this.pnl_View_Equipment_Header.Controls.Add(this.btn_Back);
            this.pnl_View_Equipment_Header.Controls.Add(this.btn_View_Equipment);
            this.pnl_View_Equipment_Header.Controls.Add(this.btn_Add_Equipment);
            this.pnl_View_Equipment_Header.Controls.Add(this.lbl_View_Equipment);
            this.pnl_View_Equipment_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_View_Equipment_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_View_Equipment_Header.Name = "pnl_View_Equipment_Header";
            this.pnl_View_Equipment_Header.Size = new System.Drawing.Size(953, 100);
            this.pnl_View_Equipment_Header.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_View_Equipment
            // 
            this.btn_View_Equipment.BackColor = System.Drawing.Color.Silver;
            this.btn_View_Equipment.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_View_Equipment.Location = new System.Drawing.Point(586, 63);
            this.btn_View_Equipment.Name = "btn_View_Equipment";
            this.btn_View_Equipment.Size = new System.Drawing.Size(156, 34);
            this.btn_View_Equipment.TabIndex = 3;
            this.btn_View_Equipment.Text = "Equipment List";
            this.btn_View_Equipment.UseVisualStyleBackColor = false;
            this.btn_View_Equipment.Click += new System.EventHandler(this.btn_View_Equipment_Click);
            // 
            // btn_Add_Equipment
            // 
            this.btn_Add_Equipment.BackColor = System.Drawing.Color.Silver;
            this.btn_Add_Equipment.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add_Equipment.Location = new System.Drawing.Point(143, 64);
            this.btn_Add_Equipment.Name = "btn_Add_Equipment";
            this.btn_Add_Equipment.Size = new System.Drawing.Size(156, 34);
            this.btn_Add_Equipment.TabIndex = 2;
            this.btn_Add_Equipment.Text = "Add Equipment";
            this.btn_Add_Equipment.UseVisualStyleBackColor = false;
            this.btn_Add_Equipment.Click += new System.EventHandler(this.btn_Add_Equipment_Click);
            // 
            // lbl_View_Equipment
            // 
            this.lbl_View_Equipment.AutoSize = true;
            this.lbl_View_Equipment.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_View_Equipment.Location = new System.Drawing.Point(311, 0);
            this.lbl_View_Equipment.Name = "lbl_View_Equipment";
            this.lbl_View_Equipment.Size = new System.Drawing.Size(341, 50);
            this.lbl_View_Equipment.TabIndex = 0;
            this.lbl_View_Equipment.Text = " Equipment List";
            // 
            // dgv_Equipment_List
            // 
            this.dgv_Equipment_List.AllowUserToAddRows = false;
            this.dgv_Equipment_List.AllowUserToDeleteRows = false;
            this.dgv_Equipment_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Equipment_List.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Equipment_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Equipment_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Equipment_List.Location = new System.Drawing.Point(12, 151);
            this.dgv_Equipment_List.Name = "dgv_Equipment_List";
            this.dgv_Equipment_List.ReadOnly = true;
            this.dgv_Equipment_List.Size = new System.Drawing.Size(918, 505);
            this.dgv_Equipment_List.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Salmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(811, 114);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(111, 31);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Salmon;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(684, 114);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 31);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_ID_Name
            // 
            this.tb_ID_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID_Name.Location = new System.Drawing.Point(444, 117);
            this.tb_ID_Name.Name = "tb_ID_Name";
            this.tb_ID_Name.Size = new System.Drawing.Size(213, 30);
            this.tb_ID_Name.TabIndex = 9;
            // 
            // cmb_search_Equipment_By
            // 
            this.cmb_search_Equipment_By.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search_Equipment_By.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_Equipment_By.FormattingEnabled = true;
            this.cmb_search_Equipment_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_search_Equipment_By.Location = new System.Drawing.Point(244, 113);
            this.cmb_search_Equipment_By.Name = "cmb_search_Equipment_By";
            this.cmb_search_Equipment_By.Size = new System.Drawing.Size(173, 29);
            this.cmb_search_Equipment_By.TabIndex = 8;
            this.cmb_search_Equipment_By.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Id_Name_KeyPress);
            // 
            // lbl_Serach_By
            // 
            this.lbl_Serach_By.AutoSize = true;
            this.lbl_Serach_By.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Serach_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Serach_By.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Serach_By.Location = new System.Drawing.Point(23, 114);
            this.lbl_Serach_By.Name = "lbl_Serach_By";
            this.lbl_Serach_By.Size = new System.Drawing.Size(206, 24);
            this.lbl_Serach_By.TabIndex = 7;
            this.lbl_Serach_By.Text = "Search Equipment By";
            // 
            // Frm_View_Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID_Name);
            this.Controls.Add(this.cmb_search_Equipment_By);
            this.Controls.Add(this.lbl_Serach_By);
            this.Controls.Add(this.dgv_Equipment_List);
            this.Controls.Add(this.pnl_View_Equipment_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_View_Equipment_Load);
            this.pnl_View_Equipment_Header.ResumeLayout(false);
            this.pnl_View_Equipment_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Equipment_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Equipment_Header;
        private System.Windows.Forms.Button btn_View_Equipment;
        private System.Windows.Forms.Button btn_Add_Equipment;
        private System.Windows.Forms.Label lbl_View_Equipment;
        private System.Windows.Forms.DataGridView dgv_Equipment_List;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_ID_Name;
        private System.Windows.Forms.ComboBox cmb_search_Equipment_By;
        private System.Windows.Forms.Label lbl_Serach_By;
    }
}