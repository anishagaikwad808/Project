
namespace Well_Health_Gym_Application.Report_Forms
{
    partial class Frm_Member_Bill
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
            this.crv_Member_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crv_Member_Bill
            // 
            this.crv_Member_Bill.ActiveViewIndex = -1;
            this.crv_Member_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Member_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Member_Bill.Location = new System.Drawing.Point(0, 51);
            this.crv_Member_Bill.Name = "crv_Member_Bill";
            this.crv_Member_Bill.ReuseParameterValuesOnRefresh = true;
            this.crv_Member_Bill.ShowTextSearchButton = false;
            this.crv_Member_Bill.Size = new System.Drawing.Size(953, 633);
            this.crv_Member_Bill.TabIndex = 21;
            this.crv_Member_Bill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Back.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Back.Location = new System.Drawing.Point(0, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 31);
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Frm_Member_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.crv_Member_Bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Member_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Bill";
            this.Load += new System.EventHandler(this.Frm_Member_Bill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Member_Bill;
        private System.Windows.Forms.Button btn_Back;
    }
}