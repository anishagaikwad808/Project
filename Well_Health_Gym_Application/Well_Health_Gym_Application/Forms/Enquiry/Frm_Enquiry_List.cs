using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Enquiry
{
    public partial class Frm_Enquiry_List : Form
    {
        public Frm_Enquiry_List()
        {
            InitializeComponent();
        }

        private void Frm_Enquiry_List_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Enquiry_List, "Select ID,Name,Mob_No,Count,Date_Of_Enquiry,Refered_By,Note From Enquiry_Details ");
        }
         private void btn_Add_Enquiry_Click(object sender, EventArgs e)
        {
            Frm_Enquiry_Details Obj = new Frm_Enquiry_Details();
            Obj.Show();
            this.Hide();
        }
        private void btn_Enquiry_List_Click(object sender, EventArgs e)
        {
            Frm_Enquiry_List Obj = new Frm_Enquiry_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main obj = new Frm_Main();
            obj.Show();
            this.Hide();
        }

        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_search_Enquiry_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            else if (cmb_search_Enquiry_By.Text == "Name")
            {
                if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Enquiry_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Enquiry_List, "Select * From Enquiry_Details Where ID = '" + tb_ID_Name.Text + "'");
            }
            else if (cmb_search_Enquiry_By.Text == "Name")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Enquiry_List, "Select * From Enquiry_Details Where Name = '" + tb_ID_Name.Text + "'");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_search_Enquiry_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Enquiry_List, "Select ID,Name,Mob_No,Count,Date_Of_Enquiry,Refered_By,Note From Enquiry_Details ");
        }
    }
}
