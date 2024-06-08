using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Equipment
{
    public partial class Frm_View_Equipment : Form
    {
        public Frm_View_Equipment()
        {
            InitializeComponent();
        }

        private void Frm_View_Equipment_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Equipment_List, "Select Equi_ID,Equi_Name,Price,Date_Of_Purchase,Muscles_Used,Description From Equipment_Details ");
        }

        private void btn_Add_Equipment_Click(object sender, EventArgs e)
        {
            Frm_Add_Equipment Obj = new Frm_Add_Equipment();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Equipment_Click(object sender, EventArgs e)
        {
            Frm_View_Equipment Obj = new Frm_View_Equipment();
            Obj.Show();
            this.Hide();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }

        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_search_Equipment_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            else if (cmb_search_Equipment_By.Text == "Name")
            {
                if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Equipment_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Equipment_List, "Select * From Equipment_Details Where Equi_ID = '" + tb_ID_Name.Text + "'");
            }
            else if (cmb_search_Equipment_By.Text == "Name")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Equipment_List, "Select * From Equipment_Details Where Equi_Name = '" + tb_ID_Name.Text + "'");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_search_Equipment_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Equipment_List, "Select Equi_ID,Equi_Name,Price,Date_Of_Purchase,Muscles_Used,Description From Equipment_Details ");
        }
    }
}
