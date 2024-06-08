
namespace Well_Health_Gym_Application.Forms.Payment
{
    partial class Frm_View_Payment
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
            this.pnl_Accept_Payment = new System.Windows.Forms.Panel();
            this.lbl_Payment_List = new System.Windows.Forms.Label();
            this.btn_Payment_List = new System.Windows.Forms.Button();
            this.btn_Search_Payment = new System.Windows.Forms.Button();
            this.btn_Accept_Payment = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgv_Payment_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_ID_Name = new System.Windows.Forms.TextBox();
            this.cmb_search_Payment_By = new System.Windows.Forms.ComboBox();
            this.lbl_Serach_By = new System.Windows.Forms.Label();
            this.pnl_Accept_Payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Accept_Payment
            // 
            this.pnl_Accept_Payment.BackColor = System.Drawing.Color.Black;
            this.pnl_Accept_Payment.Controls.Add(this.lbl_Payment_List);
            this.pnl_Accept_Payment.Controls.Add(this.btn_Payment_List);
            this.pnl_Accept_Payment.Controls.Add(this.btn_Search_Payment);
            this.pnl_Accept_Payment.Controls.Add(this.btn_Accept_Payment);
            this.pnl_Accept_Payment.Controls.Add(this.btn_Back);
            this.pnl_Accept_Payment.Location = new System.Drawing.Point(2, 2);
            this.pnl_Accept_Payment.Name = "pnl_Accept_Payment";
            this.pnl_Accept_Payment.Size = new System.Drawing.Size(953, 100);
            this.pnl_Accept_Payment.TabIndex = 4;
            // 
            // lbl_Payment_List
            // 
            this.lbl_Payment_List.AutoSize = true;
            this.lbl_Payment_List.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Payment_List.Location = new System.Drawing.Point(330, 9);
            this.lbl_Payment_List.Name = "lbl_Payment_List";
            this.lbl_Payment_List.Size = new System.Drawing.Size(285, 50);
            this.lbl_Payment_List.TabIndex = 12;
            this.lbl_Payment_List.Text = "Payment List";
            // 
            // btn_Payment_List
            // 
            this.btn_Payment_List.BackColor = System.Drawing.Color.Silver;
            this.btn_Payment_List.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Payment_List.Location = new System.Drawing.Point(753, 62);
            this.btn_Payment_List.Name = "btn_Payment_List";
            this.btn_Payment_List.Size = new System.Drawing.Size(173, 36);
            this.btn_Payment_List.TabIndex = 4;
            this.btn_Payment_List.Text = "Payment List";
            this.btn_Payment_List.UseVisualStyleBackColor = false;
            this.btn_Payment_List.Click += new System.EventHandler(this.btn_Payment_List_Click);
            // 
            // btn_Search_Payment
            // 
            this.btn_Search_Payment.BackColor = System.Drawing.Color.Silver;
            this.btn_Search_Payment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Search_Payment.Location = new System.Drawing.Point(381, 62);
            this.btn_Search_Payment.Name = "btn_Search_Payment";
            this.btn_Search_Payment.Size = new System.Drawing.Size(173, 36);
            this.btn_Search_Payment.TabIndex = 3;
            this.btn_Search_Payment.Text = "Search Payment";
            this.btn_Search_Payment.UseVisualStyleBackColor = false;
            this.btn_Search_Payment.Click += new System.EventHandler(this.btn_Search_Payment_Click);
            // 
            // btn_Accept_Payment
            // 
            this.btn_Accept_Payment.BackColor = System.Drawing.Color.Silver;
            this.btn_Accept_Payment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept_Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Accept_Payment.Location = new System.Drawing.Point(30, 62);
            this.btn_Accept_Payment.Name = "btn_Accept_Payment";
            this.btn_Accept_Payment.Size = new System.Drawing.Size(173, 36);
            this.btn_Accept_Payment.TabIndex = 2;
            this.btn_Accept_Payment.Text = "Accept Payment";
            this.btn_Accept_Payment.UseVisualStyleBackColor = false;
            this.btn_Accept_Payment.Click += new System.EventHandler(this.btn_Accept_Payment_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(3, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_Payment_List
            // 
            this.dgv_Payment_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payment_List.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_Payment_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment_List.Location = new System.Drawing.Point(5, 150);
            this.dgv_Payment_List.Name = "dgv_Payment_List";
            this.dgv_Payment_List.ReadOnly = true;
            this.dgv_Payment_List.Size = new System.Drawing.Size(929, 499);
            this.dgv_Payment_List.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Salmon;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(808, 113);
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
            this.btn_Search.Location = new System.Drawing.Point(681, 113);
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
            this.tb_ID_Name.Location = new System.Drawing.Point(441, 116);
            this.tb_ID_Name.Name = "tb_ID_Name";
            this.tb_ID_Name.Size = new System.Drawing.Size(213, 30);
            this.tb_ID_Name.TabIndex = 9;
            this.tb_ID_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Id_Name_KeyPress);
            // 
            // cmb_search_Payment_By
            // 
            this.cmb_search_Payment_By.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_search_Payment_By.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search_Payment_By.FormattingEnabled = true;
            this.cmb_search_Payment_By.Items.AddRange(new object[] {
            "ID"});
            this.cmb_search_Payment_By.Location = new System.Drawing.Point(236, 115);
            this.cmb_search_Payment_By.Name = "cmb_search_Payment_By";
            this.cmb_search_Payment_By.Size = new System.Drawing.Size(173, 29);
            this.cmb_search_Payment_By.TabIndex = 8;
            // 
            // lbl_Serach_By
            // 
            this.lbl_Serach_By.AutoSize = true;
            this.lbl_Serach_By.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Serach_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Serach_By.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Serach_By.Location = new System.Drawing.Point(20, 113);
            this.lbl_Serach_By.Name = "lbl_Serach_By";
            this.lbl_Serach_By.Size = new System.Drawing.Size(186, 24);
            this.lbl_Serach_By.TabIndex = 7;
            this.lbl_Serach_By.Text = "Search Payment By";
            // 
            // Frm_View_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID_Name);
            this.Controls.Add(this.cmb_search_Payment_By);
            this.Controls.Add(this.lbl_Serach_By);
            this.Controls.Add(this.dgv_Payment_List);
            this.Controls.Add(this.pnl_Accept_Payment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Payment";
            this.Load += new System.EventHandler(this.View_Payment_Load);
            this.pnl_Accept_Payment.ResumeLayout(false);
            this.pnl_Accept_Payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Accept_Payment;
        private System.Windows.Forms.Button btn_Payment_List;
        private System.Windows.Forms.Button btn_Search_Payment;
        private System.Windows.Forms.Button btn_Accept_Payment;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dgv_Payment_List;
        private System.Windows.Forms.Label lbl_Payment_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_ID_Name;
        private System.Windows.Forms.ComboBox cmb_search_Payment_By;
        private System.Windows.Forms.Label lbl_Serach_By;
    }
}