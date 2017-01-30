using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using APSICO_ADUANAL.ClasesApAdu;

namespace APSICO_ADUANAL
{
    public partial class Registro_de_Previos : Form
    {
        Registrar Reg = new Registrar();
        Consultar con = new Consultar();
        Eliminar Eli = new Eliminar();
        Actualizar Act = new Actualizar();
        public Registro_de_Previos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Reg.Reg_Previos(cmbfoliopro.Text, cmbfolpre.Text, cmbfolage.Text, cmbAgencia.Text, txtfecha.Text, txthrs.Text, cmbtramitador.Text, txtestado.Text, txtdescripcion.Text))
            {
                con.Con_Previos(dgvdatos);
                MessageBox.Show("Registro correcto");
            }
            else
            {
                MessageBox.Show("Registro incorrecto");
            }
        }

        private void Registro_de_Previos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet11.Agencia_Aduanal' Puede moverla o quitarla según sea necesario.
            this.agencia_AduanalTableAdapter2.Fill(this.apsico_aduanalDataSet11.Agencia_Aduanal);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet10.Registro_Tramites' Puede moverla o quitarla según sea necesario.
            this.registro_TramitesTableAdapter.Fill(this.apsico_aduanalDataSet10.Registro_Tramites);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet9.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.apsico_aduanalDataSet9.Productos);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet8.Agencia_Aduanal' Puede moverla o quitarla según sea necesario.
            this.agencia_AduanalTableAdapter1.Fill(this.apsico_aduanalDataSet8.Agencia_Aduanal);
            // TODO: esta línea de código carga datos en la tabla 'apsico_aduanalDataSet7.Agencia_Aduanal' Puede moverla o quitarla según sea necesario.
            this.agencia_AduanalTableAdapter.Fill(this.apsico_aduanalDataSet7.Agencia_Aduanal);

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            con.Con_Previos(dgvdatos);
        }

        private void dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtpreviofol.Text = dgvdatos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Eli.Eli_Previos(txtpreviofol.Text))
            {
                con.Con_Previos(dgvdatos);
                MessageBox.Show("Eliminado");
            }

            else
            {
                MessageBox.Show("No es posible eliminar");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtpreviofol.Text.Length > 0)
            {
                if (Act.Previos(cmbfoliopro.Text, cmbfolpre.Text, cmbfolage.Text, cmbAgencia.Text, txtfecha.Text, txthrs.Text, cmbtramitador.Text, txtestado.Text, txtdescripcion.Text, txtpreviofol.Text))
                {
                    MessageBox.Show("Registros actualizado");
                }
                else
                    MessageBox.Show("No es posible actualizar el registro");
                con.Con_Previos(dgvdatos);

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            con.Con_Productos(dgvdatospro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source = LENOVO-PC; initial catalog = Apsico_aduanal; integrated security = true");
            SqlDataAdapter da;
            DataSet ds;
            SqlCommand cmd; 
            String cadSql="Select * From Productos where ProGuíaAerea ='"+ txtbuscar.Text +"'";


             SqlCommand comando = new SqlCommand (cadSql, con);

             con.Open ();


             SqlDataReader leer = comando.ExecuteReader (); 
            if (leer.Read () ==true)
             {

                 lblrespu.Text = leer["ProFolio"].ToString(); 


             } 
            else
             {

                 lblrespu.Text = "Esa guía no existe"; label1.Text = string.Empty;


             }

             con.Close ();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu pre = new Menu();
            pre.Show();
        }


    }
}
