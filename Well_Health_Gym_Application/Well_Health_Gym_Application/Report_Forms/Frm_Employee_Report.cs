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
using Well_Health_Gym_Application.Crystal_Report;
using Well_Health_Gym_Application.Forms;

namespace Well_Health_Gym_Application.Report_Forms
{
    public partial class Frm_Employee_Report : Form
    {
        public Frm_Employee_Report()
        {
            InitializeComponent();
        }
        public void emp(string sql, SqlConnection Con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataSet ds = new DataSet();

            da.Fill(ds, "Employee_Details");

            cr_Employee_List ce = new cr_Employee_List();
            ce.SetDataSource(ds);

            crystalReportViewer1.ReportSource = ce;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Report_Main RM = new Frm_Report_Main();
            RM.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            emp("Select * From Employee_Details Where Join_Date >= '" + dtp_From.Text + "'AND Join_Date <= '" + dtp_To.Text + "'", Forms.Well_Health_Gym_App_Shared_Content.Con);
        }

        private void Frm_Employee_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
