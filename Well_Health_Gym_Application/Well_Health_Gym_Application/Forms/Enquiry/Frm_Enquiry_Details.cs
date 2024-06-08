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

namespace Well_Health_Gym_Application.Forms.Enquiry
{
    public partial class Frm_Enquiry_Details : Form
    {
        public Frm_Enquiry_Details()
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
            tb_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Enquiry_Details", "ID", 1));

            tb_Name.Clear();
            tb_Mob_No.Clear();
            tb_Count.Clear();
            dtp_Date.ResetText();
            tb_Refered_By.Clear();
            tb_Note.Clear();

        }
        private void Frm_Enquiry_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Name.Focus();
        }

       
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if(tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Count.Text != "" && tb_Refered_By.Text != "" && tb_Note.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Enquiry_Details Values (@ID, @Name, @Mob_No, @Count,  @Date_Of_Enquiry, @Refered_By, @Note)", Well_Health_Gym_App_Shared_Content.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Id.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("@Mob_No",SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("@Count", SqlDbType.Int).Value = tb_Count.Text;
                cmd.Parameters.Add("@Date_Of_Enquiry", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("@Refered_By", SqlDbType.VarChar).Value = tb_Refered_By.Text;
                cmd.Parameters.Add("@Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Enquiry Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("1st Fill All The Field !!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close();

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
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
        }
    }
}

