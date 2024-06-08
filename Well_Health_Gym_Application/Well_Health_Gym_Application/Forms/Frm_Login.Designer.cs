
namespace Well_Health_Gym_Application.Forms
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.pnl_Login_Page = new System.Windows.Forms.Panel();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.pnl_Login_Name = new System.Windows.Forms.Panel();
            this.pnl_Image = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.pnl_Login_Page.SuspendLayout();
            this.pnl_Login_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login_Page
            // 
            this.pnl_Login_Page.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Login_Page.Controls.Add(this.cmb_Username);
            this.pnl_Login_Page.Controls.Add(this.lbl_Error);
            this.pnl_Login_Page.Controls.Add(this.cmb_UserRole);
            this.pnl_Login_Page.Controls.Add(this.btn_Reset);
            this.pnl_Login_Page.Controls.Add(this.btn_Login);
            this.pnl_Login_Page.Controls.Add(this.tb_Password);
            this.pnl_Login_Page.Controls.Add(this.lbl_Password);
            this.pnl_Login_Page.Controls.Add(this.lbl_Username);
            this.pnl_Login_Page.Controls.Add(this.lbl_User_Role);
            this.pnl_Login_Page.Controls.Add(this.pnl_Login_Name);
            this.pnl_Login_Page.Location = new System.Drawing.Point(156, 12);
            this.pnl_Login_Page.Name = "pnl_Login_Page";
            this.pnl_Login_Page.Size = new System.Drawing.Size(429, 462);
            this.pnl_Login_Page.TabIndex = 0;
            // 
            // cmb_Username
            // 
            this.cmb_Username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_Username.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(170, 207);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(240, 32);
            this.cmb_Username.TabIndex = 2;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Error.Location = new System.Drawing.Point(112, 337);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(44, 18);
            this.lbl_Error.TabIndex = 10;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_UserRole.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cmb_UserRole.Location = new System.Drawing.Point(170, 137);
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(240, 32);
            this.cmb_UserRole.TabIndex = 1;
            this.cmb_UserRole.SelectedIndexChanged += new System.EventHandler(this.cmb_UserRole_SelectedIndexChanged_1);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Reset.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(230, 383);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(132, 40);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Login.Location = new System.Drawing.Point(65, 381);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(132, 44);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(170, 267);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(240, 33);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Niagara Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(26, 264);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(92, 36);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Niagara Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(27, 200);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(94, 36);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Niagara Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.Location = new System.Drawing.Point(26, 130);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(90, 36);
            this.lbl_User_Role.TabIndex = 1;
            this.lbl_User_Role.Text = "User Role";
            // 
            // pnl_Login_Name
            // 
            this.pnl_Login_Name.BackColor = System.Drawing.Color.Black;
            this.pnl_Login_Name.Controls.Add(this.pnl_Image);
            this.pnl_Login_Name.Controls.Add(this.lbl_Login);
            this.pnl_Login_Name.Location = new System.Drawing.Point(3, 3);
            this.pnl_Login_Name.Name = "pnl_Login_Name";
            this.pnl_Login_Name.Size = new System.Drawing.Size(426, 87);
            this.pnl_Login_Name.TabIndex = 0;
            // 
            // pnl_Image
            // 
            this.pnl_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Image.BackgroundImage")));
            this.pnl_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Image.Location = new System.Drawing.Point(3, 3);
            this.pnl_Image.Name = "pnl_Image";
            this.pnl_Image.Size = new System.Drawing.Size(115, 81);
            this.pnl_Image.TabIndex = 1;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Modern No. 20", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Login.Location = new System.Drawing.Point(173, 22);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(172, 48);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "LOGIN";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.Controls.Add(this.pnl_Login_Page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.pnl_Login_Page.ResumeLayout(false);
            this.pnl_Login_Page.PerformLayout();
            this.pnl_Login_Name.ResumeLayout(false);
            this.pnl_Login_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login_Page;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Panel pnl_Login_Name;
        private System.Windows.Forms.Panel pnl_Image;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.ComboBox cmb_Username;
    }
}