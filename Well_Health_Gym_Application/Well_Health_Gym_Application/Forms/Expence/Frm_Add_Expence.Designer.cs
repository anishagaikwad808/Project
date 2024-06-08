
namespace Well_Health_Gym_Application.Forms.Expence
{
    partial class Frm_Add_Expence
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Expence_List = new System.Windows.Forms.Button();
            this.btn_Add_Expence = new System.Windows.Forms.Button();
            this.lbl_Add_Expence = new System.Windows.Forms.Label();
            this.pnl_Expence_Details = new System.Windows.Forms.Panel();
            this.cmb_BillType = new System.Windows.Forms.ComboBox();
            this.cmb_Paid_By = new System.Windows.Forms.ComboBox();
            this.dtp_Expence_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Amount_Paid = new System.Windows.Forms.TextBox();
            this.tb_Details = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.lbl_Paid_By = new System.Windows.Forms.Label();
            this.lbl_Bill_Type = new System.Windows.Forms.Label();
            this.lbl_Expence_Date = new System.Windows.Forms.Label();
            this.lbl_Amount_Paid = new System.Windows.Forms.Label();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_Expence_Id = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Expence_Header.SuspendLayout();
            this.pnl_Expence_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Expence_Header
            // 
            this.pnl_Expence_Header.BackColor = System.Drawing.Color.Black;
            this.pnl_Expence_Header.Controls.Add(this.btn_Back);
            this.pnl_Expence_Header.Controls.Add(this.btn_Expence_List);
            this.pnl_Expence_Header.Controls.Add(this.btn_Add_Expence);
            this.pnl_Expence_Header.Controls.Add(this.lbl_Add_Expence);
            this.pnl_Expence_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Expence_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Expence_Header.Name = "pnl_Expence_Header";
            this.pnl_Expence_Header.Size = new System.Drawing.Size(953, 101);
            this.pnl_Expence_Header.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(0, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Expence_List
            // 
            this.btn_Expence_List.BackColor = System.Drawing.Color.Silver;
            this.btn_Expence_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expence_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Expence_List.Location = new System.Drawing.Point(592, 53);
            this.btn_Expence_List.Name = "btn_Expence_List";
            this.btn_Expence_List.Size = new System.Drawing.Size(145, 36);
            this.btn_Expence_List.TabIndex = 10;
            this.btn_Expence_List.Text = "Expence List";
            this.btn_Expence_List.UseVisualStyleBackColor = false;
            this.btn_Expence_List.Click += new System.EventHandler(this.btn_Expence_List_Click);
            // 
            // btn_Add_Expence
            // 
            this.btn_Add_Expence.BackColor = System.Drawing.Color.Silver;
            this.btn_Add_Expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Expence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add_Expence.Location = new System.Drawing.Point(190, 54);
            this.btn_Add_Expence.Name = "btn_Add_Expence";
            this.btn_Add_Expence.Size = new System.Drawing.Size(177, 36);
            this.btn_Add_Expence.TabIndex = 9;
            this.btn_Add_Expence.Text = "Add Expence";
            this.btn_Add_Expence.UseVisualStyleBackColor = false;
            this.btn_Add_Expence.Click += new System.EventHandler(this.btn_Add_Expence_Click);
            // 
            // lbl_Add_Expence
            // 
            this.lbl_Add_Expence.AutoSize = true;
            this.lbl_Add_Expence.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Expence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Add_Expence.Location = new System.Drawing.Point(321, 0);
            this.lbl_Add_Expence.Name = "lbl_Add_Expence";
            this.lbl_Add_Expence.Size = new System.Drawing.Size(277, 50);
            this.lbl_Add_Expence.TabIndex = 0;
            this.lbl_Add_Expence.Text = "Add Expence";
            // 
            // pnl_Expence_Details
            // 
            this.pnl_Expence_Details.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Expence_Details.Controls.Add(this.cmb_BillType);
            this.pnl_Expence_Details.Controls.Add(this.cmb_Paid_By);
            this.pnl_Expence_Details.Controls.Add(this.dtp_Expence_Date);
            this.pnl_Expence_Details.Controls.Add(this.tb_Amount_Paid);
            this.pnl_Expence_Details.Controls.Add(this.tb_Details);
            this.pnl_Expence_Details.Controls.Add(this.tb_Id);
            this.pnl_Expence_Details.Controls.Add(this.lbl_Paid_By);
            this.pnl_Expence_Details.Controls.Add(this.lbl_Bill_Type);
            this.pnl_Expence_Details.Controls.Add(this.lbl_Expence_Date);
            this.pnl_Expence_Details.Controls.Add(this.lbl_Amount_Paid);
            this.pnl_Expence_Details.Controls.Add(this.lbl_Details);
            this.pnl_Expence_Details.Controls.Add(this.lbl_Expence_Id);
            this.pnl_Expence_Details.Location = new System.Drawing.Point(25, 146);
            this.pnl_Expence_Details.Name = "pnl_Expence_Details";
            this.pnl_Expence_Details.Size = new System.Drawing.Size(899, 479);
            this.pnl_Expence_Details.TabIndex = 1;
            // 
            // cmb_BillType
            // 
            this.cmb_BillType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_BillType.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BillType.FormattingEnabled = true;
            this.cmb_BillType.Items.AddRange(new object[] {
            "Electicity Bill",
            "Water Bill"});
            this.cmb_BillType.Location = new System.Drawing.Point(230, 191);
            this.cmb_BillType.Name = "cmb_BillType";
            this.cmb_BillType.Size = new System.Drawing.Size(218, 32);
            this.cmb_BillType.TabIndex = 2;
            // 
            // cmb_Paid_By
            // 
            this.cmb_Paid_By.BackColor = System.Drawing.Color.Silver;
            this.cmb_Paid_By.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Paid_By.FormattingEnabled = true;
            this.cmb_Paid_By.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmb_Paid_By.Location = new System.Drawing.Point(230, 377);
            this.cmb_Paid_By.MaxLength = 40;
            this.cmb_Paid_By.Name = "cmb_Paid_By";
            this.cmb_Paid_By.Size = new System.Drawing.Size(218, 32);
            this.cmb_Paid_By.TabIndex = 3;
            // 
            // dtp_Expence_Date
            // 
            this.dtp_Expence_Date.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expence_Date.Location = new System.Drawing.Point(639, 59);
            this.dtp_Expence_Date.Name = "dtp_Expence_Date";
            this.dtp_Expence_Date.Size = new System.Drawing.Size(200, 30);
            this.dtp_Expence_Date.TabIndex = 4;
            // 
            // tb_Amount_Paid
            // 
            this.tb_Amount_Paid.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount_Paid.Location = new System.Drawing.Point(639, 379);
            this.tb_Amount_Paid.MaxLength = 10;
            this.tb_Amount_Paid.Name = "tb_Amount_Paid";
            this.tb_Amount_Paid.Size = new System.Drawing.Size(218, 30);
            this.tb_Amount_Paid.TabIndex = 6;
            // 
            // tb_Details
            // 
            this.tb_Details.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Details.Location = new System.Drawing.Point(639, 194);
            this.tb_Details.MaxLength = 60;
            this.tb_Details.Multiline = true;
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.Size = new System.Drawing.Size(218, 130);
            this.tb_Details.TabIndex = 5;
            // 
            // tb_Id
            // 
            this.tb_Id.Enabled = false;
            this.tb_Id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(230, 59);
            this.tb_Id.MaxLength = 12;
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(218, 30);
            this.tb_Id.TabIndex = 1;
            // 
            // lbl_Paid_By
            // 
            this.lbl_Paid_By.AutoSize = true;
            this.lbl_Paid_By.BackColor = System.Drawing.Color.Black;
            this.lbl_Paid_By.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Paid_By.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_By.ForeColor = System.Drawing.Color.White;
            this.lbl_Paid_By.Location = new System.Drawing.Point(50, 383);
            this.lbl_Paid_By.Name = "lbl_Paid_By";
            this.lbl_Paid_By.Size = new System.Drawing.Size(85, 26);
            this.lbl_Paid_By.TabIndex = 5;
            this.lbl_Paid_By.Text = "Paid By";
            // 
            // lbl_Bill_Type
            // 
            this.lbl_Bill_Type.AutoSize = true;
            this.lbl_Bill_Type.BackColor = System.Drawing.Color.Black;
            this.lbl_Bill_Type.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Bill_Type.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Type.ForeColor = System.Drawing.Color.White;
            this.lbl_Bill_Type.Location = new System.Drawing.Point(50, 191);
            this.lbl_Bill_Type.Name = "lbl_Bill_Type";
            this.lbl_Bill_Type.Size = new System.Drawing.Size(135, 26);
            this.lbl_Bill_Type.TabIndex = 4;
            this.lbl_Bill_Type.Text = "Expence Type";
            // 
            // lbl_Expence_Date
            // 
            this.lbl_Expence_Date.AutoSize = true;
            this.lbl_Expence_Date.BackColor = System.Drawing.Color.Black;
            this.lbl_Expence_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Expence_Date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Expence_Date.Location = new System.Drawing.Point(480, 63);
            this.lbl_Expence_Date.Name = "lbl_Expence_Date";
            this.lbl_Expence_Date.Size = new System.Drawing.Size(134, 26);
            this.lbl_Expence_Date.TabIndex = 3;
            this.lbl_Expence_Date.Text = "Expence Date";
            // 
            // lbl_Amount_Paid
            // 
            this.lbl_Amount_Paid.AutoSize = true;
            this.lbl_Amount_Paid.BackColor = System.Drawing.Color.Black;
            this.lbl_Amount_Paid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Amount_Paid.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount_Paid.ForeColor = System.Drawing.Color.White;
            this.lbl_Amount_Paid.Location = new System.Drawing.Point(470, 383);
            this.lbl_Amount_Paid.Name = "lbl_Amount_Paid";
            this.lbl_Amount_Paid.Size = new System.Drawing.Size(131, 26);
            this.lbl_Amount_Paid.TabIndex = 2;
            this.lbl_Amount_Paid.Text = "Amount Paid";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.BackColor = System.Drawing.Color.Black;
            this.lbl_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Details.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Details.Location = new System.Drawing.Point(470, 197);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(156, 26);
            this.lbl_Details.TabIndex = 1;
            this.lbl_Details.Text = "Expence Details";
            // 
            // lbl_Expence_Id
            // 
            this.lbl_Expence_Id.AutoSize = true;
            this.lbl_Expence_Id.BackColor = System.Drawing.Color.Black;
            this.lbl_Expence_Id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Expence_Id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Expence_Id.Location = new System.Drawing.Point(50, 59);
            this.lbl_Expence_Id.Name = "lbl_Expence_Id";
            this.lbl_Expence_Id.Size = new System.Drawing.Size(112, 26);
            this.lbl_Expence_Id.TabIndex = 0;
            this.lbl_Expence_Id.Text = "Expence Id";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Black;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.Location = new System.Drawing.Point(162, 633);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(99, 39);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Black;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(695, 633);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 39);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_Add_Expence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.pnl_Expence_Details);
            this.Controls.Add(this.pnl_Expence_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_Expence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Add_Expence_Load);
            this.pnl_Expence_Header.ResumeLayout(false);
            this.pnl_Expence_Header.PerformLayout();
            this.pnl_Expence_Details.ResumeLayout(false);
            this.pnl_Expence_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Expence_Header;
        private System.Windows.Forms.Button btn_Expence_List;
        private System.Windows.Forms.Button btn_Add_Expence;
        private System.Windows.Forms.Label lbl_Add_Expence;
        private System.Windows.Forms.Panel pnl_Expence_Details;
        private System.Windows.Forms.ComboBox cmb_Paid_By;
        private System.Windows.Forms.DateTimePicker dtp_Expence_Date;
        private System.Windows.Forms.TextBox tb_Amount_Paid;
        private System.Windows.Forms.TextBox tb_Details;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label lbl_Paid_By;
        private System.Windows.Forms.Label lbl_Bill_Type;
        private System.Windows.Forms.Label lbl_Expence_Date;
        private System.Windows.Forms.Label lbl_Amount_Paid;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Expence_Id;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cmb_BillType;
    }
}