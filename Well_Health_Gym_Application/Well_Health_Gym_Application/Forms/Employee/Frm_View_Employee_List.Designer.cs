
namespace Well_Health_Gym_Application.Forms.Employee
{
    partial class Frm_View_Employee_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_View_Emp_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Emp_List = new System.Windows.Forms.Button();
            this.lbl_Emp_List = new System.Windows.Forms.Label();
            this.btn_Emp_Add = new System.Windows.Forms.Button();
            this.btn_Emp_Update = new System.Windows.Forms.Button();
            this.dgv_Emp_List = new System.Windows.Forms.DataGridView();
            this.lbl_Serach_By = new System.Windows.Forms.Label();
            this.cmb_search_Employee_By = new System.Windows.Forms.ComboBox();
            this.tb_ID_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_View_Emp_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Emp_Header
            // 
            this.pnl_View_Emp_Header.BackColor = System.Drawing.Color.Black;
            this.pnl_View_Emp_Header.Controls.Add(this.btn_Back);
            this.pnl_View_Emp_Header.Controls.Add(this.btn_Emp_List);
            this.pnl_View_Emp_Header.Controls.Add(this.lbl_Emp_List);
            this.pnl_View_Emp_Header.Controls.Add(this.btn_Emp_Add);
            this.pnl_View_Emp_Header.Controls.Add(this.btn_Emp_Update);
            this.pnl_View_Emp_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_View_Emp_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_View_Emp_Header.Name = "pnl_View_Emp_Header";
            this.pnl_View_Emp_Header.Size = new System.Drawing.Size(953, 100);
            this.pnl_View_Emp_Header.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(0, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Emp_List
            // 
            this.btn_Emp_List.BackColor = System.Drawing.Color.Silver;
            this.btn_Emp_List.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Emp_List.Location = new System.Drawing.Point(615, 60);
            this.btn_Emp_List.Name = "btn_Emp_List";
            this.btn_Emp_List.Size = new System.Drawing.Size(195, 37);
            this.btn_Emp_List.TabIndex = 4;
            this.btn_Emp_List.Text = "Employee List";
            this.btn_Emp_List.UseVisualStyleBackColor = false;
            // 
            // lbl_Emp_List
            // 
            this.lbl_Emp_List.AutoSize = true;
            this.lbl_Emp_List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Emp_List.Location = new System.Drawing.Point(312, 0);
            this.lbl_Emp_List.Name = "lbl_Emp_List";
            this.lbl_Emp_List.Size = new System.Drawing.Size(303, 50);
            this.lbl_Emp_List.TabIndex = 0;
            this.lbl_Emp_List.Text = "Employee List";
            // 
            // btn_Emp_Add
            // 
            this.btn_Emp_Add.BackColor = System.Drawing.Color.Silver;
            this.btn_Emp_Add.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Emp_Add.Location = new System.Drawing.Point(349, 60);
            this.btn_Emp_Add.Name = "btn_Emp_Add";
            this.btn_Emp_Add.Size = new System.Drawing.Size(161, 37);
            this.btn_Emp_Add.TabIndex = 3;
            this.btn_Emp_Add.Text = "Add Employee";
            this.btn_Emp_Add.UseVisualStyleBackColor = false;
            this.btn_Emp_Add.Click += new System.EventHandler(this.btn_Emp_Add_Click);
            // 
            // btn_Emp_Update
            // 
            this.btn_Emp_Update.BackColor = System.Drawing.Color.Silver;
            this.btn_Emp_Update.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Emp_Update.Location = new System.Drawing.Point(55, 60);
            this.btn_Emp_Update.Name = "btn_Emp_Update";
            this.btn_Emp_Update.Size = new System.Drawing.Size(175, 37);
            this.btn_Emp_Update.TabIndex = 2;
            this.btn_Emp_Update.Text = "Update Employee";
            this.btn_Emp_Update.UseVisualStyleBackColor = false;
            this.btn_Emp_Update.Click += new System.EventHandler(this.btn_Emp_Update_Click);
            // 
            // dgv_Emp_List
            // 
            this.dgv_Emp_List.AllowUserToAddRows = false;
            this.dgv_Emp_List.AllowUserToDeleteRows = false;
            this.dgv_Emp_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Emp_List.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Emp_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Emp_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp_List.Location = new System.Drawing.Point(12, 153);
            this.dgv_Emp_List.Name = "dgv_Emp_List";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Emp_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Emp_List.Size = new System.Drawing.Size(929, 506);
            this.dgv_Emp_List.TabIndex = 1;
            // 
            // lbl_Serach_By
            // 
            this.lbl_Serach_By.AutoSize = true;
            this.lbl_Serach_By.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Serach_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Serach_By.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Serach_By.Location = new System.Drawing.Point(29, 116);
            this.lbl_Serach_By.Name = "lbl_Serach_By";
            this.lbl_Serach_By.Size = new System.Drawing.Size(195, 24);
            this.lbl_Serach_By.TabIndex = 2;
            this.lbl_Serach_By.Text = "Search Employee By";
            this.lbl_Serach_By.Click += new System.EventHandler(this.lbl_Serach_By_Click);
            // 
            // cmb_search_Employee_By
            // 
            this.cmb_search_Employee_By.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search_Employee_By.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_Employee_By.FormattingEnabled = true;
            this.cmb_search_Employee_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_search_Employee_By.Location = new System.Drawing.Point(245, 118);
            this.cmb_search_Employee_By.Name = "cmb_search_Employee_By";
            this.cmb_search_Employee_By.Size = new System.Drawing.Size(173, 29);
            this.cmb_search_Employee_By.TabIndex = 3;
            this.cmb_search_Employee_By.SelectedIndexChanged += new System.EventHandler(this.cmb_search_Employee_By_SelectedIndexChanged);
            // 
            // tb_ID_Name
            // 
            this.tb_ID_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID_Name.Location = new System.Drawing.Point(450, 119);
            this.tb_ID_Name.Name = "tb_ID_Name";
            this.tb_ID_Name.Size = new System.Drawing.Size(213, 30);
            this.tb_ID_Name.TabIndex = 4;
            this.tb_ID_Name.TextChanged += new System.EventHandler(this.tb_ID_Name_TextChanged);
            this.tb_ID_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Id_Name_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Salmon;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(690, 116);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 31);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Salmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(817, 116);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(111, 31);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID_Name);
            this.Controls.Add(this.cmb_search_Employee_By);
            this.Controls.Add(this.lbl_Serach_By);
            this.Controls.Add(this.dgv_Emp_List);
            this.Controls.Add(this.pnl_View_Emp_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_View_Employee_List_Load);
            this.pnl_View_Emp_Header.ResumeLayout(false);
            this.pnl_View_Emp_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Emp_Header;
        private System.Windows.Forms.Label lbl_Emp_List;
        private System.Windows.Forms.DataGridView dgv_Emp_List;
        private System.Windows.Forms.Button btn_Emp_List;
        private System.Windows.Forms.Button btn_Emp_Add;
        private System.Windows.Forms.Button btn_Emp_Update;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Serach_By;
        private System.Windows.Forms.ComboBox cmb_search_Employee_By;
        private System.Windows.Forms.TextBox tb_ID_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
    }
}