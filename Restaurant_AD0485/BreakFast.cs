using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restaurant_AD0485
{
    public partial class BreakFast : Form
    {
        public BreakFast()
        {
            InitializeComponent();
            fill_ListBox();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order : " + listBox1.SelectedItem + "\n Quantity : " + comboBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBreakFast add2 = new AddBreakFast();
            add2.Show();
        }
        string database = "Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source = Restaurant_AD0485.accdb";
        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(database);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select Food from Break_Fast";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    listBox1.Items.Add(myReader["Food"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  " + ex);
            }
        }
    }
}
