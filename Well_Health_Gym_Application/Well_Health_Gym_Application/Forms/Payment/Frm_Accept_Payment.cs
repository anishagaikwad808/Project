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

namespace Well_Health_Gym_Application.Forms.Payment
{
    public partial class Frm_Accept_Payment : Form
    {
        public Frm_Accept_Payment()
        {
            InitializeComponent();
        }

        private void Frm_Accept_Payment_Load(object sender, EventArgs e)
        {
            tb_Member_Id.Text = Convert.ToString(Global_Vars.MID);
            tb_Member_name.Text = Convert.ToString(Global_Vars.MName);
            tb_Mob_No.Text = Convert.ToString(Global_Vars.MNo);
            dtp_Join_Date.Text = Convert.ToString(Global_Vars.JDate);

            Bind_ComboBox();
        }


        void Clear_Controls()
        {
            tb_Member_Id.Clear();
            tb_Member_name.Clear();
            tb_Mob_No.Clear();
            dtp_Join_Date.ResetText();
            cmb_Package_name.SelectedIndex = -1;
            cmb_Package_Type.SelectedIndex = -1;
            cmb_Package_Type.Enabled = false;
            tb_Package_Fee.Clear();
            rbt_Yes.Checked = false;
            rbt_No.Checked = false;
            cmb_Trainer_Possition.SelectedIndex = -1;
            tb_Personal_Trainer_fee.Clear();
            tb_Total_Bill.Clear();
            tb_Discount.Clear();
            dtp_Payment_Date.ResetText();
            tb_Final_Bill.Clear();

        }
        private void rbt_No_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_No.Checked == true)
            {
                cmb_Trainer_Possition.Enabled = false;
                tb_Personal_Trainer_fee.Enabled = false;
                tb_Personal_Trainer_fee.Text = "0";
                tb_Total_Bill.Text = tb_Package_Fee.Text;
            }
            else
            {
                cmb_Trainer_Possition.Enabled = true;
                tb_Personal_Trainer_fee.Enabled = true;
            }
        }

        private void rbt_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Yes.Checked == true)
            {
                cmb_Trainer_Possition.Enabled = true;
                tb_Personal_Trainer_fee.Enabled = true;
            }
            else
            {
                cmb_Trainer_Possition.Enabled = false;
                tb_Personal_Trainer_fee.Enabled = false;
            }
        }

        void Bind_ComboBox()
        {
            Well_Health_Gym_App_Shared_Content. Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Name)From Package_Details",Well_Health_Gym_App_Shared_Content.Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Package_name.Items.Add(Dr.GetString(Dr.GetOrdinal("Name")));

            }
            Cmd.Dispose();
           Well_Health_Gym_App_Shared_Content.Con_Close();

        }
        private void cmb_Package_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
           Well_Health_Gym_App_Shared_Content.Con_Open();

            if (cmb_Package_name.Text != "")
            {

                SqlCommand Cmd = new SqlCommand("Select * from Package_Details Where Name = '" + cmb_Package_name.Text + "' ",Well_Health_Gym_App_Shared_Content.Con);

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    if (cmb_Package_Type.SelectedIndex == 0)
                    {
                        tb_Package_Fee.Text = (Dr["Monthly_Charges"].ToString());
                    }
                    else if (cmb_Package_Type.SelectedIndex == 1)
                    {
                        tb_Package_Fee.Text = (Dr["Package_3Month_Charges"].ToString());
                    }
                    else if (cmb_Package_Type.SelectedIndex == 2)
                    {
                        tb_Package_Fee.Text = (Dr["Package_6Month_Charges"].ToString());
                    }
                    else if (cmb_Package_Type.SelectedIndex == 3)
                    {
                        tb_Package_Fee.Text = (Dr["Yearly_Charges"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete Info Available", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               Well_Health_Gym_App_Shared_Content.Con_Close();

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
          Well_Health_Gym_App_Shared_Content. Con_Open();
            if (cmb_Package_name.Text != "" && cmb_Package_Type.Text != "" && tb_Package_Fee.Text != "" && tb_Total_Bill.Text != "" && tb_Discount.Text != "" && tb_Final_Bill.Text != "")
            {
                if (cmb_Trainer_Possition.SelectedIndex == -1)
                {
                    cmb_Trainer_Possition.Text = "-";
                }
                if (tb_Personal_Trainer_fee.Text == "")
                {
                    tb_Personal_Trainer_fee.Text = "0";
                }
                SqlCommand Cmd = new SqlCommand("Insert Into Payment_Details Values(@MID,@PName,@PType,@PFee,@TPosition,@TFee,@TBill,@Discount,@PDate,@FBill)",Well_Health_Gym_App_Shared_Content.Con);
       
                Cmd.Parameters.Add("MID", SqlDbType.Int).Value = tb_Member_Id.Text;
                Cmd.Parameters.Add("PName", SqlDbType.VarChar).Value = cmb_Package_name.Text;
                Cmd.Parameters.Add("PType", SqlDbType.VarChar).Value = cmb_Package_Type.Text;
                Cmd.Parameters.Add("PFee", SqlDbType.Money).Value = tb_Package_Fee.Text;
                Cmd.Parameters.Add("TPosition", SqlDbType.VarChar).Value = cmb_Trainer_Possition.Text;
                Cmd.Parameters.Add("TFee", SqlDbType.Money).Value = tb_Personal_Trainer_fee.Text;
                Cmd.Parameters.Add("TBill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                Cmd.Parameters.Add("Discount", SqlDbType.Int).Value = tb_Discount.Text;
                Cmd.Parameters.Add("PDate", SqlDbType.Date).Value = dtp_Join_Date.Text;
                Cmd.Parameters.Add("FBill", SqlDbType.Money).Value = tb_Final_Bill.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Payment Details Saved Successfully..!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void tb_Personal_Trainer_fee_TextChanged(object sender, EventArgs e)
        {
            if (tb_Personal_Trainer_fee.Text != "")
            {
                tb_Total_Bill.Text = (Convert.ToDouble(tb_Package_Fee.Text) + Convert.ToDouble(tb_Personal_Trainer_fee.Text)).ToString();
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "")
            {
                tb_Final_Bill.Text = (Convert.ToDouble(tb_Total_Bill.Text) - ((Convert.ToDouble(tb_Total_Bill.Text) / 100) * Convert.ToDouble(tb_Discount.Text))).ToString();
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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
    }
    
}
