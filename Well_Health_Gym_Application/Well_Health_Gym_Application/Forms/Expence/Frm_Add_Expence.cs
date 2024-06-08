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

namespace Well_Health_Gym_Application.Forms.Expence
{
    public partial class Frm_Add_Expence : Form
    {
        public Frm_Add_Expence()
        {
            InitializeComponent();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Expence_Details", "Expence_ID",1));

            tb_Amount_Paid.Clear();
            tb_Details.Clear();
            dtp_Expence_Date.ResetText();
            cmb_BillType.SelectedIndex = -1;
            cmb_Paid_By.SelectedIndex = -1;

            tb_Details.Focus();
        }
        private void Frm_Add_Expence_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Well_Health_Gym_App_Shared_Content.Bind_ComboBox("Name", cmb_Paid_By, "Select Name from Employee_Details");
            tb_Details.Focus();
        }
      

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Details.Text != "" || tb_Amount_Paid.Text != "" || cmb_Paid_By.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Controls();
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if (cmb_BillType.Text !="" && tb_Details.Text != "" && tb_Amount_Paid.Text != "" && cmb_Paid_By.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Expence_Details Values (@ID,@Exp_Type,@Paid_By, @Exp_Date, @Exp_Details,@Ammount ) ", Well_Health_Gym_App_Shared_Content.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Id.Text;
                cmd.Parameters.Add("@Exp_Type", SqlDbType.NVarChar).Value = cmb_BillType.Text;
                cmd.Parameters.Add("@Paid_By", SqlDbType.VarChar).Value = cmb_Paid_By.Text;
                cmd.Parameters.Add("@Exp_Date", SqlDbType.Date).Value = dtp_Expence_Date.Value.Date;
                cmd.Parameters.Add("@Exp_Details", SqlDbType.NVarChar).Value = tb_Details.Text;
                cmd.Parameters.Add("@Ammount", SqlDbType.Money).Value = tb_Amount_Paid.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Expence Details Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Well_Health_Gym_App_Shared_Content.Con_Close();

        }

        private void btn_Add_Expence_Click(object sender, EventArgs e)
        {
            Frm_Add_Expence Obj = new Frm_Add_Expence();
            Obj.Show();
            this.Hide();
        }

        private void btn_Expence_List_Click(object sender, EventArgs e)
        {
            Frm_View_Expence_List Obj = new Frm_View_Expence_List();
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
