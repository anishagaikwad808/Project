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
    public partial class Frm_Add_New_Trainer : Form
    {
        public Frm_Add_New_Trainer()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            tb_Trainer_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Trainer_Details", "ID", 1));

            tb_Trainer_Name.Clear();
            tb_Trainer_MobileNo.Clear();
            tb_Adhaar_No.Clear();
            tb_Experience.Clear();
            tb_Address.Clear();
            dtp_Join_Date.ResetText();
            tb_Height.Clear();
            tb_Weight.Clear();
            cmb_Possition.SelectedIndex = -1;
            tb_Salary.Clear();
            tb_Bank_Details.Clear();

        }
        private void Frm_Add_New_Trainer_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Trainer_Name.Focus();
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
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Trainer_Name.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if (tb_Trainer_Name.Text != "" && tb_Trainer_MobileNo.Text != "" && tb_Adhaar_No.Text != "" && tb_Experience.Text != "" && tb_Address.Text != "" && tb_Height.Text != "" && tb_Weight.Text != "" && cmb_Possition.Text != "" && tb_Salary.Text != "" && tb_Bank_Details.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("Insert Into Trainer_Details Values (@ID, @Name, @Mob_No, @Aadhar_No, @Experience,@Address,  @Join_Date, @Height, @Weight, @Post, @Salary, @Bank_Details)", Well_Health_Gym_App_Shared_Content.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Trainer_Id.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Trainer_Name.Text;
                cmd.Parameters.Add("@Mob_No", SqlDbType.Decimal).Value = tb_Trainer_MobileNo.Text;
                cmd.Parameters.Add("@Aadhar_No", SqlDbType.Decimal).Value = tb_Adhaar_No.Text;
                cmd.Parameters.Add("@Experience", SqlDbType.NVarChar).Value = tb_Experience.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("@Join_Date", SqlDbType.Date).Value = dtp_Join_Date.Value.Date;
                cmd.Parameters.Add("@Height", SqlDbType.Decimal).Value = tb_Height.Text;
                cmd.Parameters.Add("@Weight", SqlDbType.Decimal).Value = tb_Weight.Text;
                cmd.Parameters.Add("@Post", SqlDbType.NVarChar).Value = cmb_Possition.Text;
                cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = tb_Salary.Text;
                cmd.Parameters.Add("@Bank_Details", SqlDbType.NVarChar).Value = tb_Bank_Details.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Trainer Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("1st Fill All The Field !!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close();

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
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }
    }
}

