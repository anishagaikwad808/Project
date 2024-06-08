﻿
namespace Well_Health_Gym_Application.Report_Forms
{
    partial class Frm_Equipment_Report
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
            this.pnl_Equipment = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Employee_Report = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_Search_ = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnl_Equipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Equipment
            // 
            this.pnl_Equipment.BackColor = System.Drawing.Color.Black;
            this.pnl_Equipment.Controls.Add(this.btn_Back);
            this.pnl_Equipment.Controls.Add(this.lbl_Employee_Report);
            this.pnl_Equipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Equipment.Location = new System.Drawing.Point(0, 0);
            this.pnl_Equipment.Name = "pnl_Equipment";
            this.pnl_Equipment.Size = new System.Drawing.Size(953, 66);
            this.pnl_Equipment.TabIndex = 3;
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
            // lbl_Employee_Report
            // 
            this.lbl_Employee_Report.AutoSize = true;
            this.lbl_Employee_Report.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Employee_Report.Location = new System.Drawing.Point(323, 0);
            this.lbl_Employee_Report.Name = "lbl_Employee_Report";
            this.lbl_Employee_Report.Size = new System.Drawing.Size(380, 50);
            this.lbl_Employee_Report.TabIndex = 0;
            this.lbl_Employee_Report.Text = "Equipment Report";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(781, 72);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(134, 34);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_To
            // 
            this.dtp_To.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To.Location = new System.Drawing.Point(563, 77);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(200, 30);
            this.dtp_To.TabIndex = 18;
            // 
            // dtp_From
            // 
            this.dtp_From.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From.Location = new System.Drawing.Point(297, 77);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(200, 30);
            this.dtp_From.TabIndex = 17;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_To.Location = new System.Drawing.Point(519, 77);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(38, 25);
            this.lbl_To.TabIndex = 16;
            this.lbl_To.Text = "To";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_From.Location = new System.Drawing.Point(226, 73);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(65, 25);
            this.lbl_From.TabIndex = 15;
            this.lbl_From.Text = "From";
            // 
            // lbl_Search_
            // 
            this.lbl_Search_.AutoSize = true;
            this.lbl_Search_.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Search_.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Search_.Location = new System.Drawing.Point(18, 76);
            this.lbl_Search_.Name = "lbl_Search_";
            this.lbl_Search_.Size = new System.Drawing.Size(179, 25);
            this.lbl_Search_.TabIndex = 14;
            this.lbl_Search_.Text = "Search DateWise";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 123);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(953, 558);
            this.crystalReportViewer1.TabIndex = 20;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Equipment_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.pnl_Equipment);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.lbl_Search_);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Equipment_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Report";
            this.pnl_Equipment.ResumeLayout(false);
            this.pnl_Equipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Equipment;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Employee_Report;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_Search_;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}