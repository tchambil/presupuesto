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
using Formularios;

namespace WinUI
{
    public partial class EspecificaDeGastoUI : Form
    {
        public EspecificaDeGastoUI()
        {
            InitializeComponent();
        }
        private Boolean Nuevo;
        List<Button> listBotones;
        private void EspecificaDeGastoUI_Load(object sender, EventArgs e)
        {
            listBotones = new List<Button>() { btnNuevo, btnGuardar, btnModificar, btnCancelar };
            dgvPartidasEspecificas.DefaultCellStyle.ForeColor = Color.Black;
            WinForm.BloquearTextBox(this);
            WinForm.LimpiarTextBox(this);
            DatosTabla();
            // txtBusqueda.Enabled = true;
            Botones.EstablecerEstadoBotones(listBotones, true);
            List<int> listaColumnas = new List<int>() { 2, 2 };
            Grilla.EsconderColumnas(dgvPartidasEspecificas, listaColumnas);
            string[] cabeceras = { "Partida Específica", "Descripción" };
            Grilla.PonerCabeceraAGrid(dgvPartidasEspecificas, cabeceras);
        }
        private void DatosTabla()
        {
            BUS.EspecificoDeGasto_BUS espe = new BUS.EspecificoDeGasto_BUS();
            dgvPartidasEspecificas.DataSource = espe.getEspecificasDeGastos();

        }
        private void SeleccionarFila()
        {
            txtPartidaEspecifica.Text = dgvPartidasEspecificas[0, dgvPartidasEspecificas.CurrentRow.Index].Value.ToString();
            txtDescripcion.Text = dgvPartidasEspecificas[1, dgvPartidasEspecificas.CurrentRow.Index].Value.ToString();
        }
        private void AgregarEspecificaDeGasto()
        {
            VO.EspecificoDeGasto_BUS esp = new VO.EspecificoDeGasto_BUS();

            esp.EGAS_VCH_IDESPECIFICADEGASTO = txtPartidaEspecifica.Text;
            esp.EGAS_VCH_DESCRIPCION = txtDescripcion.Text;

            BUS.EspecificoDeGasto_BUS espBUS = new BUS.EspecificoDeGasto_BUS();
            espBUS.AgregarEspecificaDeGasto(esp);

            MessageBox.Show("Se ha agregado una nueva Partida Específica...");
        }
        private void ModificarEspecificaDeGasto()
        {
            VO.EspecificoDeGasto_BUS esp = new VO.EspecificoDeGasto_BUS();

            //esp.EGAS_VCH_IDESPECIFICADEGASTO = Convert.ToString(dgvPartidasEspecificas.SelectedRows[0].Cells[0].Value);
            esp.EGAS_VCH_IDESPECIFICADEGASTO = txtPartidaEspecifica.Text;
            esp.EGAS_VCH_DESCRIPCION = txtDescripcion.Text;

            BUS.EspecificoDeGasto_BUS espBUS = new BUS.EspecificoDeGasto_BUS();
            espBUS.ModificarEspecificaDeGasto(esp);

            MessageBox.Show("Se ha modificado la Partida Específica...");
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            WinForm.LimpiarTextBox(this);
            WinForm.DesbloquearTextBox(this);
            Botones.EstablecerEstadoBotones(listBotones, false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo == true)
            {
                AgregarEspecificaDeGasto();
                WinForm.BloquearTextBox(this);
                DatosTabla();
                Botones.EstablecerEstadoBotones(listBotones, true);
            }
            else
            {
                ModificarEspecificaDeGasto();
                WinForm.BloquearTextBox(this);
                DatosTabla();
                Botones.EstablecerEstadoBotones(listBotones, true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            WinForm.DesbloquearTextBox(this);
            Botones.EstablecerEstadoBotones(listBotones, false);  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            WinForm.LimpiarTextBox(this);
            WinForm.BloquearTextBox(this);
            Botones.EstablecerEstadoBotones(listBotones, true);
        }

        private void dgvPartidasEspecificas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila();
        }
    }
      
}
