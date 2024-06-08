
namespace Well_Health_Gym_Application.Forms.User
{
    partial class Frm_Add_User_Management
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
            this.pnl_User = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.btn_Update_User = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.lbl_Add_User = new System.Windows.Forms.Label();
            this.pnl_Add_User = new System.Windows.Forms.Panel();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pnl_User.SuspendLayout();
            this.pnl_Add_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_User
            // 
            this.pnl_User.BackColor = System.Drawing.Color.Black;
            this.pnl_User.Controls.Add(this.btn_Back);
            this.pnl_User.Controls.Add(this.btn_Delete_User);
            this.pnl_User.Controls.Add(this.btn_Update_User);
            this.pnl_User.Controls.Add(this.btn_Add_User);
            this.pnl_User.Controls.Add(this.lbl_Add_User);
            this.pnl_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_User.Location = new System.Drawing.Point(0, 0);
            this.pnl_User.Name = "pnl_User";
            this.pnl_User.Size = new System.Drawing.Size(953, 100);
            this.pnl_User.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete_User.Location = new System.Drawing.Point(676, 63);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(129, 34);
            this.btn_Delete_User.TabIndex = 3;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = true;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // btn_Update_User
            // 
            this.btn_Update_User.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Update_User.Location = new System.Drawing.Point(410, 61);
            this.btn_Update_User.Name = "btn_Update_User";
            this.btn_Update_User.Size = new System.Drawing.Size(132, 34);
            this.btn_Update_User.TabIndex = 2;
            this.btn_Update_User.Text = "Update User";
            this.btn_Update_User.UseVisualStyleBackColor = true;
            this.btn_Update_User.Click += new System.EventHandler(this.btn_Update_User_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add_User.Location = new System.Drawing.Point(99, 67);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(114, 33);
            this.btn_Add_User.TabIndex = 1;
            this.btn_Add_User.Text = "Add User";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            // 
            // lbl_Add_User
            // 
            this.lbl_Add_User.AutoSize = true;
            this.lbl_Add_User.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Add_User.Location = new System.Drawing.Point(369, 0);
            this.lbl_Add_User.Name = "lbl_Add_User";
            this.lbl_Add_User.Size = new System.Drawing.Size(204, 50);
            this.lbl_Add_User.TabIndex = 0;
            this.lbl_Add_User.Text = "Add User";
            // 
            // pnl_Add_User
            // 
            this.pnl_Add_User.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Add_User.Controls.Add(this.tb_Username);
            this.pnl_Add_User.Controls.Add(this.cmb_UserRole);
            this.pnl_Add_User.Controls.Add(this.tb_ConfirmPassword);
            this.pnl_Add_User.Controls.Add(this.tb_Password);
            this.pnl_Add_User.Controls.Add(this.lbl_Confirm_Password);
            this.pnl_Add_User.Controls.Add(this.lbl_Password);
            this.pnl_Add_User.Controls.Add(this.lbl_Username);
            this.pnl_Add_User.Controls.Add(this.lbl_User_Role);
            this.pnl_Add_User.Location = new System.Drawing.Point(33, 143);
            this.pnl_Add_User.Name = "pnl_Add_User";
            this.pnl_Add_User.Size = new System.Drawing.Size(893, 455);
            this.pnl_Add_User.TabIndex = 1;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(478, 147);
            this.tb_Username.MaxLength = 16;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(254, 30);
            this.tb_Username.TabIndex = 8;
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.BackColor = System.Drawing.Color.Silver;
            this.cmb_UserRole.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cmb_UserRole.Location = new System.Drawing.Point(478, 64);
            this.cmb_UserRole.MaxLength = 60;
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(254, 32);
            this.cmb_UserRole.TabIndex = 7;
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(478, 333);
            this.tb_ConfirmPassword.MaxLength = 16;
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(254, 30);
            this.tb_ConfirmPassword.TabIndex = 6;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(478, 231);
            this.tb_Password.MaxLength = 16;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(254, 30);
            this.tb_Password.TabIndex = 5;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.BackColor = System.Drawing.Color.Black;
            this.lbl_Confirm_Password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(114, 333);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(192, 27);
            this.lbl_Confirm_Password.TabIndex = 3;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Black;
            this.lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(123, 234);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(105, 27);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Black;
            this.lbl_Username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(124, 150);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(110, 27);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.BackColor = System.Drawing.Color.Black;
            this.lbl_User_Role.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_User_Role.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.White;
            this.lbl_User_Role.Location = new System.Drawing.Point(123, 69);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(111, 27);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Black;
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.Location = new System.Drawing.Point(589, 624);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(164, 48);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add User";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Black;
            this.btn_Clear.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Clear.Location = new System.Drawing.Point(202, 624);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(164, 48);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Frm_Add_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pnl_Add_User);
            this.Controls.Add(this.pnl_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User Management";
            this.pnl_User.ResumeLayout(false);
            this.pnl_User.PerformLayout();
            this.pnl_Add_User.ResumeLayout(false);
            this.pnl_Add_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_User;
        private System.Windows.Forms.Label lbl_Add_User;
        private System.Windows.Forms.Panel pnl_Add_User;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.TextBox tb_ConfirmPassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Button btn_Update_User;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button btn_Clear;
    }
}