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
    public partial class Frm_Trainer_Report : Form
    {
        public Frm_Trainer_Report()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Well_Health_Gym_App_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public void emp(string sql, SqlConnection Con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataSet ds = new DataSet();

            da.Fill(ds, "Trainer_Details");

            cr_Trainer_List ce = new cr_Trainer_List();
            ce.SetDataSource(ds);

            crystalReportViewer1.ReportSource = ce;
        }
        private void Frm_Trainer_Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            emp("Select * From Trainer_Details Where Join_Date >= '" + dtp_From.Text + "'AND Join_Date <= '" + dtp_To.Text + "'",Con);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Report_Main RM = new Frm_Report_Main();
            RM.Show();
            this.Hide();
        }
    }
}
