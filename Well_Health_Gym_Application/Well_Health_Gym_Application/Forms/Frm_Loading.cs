using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Well_Health_Gym_Application.Forms
{
    public partial class Frm_Loading : Form
    {
        public Frm_Loading()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pb_Loading.Increment(2);
            if(pb_Loading.Value == 100)
            {
                timer.Enabled = false;
                Frm_Login Obj = new Frm_Login();
                Obj.Show();
                this.Hide();
                   
            }
        }

        private void Frm_Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
