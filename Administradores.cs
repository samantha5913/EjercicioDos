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
    public partial class Administradores : Form
    {
        public Administradores()
        {
            InitializeComponent();
        }

        private void registroDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Usuario pre = new Registro_Usuario();
            pre.Show();
        }

        private void registroDeAgenciaAduanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agencia pre = new Agencia();
            pre.Show();
        }

        private void registroDeTransferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_transferencia pre = new Registro_de_transferencia();
            pre.Show();
        }

        private void registroDePreviosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_Previos pre = new Registro_de_Previos();
            pre.Show();
        }

        private void registroDePersonalDeDependenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_de_Dependencias pre = new Personal_de_Dependencias();
            pre.Show();
        }

   
    }
}
