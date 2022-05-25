using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AD0485
{
    public partial class frmLogin : Form
    {
        private string _user;
        public frmLogin(string user)
        {
            _user = user;
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblwel.Text = "welcome " + _user;
        }

        private void btnForm1_Click_1(object sender, EventArgs e)
        {
            BreakFast frm1 = new BreakFast();
            frm1.TopLevel = false;
            this.panel3.Controls.Add(frm1);
            frm1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Lunch frm2 = new Lunch();
            frm2.TopLevel = false;
            this.panel3.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Dinner frm3 = new Dinner();
            frm3.TopLevel = false;
            this.panel3.Controls.Add(frm3);
            frm3.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmDataBase frm4 = new frmDataBase();
            frm4.TopLevel = false;
            this.panel3.Controls.Add(frm4);
            frm4.Show();
        }
    }
}
