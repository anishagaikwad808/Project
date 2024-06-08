
namespace Well_Health_Gym_Application.Forms.Member
{
    partial class Frm_View_Member
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
            this.pnl_Expence_Header = new System.Windows.Forms.Panel();
            this.btn_Update_Member = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Member_List = new System.Windows.Forms.Button();
            this.btn_Add_Member = new System.Windows.Forms.Button();
            this.lbl_Member__List = new System.Windows.Forms.Label();
            this.dgv_Member_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_ID_Name = new System.Windows.Forms.TextBox();
            this.cmb_search_Member_By = new System.Windows.Forms.ComboBox();
            this.lbl_Serach_By = new System.Windows.Forms.Label();
            this.pnl_Expence_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Expence_Header
            // 
            this.pnl_Expence_Header.BackColor = System.Drawing.Color.Black;
            this.pnl_Expence_Header.Controls.Add(this.btn_Update_Member);
            this.pnl_Expence_Header.Controls.Add(this.btn_Back);
            this.pnl_Expence_Header.Controls.Add(this.btn_Member_List);
            this.pnl_Expence_Header.Controls.Add(this.btn_Add_Member);
            this.pnl_Expence_Header.Controls.Add(this.lbl_Member__List);
            this.pnl_Expence_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Expence_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Expence_Header.Name = "pnl_Expence_Header";
            this.pnl_Expence_Header.Size = new System.Drawing.Size(953, 100);
            this.pnl_Expence_Header.TabIndex = 2;
            // 
            // btn_Update_Member
            // 
            this.btn_Update_Member.BackColor = System.Drawing.Color.Silver;
            this.btn_Update_Member.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Update_Member.Location = new System.Drawing.Point(401, 61);
            this.btn_Update_Member.Name = "btn_Update_Member";
            this.btn_Update_Member.Size = new System.Drawing.Size(178, 36);
            this.btn_Update_Member.TabIndex = 7;
            this.btn_Update_Member.Text = "Update Member";
            this.btn_Update_Member.UseVisualStyleBackColor = false;
            this.btn_Update_Member.Click += new System.EventHandler(this.btn_Update_Member_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(0, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Member_List
            // 
            this.btn_Member_List.BackColor = System.Drawing.Color.Silver;
            this.btn_Member_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Member_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Member_List.Location = new System.Drawing.Point(671, 61);
            this.btn_Member_List.Name = "btn_Member_List";
            this.btn_Member_List.Size = new System.Drawing.Size(145, 36);
            this.btn_Member_List.TabIndex = 2;
            this.btn_Member_List.Text = "Member List";
            this.btn_Member_List.UseVisualStyleBackColor = false;
            this.btn_Member_List.Click += new System.EventHandler(this.btn_Member_List_Click);
            // 
            // btn_Add_Member
            // 
            this.btn_Add_Member.BackColor = System.Drawing.Color.Silver;
            this.btn_Add_Member.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add_Member.Location = new System.Drawing.Point(79, 61);
            this.btn_Add_Member.Name = "btn_Add_Member";
            this.btn_Add_Member.Size = new System.Drawing.Size(177, 36);
            this.btn_Add_Member.TabIndex = 1;
            this.btn_Add_Member.Text = "Add Member";
            this.btn_Add_Member.UseVisualStyleBackColor = false;
            this.btn_Add_Member.Click += new System.EventHandler(this.btn_Add_Member_Click);
            // 
            // lbl_Member__List
            // 
            this.lbl_Member__List.AutoSize = true;
            this.lbl_Member__List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member__List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Member__List.Location = new System.Drawing.Point(355, 9);
            this.lbl_Member__List.Name = "lbl_Member__List";
            this.lbl_Member__List.Size = new System.Drawing.Size(271, 50);
            this.lbl_Member__List.TabIndex = 0;
            this.lbl_Member__List.Text = "Member List";
            // 
            // dgv_Member_List
            // 
            this.dgv_Member_List.AllowUserToAddRows = false;
            this.dgv_Member_List.AllowUserToDeleteRows = false;
            this.dgv_Member_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Member_List.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Member_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Member_List.Location = new System.Drawing.Point(25, 149);
            this.dgv_Member_List.Name = "dgv_Member_List";
            this.dgv_Member_List.ReadOnly = true;
            this.dgv_Member_List.Size = new System.Drawing.Size(901, 523);
            this.dgv_Member_List.TabIndex = 3;
            this.dgv_Member_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Member_List_CellDoubleClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Salmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(824, 112);
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
            this.btn_Search.Location = new System.Drawing.Point(697, 112);
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
            this.tb_ID_Name.Location = new System.Drawing.Point(457, 115);
            this.tb_ID_Name.Name = "tb_ID_Name";
            this.tb_ID_Name.Size = new System.Drawing.Size(213, 30);
            this.tb_ID_Name.TabIndex = 9;
            this.tb_ID_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Id_Name_KeyPress);
            // 
            // cmb_search_Member_By
            // 
            this.cmb_search_Member_By.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search_Member_By.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_Member_By.FormattingEnabled = true;
            this.cmb_search_Member_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_search_Member_By.Location = new System.Drawing.Point(252, 114);
            this.cmb_search_Member_By.Name = "cmb_search_Member_By";
            this.cmb_search_Member_By.Size = new System.Drawing.Size(173, 29);
            this.cmb_search_Member_By.TabIndex = 8;
            // 
            // lbl_Serach_By
            // 
            this.lbl_Serach_By.AutoSize = true;
            this.lbl_Serach_By.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Serach_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Serach_By.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Serach_By.Location = new System.Drawing.Point(36, 112);
            this.lbl_Serach_By.Name = "lbl_Serach_By";
            this.lbl_Serach_By.Size = new System.Drawing.Size(180, 24);
            this.lbl_Serach_By.TabIndex = 7;
            this.lbl_Serach_By.Text = "Search Member By";
            // 
            // Frm_View_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID_Name);
            this.Controls.Add(this.cmb_search_Member_By);
            this.Controls.Add(this.lbl_Serach_By);
            this.Controls.Add(this.dgv_Member_List);
            this.Controls.Add(this.pnl_Expence_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Member";
            this.Load += new System.EventHandler(this.Frm_View_Member_Load);
            this.pnl_Expence_Header.ResumeLayout(false);
            this.pnl_Expence_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Expence_Header;
        private System.Windows.Forms.Button btn_Update_Member;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Member_List;
        private System.Windows.Forms.Button btn_Add_Member;
        private System.Windows.Forms.Label lbl_Member__List;
        private System.Windows.Forms.DataGridView dgv_Member_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_ID_Name;
        private System.Windows.Forms.ComboBox cmb_search_Member_By;
        private System.Windows.Forms.Label lbl_Serach_By;
    }
}