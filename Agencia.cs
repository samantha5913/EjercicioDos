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
    public partial class Agencia : Form
    {
        Registrar Reg = new Registrar();
        Consultar con = new Consultar();
        Eliminar Eli = new Eliminar();
        Actualizar Act = new Actualizar();
        public Agencia()
        {
            InitializeComponent();
        }

        private void bbtnactualizar_Click(object sender, EventArgs e)
        {
            if (txtfolio.Text.Length > 0)
            {
                if (Act.Agencia_Aduanal(txtfolio.Text, cmbprefolio.Text, cmbregfolio.Text, txtagencia.Text, txtpatente.Text, txtnombre.Text, txtpaterno.Text, txtmaterno.Text, txtgafete.Text))
                {
                    MessageBox.Show("Registros actualizado");
                }
                else
                    MessageBox.Show("No es posible actualizar el registro");
                con.Con_Agencia_Aduanal(dgvdatos);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Reg.Reg_Agencia_Aduanal(cmbprefolio.Text, cmbregfolio.Text, txtagencia.Text, txtpatente.Text, txtnombre.Text, txtpaterno.Text, txtmaterno.Text, txtgafete.Text))
            {
                con.Con_Agencia_Aduanal(dgvdatos);
                MessageBox.Show("Registro correcto");
            }
          else
          {
              MessageBox.Show("Registro incorrecto");
          }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (Eli.Eli_Agencia_Aduanal(txtfolio.Text))
                
            {
                con.Con_Agencia_Aduanal(dgvdatos);
                MessageBox.Show("Eliminado");
            }

            else
            {
                MessageBox.Show("No es posible eliminar");
            } 
        }

        private void Agencia_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet12.Previos' Puede moverla o quitarla según sea necesario.
            this.previosTableAdapter.Fill(this.apsico_aduanalDataSet12.Previos);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet2.Registro_Tramites' Puede moverla o quitarla según sea necesario.
            this.registro_TramitesTableAdapter.Fill(this.apsico_aduanalDataSet2.Registro_Tramites);
          con.Con_Agencia_Aduanal(dgvdatos);
          
        }

        private void dgvdatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //txtfolio.Text = dgvdatos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            Menu pre = new Menu();
            pre.Show();
        }
    }
}
