using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.User
{
    public partial class Frm_Delete_User_Management : Form
    {
        public Frm_Delete_User_Management()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }

        private void cmb_UserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
          Well_Health_Gym_App_Shared_Content.Con_Open();

            cmb_Username.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) From Login_Details Where Userrole = '" + cmb_UserRole.Text + "' ",Well_Health_Gym_App_Shared_Content.Con);
            SqlDataReader Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }
            Obj.Dispose();
            Cmd.Dispose();
           Well_Health_Gym_App_Shared_Content. Con_Close();
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if (cmb_UserRole.Text != "" && cmb_Username.Text != "" && tb_Password.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Delete Login_Details Where Username = '" + cmb_Username.Text + "'", Well_Health_Gym_App_Shared_Content.Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_UserRole.SelectedIndex = -1;
                cmb_Username.SelectedIndex = -1;
                cmb_Username.Items.Clear();
                tb_Password.Clear();
            }
            else
            {
                MessageBox.Show("First Fill All Fields.. ", "Incomplete info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           Well_Health_Gym_App_Shared_Content.Con_Close();
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        { 
            Frm_Delete_User_Management Obj = new Frm_Delete_User_Management();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            Frm_Delete_User_Management Obj = new Frm_Delete_User_Management();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            Frm_Add_User_Management Obj = new Frm_Add_User_Management();
            Obj.Show();
            this.Hide();
        }
    }
}
