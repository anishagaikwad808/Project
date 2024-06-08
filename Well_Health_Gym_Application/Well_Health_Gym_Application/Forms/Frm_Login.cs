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

namespace Well_Health_Gym_Application.Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
       
        void Clear_Controls()
        {
            cmb_Username.SelectedIndex = -1;
            tb_Password.Clear();
            cmb_UserRole.SelectedIndex = -1;
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Error.Text = "Enter Username And password";
            lbl_Error.Visible = true;

            cmb_Username.Focus();

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) From Login_Details Where Userrole = '" + cmb_UserRole.Text + "' And Username ='" + cmb_Username.Text + "' And Password = '" + tb_Password.Text +"' ",Well_Health_Gym_App_Shared_Content.Con);

            Cmd.Parameters.Add("@URole", SqlDbType.VarChar).Value = cmb_UserRole.Text;
            Cmd.Parameters.Add("@UName", SqlDbType.VarChar).Value = cmb_Username.Text;
            Cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                if (cmb_UserRole.Text == "Admin")
                {
                    Global_Vars.URole = 1;
                }
                else if (cmb_UserRole.Text == "Manager")
                {
                    Global_Vars.URole = 2;
                }
                else if (cmb_UserRole.Text == "Employee")
                {
                    Global_Vars.URole = 3;
                }

                MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                Frm_Main Obj = new Frm_Main();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inccorrect Username Or Password", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void cmb_UserRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            Well_Health_Gym_App_Shared_Content.Con_Open();

            cmb_Username.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) From Login_Details Where Userrole = '"+ cmb_UserRole.Text + "'", Well_Health_Gym_App_Shared_Content.Con);
            SqlDataReader Obj = Cmd.ExecuteReader();

            while(Obj.Read())
            {
                cmb_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();
            Cmd.Dispose();
            Well_Health_Gym_App_Shared_Content.Con_Close();
        }
    }
}
