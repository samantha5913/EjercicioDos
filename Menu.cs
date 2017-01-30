using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSICO_ADUANAL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login pre = new Login();
            pre.Show();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_login pre = new Admin_login();
            pre.Show();
        }
    }
}
