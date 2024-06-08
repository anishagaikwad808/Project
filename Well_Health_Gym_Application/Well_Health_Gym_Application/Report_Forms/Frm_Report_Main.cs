using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Well_Health_Gym_Application.Forms;
using Well_Health_Gym_Application.Forms.Member;

namespace Well_Health_Gym_Application.Report_Forms
{
    public partial class Frm_Report_Main : Form
    {
        public Frm_Report_Main()
        {
            InitializeComponent();
        }


        private void Frm_Report_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();

        }

        private void btn_Trainer_Click(object sender, EventArgs e)
        {
            Frm_Trainer_Report Obj = new Frm_Trainer_Report();
            Obj.Show();
            this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Frm_Employee_Report Obj = new Frm_Employee_Report();
            Obj.Show();
            this.Hide();
        }

        private void btn_Expence_Click(object sender, EventArgs e)
        {
            Frm_Expense_Report Obj = new Frm_Expense_Report();
            Obj.Show();
            this.Hide();
        }

        private void btn_Equipment_Click(object sender, EventArgs e)
        {
            Frm_Equipment_Report Obj = new Frm_Equipment_Report();
            Obj.Show();
            this.Hide();

        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            Frm_Member_Report Obj = new Frm_Member_Report();
            Obj.Show();
            this.Hide();
        }

        private void btn_Member_Bill_Click(object sender, EventArgs e)
        {
            Frm_View_Member Obj = new Frm_View_Member();
            Obj.Show();
            this.Hide();
        }
    }
}
