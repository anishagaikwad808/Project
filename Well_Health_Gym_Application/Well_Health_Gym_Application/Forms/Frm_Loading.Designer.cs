
namespace Well_Health_Gym_Application.Forms
{
    partial class Frm_Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Loading));
            this.lbl_WellHealth = new System.Windows.Forms.Label();
            this.lbl_GymApp = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Loading = new System.Windows.Forms.Panel();
            this.pb_Loading = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.pnl_Loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_WellHealth
            // 
            this.lbl_WellHealth.AutoSize = true;
            this.lbl_WellHealth.Font = new System.Drawing.Font("Playbill", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WellHealth.Location = new System.Drawing.Point(138, 97);
            this.lbl_WellHealth.Name = "lbl_WellHealth";
            this.lbl_WellHealth.Size = new System.Drawing.Size(327, 81);
            this.lbl_WellHealth.TabIndex = 0;
            this.lbl_WellHealth.Text = "WELL HEALTH";
            // 
            // lbl_GymApp
            // 
            this.lbl_GymApp.AutoSize = true;
            this.lbl_GymApp.Font = new System.Drawing.Font("Playbill", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GymApp.Location = new System.Drawing.Point(181, 193);
            this.lbl_GymApp.Name = "lbl_GymApp";
            this.lbl_GymApp.Size = new System.Drawing.Size(222, 81);
            this.lbl_GymApp.TabIndex = 1;
            this.lbl_GymApp.Text = "GYM APP";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(242, 10);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(123, 72);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 2;
            this.pb_Logo.TabStop = false;
            // 
            // pnl_Loading
            // 
            this.pnl_Loading.BackColor = System.Drawing.Color.Black;
            this.pnl_Loading.Controls.Add(this.pb_Loading);
            this.pnl_Loading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_Loading.Location = new System.Drawing.Point(45, 304);
            this.pnl_Loading.Name = "pnl_Loading";
            this.pnl_Loading.Size = new System.Drawing.Size(500, 85);
            this.pnl_Loading.TabIndex = 3;
            // 
            // pb_Loading
            // 
            this.pb_Loading.ForeColor = System.Drawing.Color.White;
            this.pb_Loading.Location = new System.Drawing.Point(70, 35);
            this.pb_Loading.Name = "pb_Loading";
            this.pb_Loading.Size = new System.Drawing.Size(350, 23);
            this.pb_Loading.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(586, 411);
            this.Controls.Add(this.pnl_Loading);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.lbl_GymApp);
            this.Controls.Add(this.lbl_WellHealth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Frm_Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.pnl_Loading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WellHealth;
        private System.Windows.Forms.Label lbl_GymApp;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel pnl_Loading;
        private System.Windows.Forms.ProgressBar pb_Loading;
        private System.Windows.Forms.Timer timer;
    }
}