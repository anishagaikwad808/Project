
namespace Well_Health_Gym_Application.Forms.Trainer
{
    partial class Frm_View_Trainer_List
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
            this.pnl_View_Trainer_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Trainer_List = new System.Windows.Forms.Button();
            this.btn_Trainer_Add = new System.Windows.Forms.Button();
            this.btn_Trainer_Update = new System.Windows.Forms.Button();
            this.lbl_View_Trainer_List = new System.Windows.Forms.Label();
            this.dgv_Trianer_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_ID_Name = new System.Windows.Forms.TextBox();
            this.cmb_search_Trainer_By = new System.Windows.Forms.ComboBox();
            this.lbl_Serach_By = new System.Windows.Forms.Label();
            this.pnl_View_Trainer_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trianer_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Trainer_Header
            // 
            this.pnl_View_Trainer_Header.BackColor = System.Drawing.Color.Black;
            this.pnl_View_Trainer_Header.Controls.Add(this.btn_Back);
            this.pnl_View_Trainer_Header.Controls.Add(this.btn_Trainer_List);
            this.pnl_View_Trainer_Header.Controls.Add(this.btn_Trainer_Add);
            this.pnl_View_Trainer_Header.Controls.Add(this.btn_Trainer_Update);
            this.pnl_View_Trainer_Header.Controls.Add(this.lbl_View_Trainer_List);
            this.pnl_View_Trainer_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_View_Trainer_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_View_Trainer_Header.Name = "pnl_View_Trainer_Header";
            this.pnl_View_Trainer_Header.Size = new System.Drawing.Size(953, 100);
            this.pnl_View_Trainer_Header.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(3, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_Trainer_List
            // 
            this.btn_Trainer_List.BackColor = System.Drawing.Color.Silver;
            this.btn_Trainer_List.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trainer_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Trainer_List.Location = new System.Drawing.Point(661, 63);
            this.btn_Trainer_List.Name = "btn_Trainer_List";
            this.btn_Trainer_List.Size = new System.Drawing.Size(207, 37);
            this.btn_Trainer_List.TabIndex = 4;
            this.btn_Trainer_List.Text = "Trainer List";
            this.btn_Trainer_List.UseVisualStyleBackColor = false;
            this.btn_Trainer_List.Click += new System.EventHandler(this.btn_Trainer_List_Click);
            // 
            // btn_Trainer_Add
            // 
            this.btn_Trainer_Add.BackColor = System.Drawing.Color.Silver;
            this.btn_Trainer_Add.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trainer_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Trainer_Add.Location = new System.Drawing.Point(394, 63);
            this.btn_Trainer_Add.Name = "btn_Trainer_Add";
            this.btn_Trainer_Add.Size = new System.Drawing.Size(173, 37);
            this.btn_Trainer_Add.TabIndex = 3;
            this.btn_Trainer_Add.Text = "Add Trainer";
            this.btn_Trainer_Add.UseVisualStyleBackColor = false;
            this.btn_Trainer_Add.Click += new System.EventHandler(this.btn_Trainer_Add_Click);
            // 
            // btn_Trainer_Update
            // 
            this.btn_Trainer_Update.BackColor = System.Drawing.Color.Silver;
            this.btn_Trainer_Update.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trainer_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Trainer_Update.Location = new System.Drawing.Point(78, 63);
            this.btn_Trainer_Update.Name = "btn_Trainer_Update";
            this.btn_Trainer_Update.Size = new System.Drawing.Size(163, 37);
            this.btn_Trainer_Update.TabIndex = 2;
            this.btn_Trainer_Update.Text = "Update Trainer";
            this.btn_Trainer_Update.UseVisualStyleBackColor = false;
            this.btn_Trainer_Update.Click += new System.EventHandler(this.btn_Trainer_Update_Click);
            // 
            // lbl_View_Trainer_List
            // 
            this.lbl_View_Trainer_List.AutoSize = true;
            this.lbl_View_Trainer_List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Trainer_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_View_Trainer_List.Location = new System.Drawing.Point(339, 0);
            this.lbl_View_Trainer_List.Name = "lbl_View_Trainer_List";
            this.lbl_View_Trainer_List.Size = new System.Drawing.Size(263, 50);
            this.lbl_View_Trainer_List.TabIndex = 0;
            this.lbl_View_Trainer_List.Text = "Trainer List";
            // 
            // dgv_Trianer_List
            // 
            this.dgv_Trianer_List.AllowUserToAddRows = false;
            this.dgv_Trianer_List.AllowUserToDeleteRows = false;
            this.dgv_Trianer_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Trianer_List.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Trianer_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Trianer_List.Location = new System.Drawing.Point(32, 146);
            this.dgv_Trianer_List.Name = "dgv_Trianer_List";
            this.dgv_Trianer_List.Size = new System.Drawing.Size(898, 526);
            this.dgv_Trianer_List.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Salmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(809, 109);
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
            this.btn_Search.Location = new System.Drawing.Point(682, 109);
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
            this.tb_ID_Name.Location = new System.Drawing.Point(442, 112);
            this.tb_ID_Name.Name = "tb_ID_Name";
            this.tb_ID_Name.Size = new System.Drawing.Size(213, 30);
            this.tb_ID_Name.TabIndex = 9;
            this.tb_ID_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Id_Name_KeyPress);
            // 
            // cmb_search_Trainer_By
            // 
            this.cmb_search_Trainer_By.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search_Trainer_By.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_Trainer_By.FormattingEnabled = true;
            this.cmb_search_Trainer_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_search_Trainer_By.Location = new System.Drawing.Point(237, 111);
            this.cmb_search_Trainer_By.Name = "cmb_search_Trainer_By";
            this.cmb_search_Trainer_By.Size = new System.Drawing.Size(173, 29);
            this.cmb_search_Trainer_By.TabIndex = 8;
            // 
            // lbl_Serach_By
            // 
            this.lbl_Serach_By.AutoSize = true;
            this.lbl_Serach_By.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Serach_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Serach_By.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Serach_By.Location = new System.Drawing.Point(21, 109);
            this.lbl_Serach_By.Name = "lbl_Serach_By";
            this.lbl_Serach_By.Size = new System.Drawing.Size(176, 24);
            this.lbl_Serach_By.TabIndex = 7;
            this.lbl_Serach_By.Text = "Search Trainer By";
            // 
            // Frm_View_Trainer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID_Name);
            this.Controls.Add(this.cmb_search_Trainer_By);
            this.Controls.Add(this.lbl_Serach_By);
            this.Controls.Add(this.dgv_Trianer_List);
            this.Controls.Add(this.pnl_View_Trainer_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_Trainer_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Trainer List";
            this.Load += new System.EventHandler(this.Frm_View_Trainer_List_Load);
            this.pnl_View_Trainer_Header.ResumeLayout(false);
            this.pnl_View_Trainer_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trianer_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Trainer_Header;
        private System.Windows.Forms.Button btn_Trainer_List;
        private System.Windows.Forms.Button btn_Trainer_Add;
        private System.Windows.Forms.Button btn_Trainer_Update;
        private System.Windows.Forms.Label lbl_View_Trainer_List;
        private System.Windows.Forms.DataGridView dgv_Trianer_List;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_ID_Name;
        private System.Windows.Forms.ComboBox cmb_search_Trainer_By;
        private System.Windows.Forms.Label lbl_Serach_By;
    }
}