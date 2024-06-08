﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms.Expence
{
    public partial class Frm_View_Expence_List : Form
    {
        public Frm_View_Expence_List()
        {
            InitializeComponent();
        }

        private void Frm_View_Expence_List_Load(object sender, EventArgs e)
        {
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Expence_List, "Select Expence_Id,Expence_Type,Bill_Paid_By,Date,Expence_Details,Bill_Amount From Expence_Details ");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main Obj = new Frm_Main();
            Obj.Show();
            this.Hide();
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

        private void tb_Id_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_search_Expense_By.Text == "ID")
            {
                if (!(char.IsDigit(e.KeyChar) || (e.KeyChar) == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_search_Expense_By.Text == "ID")
            {
                Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Expence_List, "Select * From Expence_Details Where Expence_Id = '" + tb_ID_Name.Text + "'");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_search_Expense_By.SelectedIndex = -1;
            tb_ID_Name.Clear();
            Well_Health_Gym_App_Shared_Content.Bind_Grid(dgv_Expence_List, "Select Expence_Id,Expence_Type,Bill_Paid_By,Date,Expence_Details,Bill_Amount From Expence_Details ");
        
        }
    }
}
