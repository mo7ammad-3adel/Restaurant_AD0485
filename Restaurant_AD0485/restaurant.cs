using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_AD0485
{
    public partial class frmRestaurant : Form
    {
        private List<user> UsersList = new List<user>();
        public frmRestaurant()
        {
            user user1 = new user("ghazzwe", "0485");
            InitializeComponent();
            UsersList.Add(user1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            foreach (user user in UsersList)
            {
                if (username == user.UserName && password == user.Password)
                {
                    frmLogin frm = new frmLogin(txtUserName.Text);
                    frm.Show();
                    return;
                }
            }
        }
    }
}
