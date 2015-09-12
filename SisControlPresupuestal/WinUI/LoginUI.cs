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
using VO;

namespace WinUI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
           // if(new BienvenidaCarreteras().ShowDialog()== DialogResult.Yes)
            InitializeComponent();
     

        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool Encuentra = false;
            Usuario_BUS usuBUS = new Usuario_BUS();
            Usuario_VO usuVO = usuBUS.Login(txtUsuario.Text, ref Encuentra);
            
            if (Encuentra == true)
            {
                if (txtPass.Text == usuVO.USU_VCH_PASSWORD)
                {
                    MessageBox.Show("Bienvenido al Sistema : " + usuVO.USU_VCH_NOMBRE + " " + usuVO.USU_VCH_APELLIDOS,"Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //SistemaEjecucionDevengadosUI stm = new SistemaEjecucionDevengadosUI();
                    //stm.Show();
                    
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Usuario Invalido");
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Realmente desea salir del sistema?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.Show();
        }
    }
}
