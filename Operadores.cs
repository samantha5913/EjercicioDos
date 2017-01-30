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
    public partial class Operadores : Form
    {
        public Operadores()
        {
            InitializeComponent();
        }

        private void registrarAgenciaAduanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agencia pre = new Agencia();
            pre.Show();
        }

        private void registrarPrevioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_Previos pre = new Registro_de_Previos();
            pre.Show();
        }

        private void personalDeDependenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_de_Dependencias pre = new Personal_de_Dependencias();
            pre.Show();
        }

        private void registrarTransferenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro_de_transferencia pre = new Registro_de_transferencia();
            pre.Show();
        }
    }
}
