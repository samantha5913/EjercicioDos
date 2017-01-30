using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSICO_ADUANAL.ClasesApAdu;
using System.Data.SqlClient;

namespace APSICO_ADUANAL
{
    public partial class Personal_de_Dependencias : Form
    {
        Registrar Reg = new Registrar();
        Consultar con = new Consultar();
        Eliminar Eli = new Eliminar();
        Actualizar Act = new Actualizar();
        public Personal_de_Dependencias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Reg.Reg_Personal_Dependencias(cmbregistro.Text, txtdep.Text, txtnombre.Text, txtapellido.Text, txtgafete.Text))
            {
                con.Con_Personal_Dependencias(dgvdepen);
                MessageBox.Show("Registro correcto");
            }
            else
            {
                MessageBox.Show("Registro incorrecto");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Reg.Reg_Actividades(cmbfoldep.Text, cmbfolregis.Text, txtdscripcion.Text, txthrs.Text, txtfecha.Text, txtgafete.Text))
            {
                con.Con_Actividades(dgvactiv);
                MessageBox.Show("Registro correcto");
            }
            else
            {
                MessageBox.Show("Registro incorrecto");
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Menu pre = new Menu();
            pre.Show();
        }

        private void Personal_de_Dependencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet18.Registro_Tramites' Puede moverla o quitarla según sea necesario.
            this.registro_TramitesTableAdapter1.Fill(this.apsico_aduanalDataSet18.Registro_Tramites);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet17.Personal_Dependencias' Puede moverla o quitarla según sea necesario.
            this.personal_DependenciasTableAdapter.Fill(this.apsico_aduanalDataSet17.Personal_Dependencias);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet16.Registro_Tramites' Puede moverla o quitarla según sea necesario.
            this.registro_TramitesTableAdapter.Fill(this.apsico_aduanalDataSet16.Registro_Tramites);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Con_Personal_Dependencias(dgvdepen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Eli.Eli_Personal_Dependencias(txtID.Text))
            {
                con.Con_Personal_Dependencias(dgvdepen);
                MessageBox.Show("Eliminado");
            }

            else
            {
                MessageBox.Show("No es posible eliminar");
            } 
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            con.Con_Actividades(dgvactiv);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Eli.Eli_Actividades(txtfolact.Text))
            {
                con.Con_Actividades(dgvactiv);
                MessageBox.Show("Eliminado");
            }

            else
            {
                MessageBox.Show("No es posible eliminar");
            } 
        }

        private void cmbfoldep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
