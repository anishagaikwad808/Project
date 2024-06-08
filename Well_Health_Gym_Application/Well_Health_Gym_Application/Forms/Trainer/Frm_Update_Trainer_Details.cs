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

namespace Well_Health_Gym_Application.Forms.Trainer
{
    public partial class Frm_Update_Trainer_Details : Form
    {
        public Frm_Update_Trainer_Details()
        {
            InitializeComponent();
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void Only_Alphanumeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Trainer_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Trainer_Details", "Id", 1));

            tb_Trainer_Name.Clear();
            tb_Trainer_MobileNo.Clear();
            tb_Adhaar_No.Clear();
            tb_Experience.Clear();
            tb_Address.Clear();
            tb_Height.Clear();
            tb_Weight.Clear();
            cmb_Possition.SelectedIndex = -1;
            tb_Salary.Clear();
            tb_Bank_Details.Clear();

            tb_Trainer_Id.Enabled = true;
        }
        private void Frm_Update_Trainer_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Trainer_Name.Focus();
        }
      
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Trainer_Name.Focus();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if (tb_Trainer_Name.Text != "" && tb_Trainer_MobileNo.Text != "" && tb_Experience.Text != "" && tb_Address.Text != "" && tb_Height.Text != "" && tb_Weight.Text != "" && cmb_Possition.Text != "" && tb_Salary.Text != "" && tb_Bank_Details.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("Update Trainer_Details Set Name = @Name, Mob_No = @Mob_No, Experience = @Experience, Address = @Address, Height = @Height, Weight = @Weight, Designation = @Post, Salary = @Salary, Bank_Details = @Bank_Details where Id= @ID", Well_Health_Gym_App_Shared_Content.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Trainer_Id.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Trainer_Name.Text;
                cmd.Parameters.Add("@Mob_No", SqlDbType.Decimal).Value = tb_Trainer_MobileNo.Text;
                cmd.Parameters.Add("@Experience", SqlDbType.NVarChar).Value = tb_Experience.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("@Height", SqlDbType.Decimal).Value = tb_Height.Text;
                cmd.Parameters.Add("@Weight", SqlDbType.Decimal).Value = tb_Weight.Text;
                cmd.Parameters.Add("@Post", SqlDbType.NVarChar).Value = cmb_Possition.Text;
                cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = tb_Salary.Text;
                cmd.Parameters.Add("@Bank_Details", SqlDbType.NVarChar).Value = tb_Bank_Details.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Trainer Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("1st Fill All The Field !!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close();

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Trainer_Details where Id =" + tb_Trainer_Id.Text + "", Well_Health_Gym_App_Shared_Content.Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Trainer_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                tb_Trainer_MobileNo.Text = (obj["Mob_No"].ToString());
                tb_Adhaar_No.Text = (obj["Adhhar_No"].ToString());
                tb_Experience.Text = obj.GetString(obj.GetOrdinal("Experience"));
                tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                tb_Height.Text = (obj["Height"].ToString());
                tb_Weight.Text = (obj["Weight"].ToString());
                cmb_Possition.Text = obj.GetString(obj.GetOrdinal("Designation"));
                tb_Salary.Text = (obj["Salary"].ToString());
                tb_Bank_Details.Text = obj.GetString(obj.GetOrdinal("Bank_Details"));

                tb_Trainer_Id.Enabled = false;
                btn_Refresh.Enabled = true;
                btn_Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Trainer ID!!!");
                Clear_Controls();
            }

            obj.Dispose();
            Well_Health_Gym_App_Shared_Content.Con_Close();

        }

        private void btn_Trainer_Add_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Trainer Obj = new Frm_Add_New_Trainer();
            Obj.Show();
            this.Hide();
        }

        private void btn_Trainer_Update_Click(object sender, EventArgs e)
        {
            Frm_Update_Trainer_Details Obj = new Frm_Update_Trainer_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }

        private void btn_Trainer_List_Click(object sender, EventArgs e)
        {
            Frm_View_Trainer_List Obj = new Frm_View_Trainer_List();
            Obj.Show();
            this.Hide();
        }
    }
}
