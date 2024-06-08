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

namespace Well_Health_Gym_Application.Forms.Member
{
    public partial class Frm_Update_New_Members : Form
    {
        public Frm_Update_New_Members()
        {
            InitializeComponent();
        }

        private void Is_Letter(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar) == (Char)Keys.Back || (e.KeyChar) == (Char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void Is_Digit(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Is_Measurement(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar) || (e.KeyChar) == (Char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Member_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Member_Details", "Member_ID", 1));

            tb_Member_Name.Clear();
            tb_Mob_No.Clear();
            tb_Address.Clear();
            tb_Adhar_Card.Clear();
            dtp_Join_Date.ResetText();
            tb_Height.Clear();
            tb_Weight.Clear();
            cmb_Medical_History.SelectedIndex = -1;
            tb_MedicalDetails.Clear();
            tb_RefferedBy.Clear();
            tb_Member_Name.Focus();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
          Well_Health_Gym_App_Shared_Content. Con_Open();

            if (tb_Member_Id.Text != "" && tb_Member_Name.Text != "" && tb_Mob_No.Text != "" && tb_Address.Text != "" && tb_Adhar_Card.Text != "" && dtp_Join_Date.Text != "" &&  tb_Height.Text != "" && tb_Weight.Text != "" && cmb_Medical_History.Text != "" && tb_MedicalDetails.Text != "")
            {
               
                if (tb_RefferedBy.Text == "")
                {
                    tb_RefferedBy.Text = "-";
                }


                SqlCommand Cmd = new SqlCommand("Update Member_Details set Member_Name = @MName,Mobile_No = @Mob,Address = @Address,Adhhar_No = @Adhaar,Join_Date = @JDate,Height = @Height,Weight = @Weight,Medical_History =@Medical_History,Medical_Details = @Medical_Details,Refered_By=@Ref Where Member_ID = @MID",Well_Health_Gym_App_Shared_Content.Con);
               
                Cmd.Parameters.Add("MID", SqlDbType.Int).Value = tb_Member_Id.Text;
                Cmd.Parameters.Add("MName", SqlDbType.VarChar).Value = tb_Member_Name.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Adhaar", SqlDbType.Decimal).Value = tb_Adhar_Card.Text;
                Cmd.Parameters.Add("JDate", SqlDbType.Date).Value = dtp_Join_Date.Text;
                Cmd.Parameters.Add("Height", SqlDbType.Decimal).Value = tb_Height.Text;
                Cmd.Parameters.Add("Weight", SqlDbType.Decimal).Value = tb_Weight.Text;
                Cmd.Parameters.Add("Medical_History", SqlDbType.VarChar).Value = cmb_Medical_History.Text;
                Cmd.Parameters.Add("Medical_Details", SqlDbType.NVarChar).Value = tb_MedicalDetails.Text;
                Cmd.Parameters.Add("Ref", SqlDbType.VarChar).Value = tb_RefferedBy.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Updated SuccessFully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Search Valid Member ID..! ", "Incomplete info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          Well_Health_Gym_App_Shared_Content.Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if (tb_Member_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Member_Details Where Member_ID = @MID", Well_Health_Gym_App_Shared_Content.Con);
                Cmd.Parameters.Add("MID", SqlDbType.Int).Value = tb_Member_Id.Text; ;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Member_Name.Text = Dr.GetString(Dr.GetOrdinal("Member_Name"));
                    tb_Mob_No.Text = (Dr["Mobile_No"].ToString());
                    tb_Address.Text = (Dr["Address"].ToString());
                    tb_Adhar_Card.Text = (Dr["Adhhar_No"].ToString());
                    dtp_Join_Date.Text = (Dr["Join_Date"].ToString());
                    tb_Height.Text = (Dr["Height"].ToString());
                    tb_Weight.Text = (Dr["Weight"].ToString());
                    cmb_Medical_History.Text = (Dr["Medical_History"].ToString());
                    tb_MedicalDetails.Text = (Dr["Medical_Details"].ToString());
                    tb_RefferedBy.Text = (Dr["Refered_By"].ToString());

                }
                else
                {
                    MessageBox.Show("Invalid Member ID", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Member_Id.Clear();
                    tb_Member_Id.Focus();
                }

            }
            else
            {
                MessageBox.Show("First Fill Member ID", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           Well_Health_Gym_App_Shared_Content. Con_Close();

        }

        private void btn_Refrsh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Member_Name.Focus();
        }

        private void btn_Add_Member_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Members Obj = new Frm_Add_New_Members();
            Obj.Show();
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
    }
}

