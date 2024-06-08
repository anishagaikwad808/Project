using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Payment
{
    public partial class Frm_View_Payment : Form
    {
        public Frm_View_Payment()
        {
            InitializeComponent();
        }

        private void View_Payment_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Payment_List, "Select Member_Id,Packge_Name,Package_Type,Package_Fee,Trainer_Possition,Trainer_Fee,Total_Bill,Discount,Payment_Date,Final_Bill From Payment_Details ");
        }

        private void btn_Accept_Payment_Click(object sender, EventArgs e)
        {
            Frm_Accept_Payment Obj = new Frm_Accept_Payment();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Payment_Click(object sender, EventArgs e)
        {
            Frm_Search_And_Accept_Payment Obj = new Frm_Search_And_Accept_Payment();
            Obj.Show();
            this.Hide();
        }

        private void btn_Payment_List_Click(object sender, EventArgs e)
        {
            Frm_View_Payment Obj = new Frm_View_Payment();
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

            if (cmb_search_Payment_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            cmb_search_Payment_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Payment_List, "Select Member_Id,Packge_Name,Package_Type,Package_Fee,Trainer_Possition,Trainer_Fee,Total_Bill,Discount,Payment_Date,Final_Bill From Payment_Details ");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Payment_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Payment_List, "Select * From Payment_Details Where Member_Id = '" + tb_ID_Name.Text + "'");
            }
        }
    }
}
