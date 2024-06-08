using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Member
{
    public partial class Frm_View_Member : Form
    {
        public Frm_View_Member()
        {
            InitializeComponent();
        }

        private void btn_Add_Member_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Members obj = new Frm_Add_New_Members();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Member_Click(object sender, EventArgs e)
        {
            Frm_Update_New_Members Obj = new Frm_Update_New_Members();
            Obj.Show();
            this.Hide();
        }

        private void btn_Member_List_Click(object sender, EventArgs e)
        {
            Frm_View_Member Obj = new Frm_View_Member();
            Obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }

        private void Frm_View_Member_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Member_List, "Select Member_Id,Member_Name,Mobile_No,Address,Adhhar_No,Join_Date,Height,Weight,Medical_History,Medical_Details From Member_Details ");
        }

        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_search_Member_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            else if (cmb_search_Member_By.Text == "Name")
            {
                if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Member_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Member_List, "Select * From Member_Details Where Member_Id = '" + tb_ID_Name.Text + "'");
            }
            else if (cmb_search_Member_By.Text == "Name")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Member_List, "Select * From Member_Details Where Member_Name = '" + tb_ID_Name.Text + "'");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_search_Member_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Member_List, "Select Member_Id,Member_Name,Mobile_No,Address,Adhhar_No,Join_Date,Height,Weight,Medical_History,Medical_Details From Member_Details ");
        }

        private void dgv_Member_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;

            Well_Health_Gym_App_Shared_Content.Mem_Bill_ID = Convert.ToInt32(dgv_Member_List.Rows[Row].Cells[0].Value);

            Report_Forms.Frm_Member_Bill Obj = new Report_Forms.Frm_Member_Bill();
            Obj.Show();
        }
    }
}

