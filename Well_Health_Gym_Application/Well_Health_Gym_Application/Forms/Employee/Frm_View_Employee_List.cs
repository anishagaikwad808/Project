using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Employee
{
    public partial class Frm_View_Employee_List : Form
    {
        public Frm_View_Employee_List()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }

        private void Frm_View_Employee_List_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Emp_List, "Select Emp_ID,Name,Mob_No,Address,Join_Date,Possition,Adhhar_No,Salary,Bank_Details From Employee_Details ");
        }

        private void btn_Emp_Update_Click(object sender, EventArgs e)
        {
            Frm_Update_Employee_Details Obj = new Frm_Update_Employee_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Emp_Add_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Employee Obj = new Frm_Add_New_Employee();
            Obj.Show();
            this.Hide();
        }

        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cmb_search_Employee_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            else if (cmb_search_Employee_By.Text == "Name")
            {
                if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Employee_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Emp_List, "Select * From Employee_Details Where Emp_ID = '" + tb_ID_Name.Text + "'");
            }
            else if (cmb_search_Employee_By.Text == "Name")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Emp_List, "Select * From Employee_Details Where Name = '" + tb_ID_Name.Text + "'");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_search_Employee_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Emp_List, "Select Emp_ID,Name,Mob_No,Address,Join_Date,Possition,Adhhar_No,Salary,Bank_Details From Employee_Details ");
        }

        private void tb_ID_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_search_Employee_By_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Serach_By_Click(object sender, EventArgs e)
        {

        }
    }
}
