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

namespace Well_Health_Gym_Application.Forms.Employee
{
    public partial class Frm_Add_New_Employee : Form
    {
        public Frm_Add_New_Employee()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            tb_Emp_Id.Text = Convert.ToString(Well_Health_Gym_App_Shared_Content.Auto_Incr("Employee_Details", "Emp_ID", 1));

            tb_Emp_Name.Clear();
            tb_Mob_No.Clear();
            tb_Address.Clear();
            dtp_Join_Date.ResetText();
            cmb_Possition.SelectedIndex = -1;
            tb_Adhhar_No.Clear();
            tb_Alternate_Mob_No.Clear();
            tb_Salary.Clear();
            tb_Bank_Details.Clear();

        }

        private void Frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Emp_Name.Focus();
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

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Emp_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Con_Open();

            if(tb_Emp_Name.Text != "" && tb_Mob_No.Text != "" && tb_Address.Text != "" && cmb_Possition.Text != "" && tb_Adhhar_No.Text != "" && tb_Salary.Text != "" && tb_Bank_Details.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Employee_Details Values (@ID, @Name, @Mob_No, @Address, @Join_Date, @Post, @Aadhar_No, @Salary, @Bank_Details)", Well_Health_Gym_App_Shared_Content.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Emp_Id.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Emp_Name.Text;
                cmd.Parameters.Add("@Mob_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("@Join_Date", SqlDbType.Date).Value = dtp_Join_Date.Value.Date;
                cmd.Parameters.Add("@Post", SqlDbType.NVarChar).Value = cmb_Possition.Text;
                cmd.Parameters.Add("@Aadhar_No", SqlDbType.Decimal).Value = tb_Adhhar_No.Text;
                cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = tb_Salary.Text;
                cmd.Parameters.Add("@Bank_Details", SqlDbType.NVarChar).Value = tb_Bank_Details.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Field !!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Well_Health_Gym_App_Shared_Content.Con_Close(); 
        }
        private void btn_Emp_Add_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Employee Obj = new Frm_Add_New_Employee();
            Obj.Show();
            this.Hide();
        }
        private void btn_Emp_Update_Click(object sender, EventArgs e)
        {
            Frm_Update_Employee_Details Obj = new Frm_Update_Employee_Details();
            Obj.Show();
            this.Hide();
        }
        private void btn_Emp_List_Click(object sender, EventArgs e)
        {
            Frm_View_Employee_List Obj = new Frm_View_Employee_List();
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
