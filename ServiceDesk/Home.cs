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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Start();
            labeltime.Text = DateTime.Now.ToLongTimeString();
            labeldate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void créerUnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créerMultiplesArticlesINVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créerUnTicketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualisationTicket visualisationTicket = new VisualisationTicket();
            visualisationTicket.Show();
        }
    }
}
