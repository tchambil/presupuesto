using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;

namespace WinUI
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
            
        }
        private void CargarConexion()
        {
            List<string> conexion = new CONEXION_BUS().LeerConexion();
            if (conexion.Count < 4)
            {
                txtServidor.Text = conexion[0];
                txtBD.Text = conexion[1];
            }
            else 
            {
                txtServidor.Text = conexion[0];
                txtBD.Text = conexion[1];
                txtUsuario.Text = conexion[2];
                txtContraseña.Text = conexion[3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion = @"Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBD.Text + ";User=" + txtUsuario.Text + ";Password=" + txtContraseña.Text;
            new CONEXION_BUS().EstablecerConexion(cadenaConexion);
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                con.Open();
                MessageBox.Show("Conexion Establecida!");
                con.Close();
                CargarConexion();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("La conexion es incorrecta!"); 
            }
        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            CargarConexion();
        }
    }
}
