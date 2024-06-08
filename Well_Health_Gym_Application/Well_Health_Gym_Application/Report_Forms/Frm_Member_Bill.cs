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
using Well_Health_Gym_Application.Forms.Member;

namespace Well_Health_Gym_Application.Report_Forms
{
    public partial class Frm_Member_Bill : Form
    {

        public Frm_Member_Bill()
        {
            InitializeComponent();
        }
        public void emp(string sql, SqlConnection Con)
        {
            /*Well_Health_Gym_App_Shared_Content.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Member_Bill", Well_Health_Gym_App_Shared_Content.Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Mem_ID", Well_Health_Gym_App_Shared_Content.Mem_Bill_ID);

            DataTable dtb1 = new DataTable();

            sqlDa.Fill(dtb1);

            Well_Health_Gym_App_Shared_Content.Con_Close();

            Crystal_Report.cr_Member_Bill cr_Mem = new Crystal_Report.cr_Member_Bill();
            cr_Mem.Database.Tables["SP_Member_Bill"].SetDataSource(dtb1);

            crv_Member_Bill.ReportSource = null;

            crv_Member_Bill.ReportSource = cr_Mem;*/


        }
        private void Frm_Member_Bill_Load(object sender, EventArgs e)
        {
           Well_Health_Gym_App_Shared_Content.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Member_Bill", Well_Health_Gym_App_Shared_Content.Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Mem_ID", Well_Health_Gym_App_Shared_Content.Mem_Bill_ID);

            DataTable dtb1 = new DataTable();

            sqlDa.Fill(dtb1);

            Well_Health_Gym_App_Shared_Content.Con_Close();

            Crystal_Report.cr_Member_Bill cr_Mem = new Crystal_Report.cr_Member_Bill();
            cr_Mem.Database.Tables["SP_Member_Bill"].SetDataSource(dtb1);

            crv_Member_Bill.ReportSource = null;

            crv_Member_Bill.ReportSource = cr_Mem;

        } 

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_View_Member Obj = new Frm_View_Member();
            Obj.Show();
            this.Hide();
        }
    }
}

