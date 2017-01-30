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
using System.IO;

namespace APSICO_ADUANAL
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
              SqlConnection cn = new SqlConnection (); 
              SqlCommand cmd = new SqlCommand ();
              cn.ConnectionString = @"Data source  =  LENOVO-PC;  initial catalog  = Apsico_Aduanal; Integrated Security = True;";


              cmd.Connection = cn;

              cmd.CommandText = "Select  * from Usuarios where Nombre = '" + txtusuario.Text + "' and Contraseña = '" + txtcontraseña.Text + "'";

              int noRegistros = 0;

              cn.Open ();

              noRegistros = Convert.ToInt32 (cmd.ExecuteScalar ());

              cn.Close ();

              if(noRegistros > 0)
                 {
                     Administradores pre = new Administradores();
                     pre.Show();

                 } 
              else
                 {

                lblrespuesta.Text = "Usuario no registrado";

        }
    }
}
    }
