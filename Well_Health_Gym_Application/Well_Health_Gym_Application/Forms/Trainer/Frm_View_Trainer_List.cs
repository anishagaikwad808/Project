using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Trainer
{
    public partial class Frm_View_Trainer_List : Form
    {
        public Frm_View_Trainer_List()
        {
            InitializeComponent();
        }

        private void Frm_View_Trainer_List_Load(object sender, EventArgs e)
        {
            cmb_search_Trainer_By.SelectedIndex = -1;
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Trianer_List, "Select ID,Name,Mob_No,Adhhar_No,Experience,Address,Join_Date,Designation,Salary,Bank_Details From Trainer_Details ");
        }

        private void btn_Trainer_Update_Click(object sender, EventArgs e)
        {
            Frm_Update_Trainer_Details Obj = new Frm_Update_Trainer_Details();
            Obj.Show();
            this.Hide();           
        }

        private void btn_Trainer_Add_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Trainer Obj = new Frm_Add_New_Trainer();
            Obj.Show();
            this.Hide();
        }

        private void btn_Trainer_List_Click(object sender, EventArgs e)
        {
            Frm_View_Trainer_List Obj = new Frm_View_Trainer_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Trainer_By.Text == "ID")
            {
              Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Trianer_List,"Select * From Trainer_Details Where ID = '" + tb_ID_Name.Text + "'");
            }
            else if (cmb_search_Trainer_By.Text == "Name")
            {
              Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Trianer_List,"Select * From Trainer_Details Where Name = '" + tb_ID_Name.Text + "'");
            }
        }
        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_search_Trainer_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            else if (cmb_search_Trainer_By.Text == "Name")
            {
                if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            cmb_search_Trainer_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
           Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Trianer_List, "Select ID,Name,Mob_No,Adhhar_No,Experience,Address,Join_Date,Designation,Salary,Bank_Details From Trainer_Details ");
        }
    }
}
