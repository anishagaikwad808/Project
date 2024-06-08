using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Well_Health_Gym_Application.Forms.Employee;
using Well_Health_Gym_Application.Forms.Enquiry;
using Well_Health_Gym_Application.Forms.Equipment;
using Well_Health_Gym_Application.Forms.Expence;
using Well_Health_Gym_Application.Forms.Member;
using Well_Health_Gym_Application.Forms.Package;
using Well_Health_Gym_Application.Forms.Payment;
using Well_Health_Gym_Application.Forms.Trainer;
using Well_Health_Gym_Application.Forms.User;
using Well_Health_Gym_Application.Report_Forms;

namespace Well_Health_Gym_Application.Forms
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Enquiry_Click(object sender, EventArgs e)
        {
            Frm_Enquiry_Details Obj = new Frm_Enquiry_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Equipment_Click(object sender, EventArgs e)
        {
            Frm_Add_Equipment Obj = new Frm_Add_Equipment();
            Obj.Show();
            this.Hide();
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Members Obj = new Frm_Add_New_Members();
            Obj.Show();
            this.Hide();
        }
        private void btn_Trainer_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Trainer Obj = new Frm_Add_New_Trainer();
            Obj.Show();
            this.Hide();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Frm_Add_User_Management Obj = new Frm_Add_User_Management();
            Obj.Show();
            this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Employee Obj = new Frm_Add_New_Employee();
            Obj.Show();
            this.Hide();
        }

        private void btn_Expense_Click(object sender, EventArgs e)
        {
            Frm_Add_Expence Obj = new Frm_Add_Expence();
            Obj.Show();
            this.Hide();
        }

        private void btn_Package_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Package Obj = new Frm_Add_New_Package();
            Obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = new DialogResult();

            Res = MessageBox.Show(" Are you sure..??", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                Global_Vars.URole = 0;

                Frm_Login log = new Frm_Login();
                log.Show();
                this.Hide();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            if (Global_Vars.URole == 2)
            {
                btn_Report.Enabled = false;
                btn_User.Enabled = false;
            }
            else if (Global_Vars.URole == 3)
            {
                btn_Employee.Enabled = false;
                btn_Expense.Enabled = false;
                btn_User.Enabled = false;
                btn_Report.Enabled = false;
            }
        }
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            Frm_Accept_Payment Obj = new Frm_Accept_Payment();
            Obj.Show();
            this.Hide();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Frm_Report_Main Obj = new Frm_Report_Main();
            Obj.Show();
            this.Hide();
        }
    }
}
