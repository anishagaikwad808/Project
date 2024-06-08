using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Package
{
    public partial class Frm_Package_List : Form
    {
        public Frm_Package_List()
        {
            InitializeComponent();
        }

        private void Frm_Package_List_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Package_List, "Select ID,Name,Date,Monthly_Charges,Package_3Month_Charges,Package_6Month_Charges,Yearly_Charges From Package_Details ");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }
        private void btn_Add_Package_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Package Obj = new Frm_Add_New_Package();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_Package_Click(object sender, EventArgs e)
        {
            Frm_Update_Package Obj = new Frm_Update_Package();
            Obj.Show();
            this.Hide();
        }

        private void btn_Package_List_Click(object sender, EventArgs e)
        {
            Frm_Package_List Obj = new Frm_Package_List();
            Obj.Show();
            this.Hide();
        }

        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_search_Package_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            else if (cmb_search_Package_By.Text == "Name")
            {
                if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Package_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Package_List, "Select * From Package_Details Where ID = '" + tb_ID_Name.Text + "'");
            }
            else if (cmb_search_Package_By.Text == "Name")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Package_List, "Select * From Package_Details Where Name = '" + tb_ID_Name.Text + "'");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_search_Package_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Package_List, "Select ID,Name,Date,Monthly_Charges,Package_3Month_Charges,Package_6Month_Charges,Yearly_Charges From Package_Details  ");
        }
    
    }
}
