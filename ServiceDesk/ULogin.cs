using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceDesk
{
    public partial class ULogin : Form
    {
        public ULogin()
        {
            InitializeComponent();
        }

        private void ULogin_Load(object sender, EventArgs e)
        {
            GestionDB.getInstance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password, role;

            username = txtboxusername.Text.Trim().ToString();
            password = txtboxpassword.Text.Trim().ToString();

            if (btnadmin.Checked)
            {
                role = "administrator";
            }
            else
            {
                role = "ITHelp";
            }
        }
    }
}
