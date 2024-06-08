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

namespace Well_Health_Gym_Application.Forms.Package
{
    public partial class Frm_Update_Package : Form
    {
        public Frm_Update_Package()
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

        private void Is_Amount(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }
        void Clear_Controls()
        {
            tb_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Package_Details", "ID", 1));
            
            tb_Name.Clear();
            dtp_Date.ResetText();
            tb_Monthly_Charges.Clear();
            tb_3Months_Charges.Clear();
            tb_6Months_Charges.Clear();
            tb_Yearly_Charges.Clear();

        }

        private void btn_Update_Package_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();
            if (tb_Name.Text != "" && tb_Monthly_Charges.Text != "" && tb_3Months_Charges.Text != "" && tb_6Months_Charges.Text != "" && tb_Yearly_Charges.Text != "")
            {

               SqlCommand Cmd = new SqlCommand("Update Package_Details Set Name = @PName, Date = @Date, Monthly_Charges = @Monthly_Charges,Package_3Month_Charges = @3Mon_Charge,Package_6Month_Charges = @6Mon_Charge, Yearly_Charges = @Year_Charge where ID = @ID ", Well_Health_Gym_App_Shared_Content.Con);

                Cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("@PName",SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("@Date",SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("@Monthly_Charges",SqlDbType.Money).Value = tb_Monthly_Charges.Text;
                Cmd.Parameters.Add("@3Mon_Charge",SqlDbType.Money).Value = tb_3Months_Charges.Text;
                Cmd.Parameters.Add("@6Mon_Charge",SqlDbType.Money).Value = tb_6Months_Charges.Text;
                Cmd.Parameters.Add("@Year_Charge",SqlDbType.Money).Value = tb_Yearly_Charges.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear_Controls();
               
            }
            else
            {

                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           Well_Health_Gym_App_Shared_Content.Con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           Well_Health_Gym_App_Shared_Content.Con_Open();

            if (tb_Id.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Package_Details Where ID ='" + tb_Id.Text + "'", Well_Health_Gym_App_Shared_Content.Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    dtp_Date.Text = (Dr["Date"].ToString());
                    tb_Monthly_Charges.Text = (Dr["Monthly_Charges"].ToString());
                    tb_3Months_Charges.Text = (Dr["Package_3Month_Charges"].ToString());
                    tb_6Months_Charges.Text = (Dr["Package_6Month_Charges"].ToString());
                    tb_Yearly_Charges.Text = (Dr["Yearly_Charges"].ToString());         

                }
                else
                {
                    MessageBox.Show("Invalid Package ID", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Id.Clear();
                    tb_Id.Focus();
                }

            }
            else
            {
                MessageBox.Show("First Fill Package ID", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           Well_Health_Gym_App_Shared_Content .Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Name.Focus();
        }

        private void btn_Update_Packge_Click(object sender, EventArgs e)
        {
            Frm_Update_Package Obj = new Frm_Update_Package();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_Packge_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Package Obj = new Frm_Add_New_Package();
            Obj.Show();
            this.Hide();
        }

        private void btn_Package_List_Click(object sender, EventArgs e)
        {
            Frm_Package_List Obj = new Frm_Package_List();
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

