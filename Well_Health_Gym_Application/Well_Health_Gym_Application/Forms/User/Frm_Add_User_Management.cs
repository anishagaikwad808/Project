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
    public partial class Frm_Add_User_Management : Form
    {
        public Frm_Add_User_Management()
        {
            InitializeComponent();
        }                     
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            SqlCommand Cmd1 = new SqlCommand("Select Count(*) From Login_Details Where Username = '" + tb_Username.Text + "'", Well_Health_Gym_App_Shared_Content.Con);

            int Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            if (Cnt > 0)
            {

                MessageBox.Show("Use Different Username", "Username Already Used", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Fill Username and Password", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (tb_Password.Text == tb_ConfirmPassword.Text)
            {
                SqlCommand Cmd2 = new SqlCommand("Insert Into Login_Details(Userrole,Username,Password) values ('" + cmb_UserRole.Text + "','" + tb_Username.Text + "','" + tb_Password.Text + "')", Well_Health_Gym_App_Shared_Content.Con);
                Cmd2.ExecuteNonQuery();


                MessageBox.Show("User Added Successfully..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_UserRole.SelectedIndex = -1;
                tb_Username.Clear();
                tb_Password.Clear();
                tb_ConfirmPassword.Clear();
            }
            else
            {
                MessageBox.Show("Password Did not Match..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_UserRole.SelectedIndex = -1;
            tb_Username.Clear();
            tb_Password.Clear();
            tb_ConfirmPassword.Clear();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            Frm_Update_User_Management Obj = new Frm_Update_User_Management();
            Obj.Show();
            this.Hide();
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            Frm_Delete_User_Management Obj = new Frm_Delete_User_Management();
            Obj.Show();
            this.Hide();
        }
    }
}
