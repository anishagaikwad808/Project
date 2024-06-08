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

namespace Well_Health_Gym_Application.Forms.Equipment
{
    public partial class Frm_Add_Equipment : Form
    {
        public Frm_Add_Equipment()
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
            tb_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Equipment_Details","Equi_ID",1));

            tb_Name.Clear();
            tb_Price.Clear();
            dtp_Date.ResetText();
            tb_Muscles_Used.Clear();
            tb_Description.Clear();

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Name.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if (tb_Name.Text != ""  && tb_Price.Text != "" && tb_Muscles_Used.Text != "" && tb_Description.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Equipment_Details Values (@ID, @Name,  @Price, @Date_Of_Purchase, @Muscle_Used, @Des)", Well_Health_Gym_App_Shared_Content.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Id.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("@Price", SqlDbType.Money).Value = tb_Price.Text;
                cmd.Parameters.Add("@Date_Of_Purchase", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("@Muscle_Used", SqlDbType.VarChar).Value = tb_Muscles_Used.Text;
                cmd.Parameters.Add("@Des", SqlDbType.NVarChar).Value = tb_Description.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Equipment Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("1st Fill All The Field !!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close();

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

        private void Frm_Add_Equipment_Load_1(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Name.Focus();
        }
    }
}
