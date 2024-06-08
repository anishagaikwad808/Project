using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms
{
    class Well_Health_Gym_App_Shared_Content
    {
       public static int Mem_Bill_ID = 0;
        public static String LoggedInUName = "Dummy";
        public static SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Well_Health_Gym_App_DB;Integrated Security=True");

        public static void Con_Open()
        {
            if (Con.State != System.Data.ConnectionState.Open)
            {
                Con.Open();
            }
        }
        public static void Con_Close()
        {
            if (Con.State != System.Data.ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public static int Auto_Incr(string Table_Name, string ID_Field_Name, int Start_Point)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From " + Table_Name + "";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(" + ID_Field_Name + ") From " + Table_Name + "";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt += 1;
            }
            else
            {
                Cnt = Start_Point;
            }

            Con_Close();
            return Cnt;
        }

        internal static void Bind_Grid(object dgv_Member_List, string v)
        {
            throw new NotImplementedException();
        }

        internal static void Bind_Grid(string v)
        {
            throw new NotImplementedException();
        }

        public static void Bind_Grid(DataGridView DGV, string Query)
        {
            Con_Open();

            //DGV.Rows.Clear();

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            DGV.DataSource = dt;

            Con_Close();
        }

        public static void Bind_ComboBox(string ColumnName, ComboBox CMB, string Query)
        {
            Con_Open();

            CMB.Items.Clear();

            SqlCommand Cmd = new SqlCommand(Query, Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                CMB.Items.Add(Dr.GetString(Dr.GetOrdinal(ColumnName)));
            }

            Dr.Dispose();
            Con_Close();
        }

    }
}






