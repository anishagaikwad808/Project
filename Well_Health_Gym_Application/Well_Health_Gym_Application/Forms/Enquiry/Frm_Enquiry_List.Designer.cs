
namespace Well_Health_Gym_Application.Forms.Enquiry
{
    partial class Frm_Enquiry_List
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
            this.pnl_Enquiry = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Enquiry_List = new System.Windows.Forms.Button();
            this.btn_Add_Enquiry = new System.Windows.Forms.Button();
            this.lbl_Enquiry_List = new System.Windows.Forms.Label();
            this.dgv_Enquiry_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_ID_Name = new System.Windows.Forms.TextBox();
            this.cmb_search_Enquiry_By = new System.Windows.Forms.ComboBox();
            this.lbl_Serach_By = new System.Windows.Forms.Label();
            this.pnl_Enquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enquiry_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Enquiry
            // 
            this.pnl_Enquiry.BackColor = System.Drawing.Color.Black;
            this.pnl_Enquiry.Controls.Add(this.btn_Back);
            this.pnl_Enquiry.Controls.Add(this.btn_Enquiry_List);
            this.pnl_Enquiry.Controls.Add(this.btn_Add_Enquiry);
            this.pnl_Enquiry.Controls.Add(this.lbl_Enquiry_List);
            this.pnl_Enquiry.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Enquiry.Location = new System.Drawing.Point(0, 0);
            this.pnl_Enquiry.Name = "pnl_Enquiry";
            this.pnl_Enquiry.Size = new System.Drawing.Size(953, 100);
            this.pnl_Enquiry.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(3, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Enquiry_List
            // 
            this.btn_Enquiry_List.BackColor = System.Drawing.Color.Silver;
            this.btn_Enquiry_List.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enquiry_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Enquiry_List.Location = new System.Drawing.Point(667, 63);
            this.btn_Enquiry_List.Name = "btn_Enquiry_List";
            this.btn_Enquiry_List.Size = new System.Drawing.Size(136, 34);
            this.btn_Enquiry_List.TabIndex = 2;
            this.btn_Enquiry_List.Text = "Enquiry List";
            this.btn_Enquiry_List.UseVisualStyleBackColor = false;
            this.btn_Enquiry_List.Click += new System.EventHandler(this.btn_Enquiry_List_Click);
            // 
            // btn_Add_Enquiry
            // 
            this.btn_Add_Enquiry.BackColor = System.Drawing.Color.Silver;
            this.btn_Add_Enquiry.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Enquiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add_Enquiry.Location = new System.Drawing.Point(114, 63);
            this.btn_Add_Enquiry.Name = "btn_Add_Enquiry";
            this.btn_Add_Enquiry.Size = new System.Drawing.Size(136, 34);
            this.btn_Add_Enquiry.TabIndex = 1;
            this.btn_Add_Enquiry.Text = "Add Enquiry";
            this.btn_Add_Enquiry.UseVisualStyleBackColor = false;
            this.btn_Add_Enquiry.Click += new System.EventHandler(this.btn_Add_Enquiry_Click);
            // 
            // lbl_Enquiry_List
            // 
            this.lbl_Enquiry_List.AutoSize = true;
            this.lbl_Enquiry_List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Enquiry_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Enquiry_List.Location = new System.Drawing.Point(324, 12);
            this.lbl_Enquiry_List.Name = "lbl_Enquiry_List";
            this.lbl_Enquiry_List.Size = new System.Drawing.Size(277, 50);
            this.lbl_Enquiry_List.TabIndex = 0;
            this.lbl_Enquiry_List.Text = "Enquiry List";
            // 
            // dgv_Enquiry_List
            // 
            this.dgv_Enquiry_List.AllowUserToAddRows = false;
            this.dgv_Enquiry_List.AllowUserToDeleteRows = false;
            this.dgv_Enquiry_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Enquiry_List.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Enquiry_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Enquiry_List.Location = new System.Drawing.Point(25, 158);
            this.dgv_Enquiry_List.Name = "dgv_Enquiry_List";
            this.dgv_Enquiry_List.ReadOnly = true;
            this.dgv_Enquiry_List.Size = new System.Drawing.Size(916, 501);
            this.dgv_Enquiry_List.TabIndex = 2;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Salmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(811, 121);
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
            this.btn_Search.Location = new System.Drawing.Point(684, 121);
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
            this.tb_ID_Name.Location = new System.Drawing.Point(444, 124);
            this.tb_ID_Name.Name = "tb_ID_Name";
            this.tb_ID_Name.Size = new System.Drawing.Size(213, 30);
            this.tb_ID_Name.TabIndex = 9;
            this.tb_ID_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Id_Name_KeyPress);
            // 
            // cmb_search_Enquiry_By
            // 
            this.cmb_search_Enquiry_By.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search_Enquiry_By.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_Enquiry_By.FormattingEnabled = true;
            this.cmb_search_Enquiry_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_search_Enquiry_By.Location = new System.Drawing.Point(239, 123);
            this.cmb_search_Enquiry_By.Name = "cmb_search_Enquiry_By";
            this.cmb_search_Enquiry_By.Size = new System.Drawing.Size(173, 29);
            this.cmb_search_Enquiry_By.TabIndex = 8;
            // 
            // lbl_Serach_By
            // 
            this.lbl_Serach_By.AutoSize = true;
            this.lbl_Serach_By.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Serach_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Serach_By.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Serach_By.Location = new System.Drawing.Point(23, 121);
            this.lbl_Serach_By.Name = "lbl_Serach_By";
            this.lbl_Serach_By.Size = new System.Drawing.Size(181, 24);
            this.lbl_Serach_By.TabIndex = 7;
            this.lbl_Serach_By.Text = "Search Enquiry By";
            // 
            // Frm_Enquiry_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID_Name);
            this.Controls.Add(this.cmb_search_Enquiry_By);
            this.Controls.Add(this.lbl_Serach_By);
            this.Controls.Add(this.dgv_Enquiry_List);
            this.Controls.Add(this.pnl_Enquiry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Enquiry_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Enquiry_List_Load);
            this.pnl_Enquiry.ResumeLayout(false);
            this.pnl_Enquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Enquiry_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Enquiry;
        private System.Windows.Forms.Button btn_Enquiry_List;
        private System.Windows.Forms.Button btn_Add_Enquiry;
        private System.Windows.Forms.Label lbl_Enquiry_List;
        private System.Windows.Forms.DataGridView dgv_Enquiry_List;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_ID_Name;
        private System.Windows.Forms.ComboBox cmb_search_Enquiry_By;
        private System.Windows.Forms.Label lbl_Serach_By;
    }
}