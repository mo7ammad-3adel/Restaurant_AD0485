using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Restaurant_AD0485
{
    public partial class AddDinner : Form
    {
        public AddDinner()
        {
            InitializeComponent();
        }
        string database = "Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source = Restaurant_AD0485.accdb";
        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(database);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Dinner", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();
        }
            private void btnInsert_Click(object sender, EventArgs e)
            {
                OleDbConnection con = new OleDbConnection(database);
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into Dinner values(@ID, @Food)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@Food", txtName.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add is successfully");
                GetAllCourses();
            }
    }
}
