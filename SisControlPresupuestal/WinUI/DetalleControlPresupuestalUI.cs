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
    public partial class DetalleControlPresupuestalUI : Form
    {
        public DetalleControlPresupuestalUI(int var)
        {
            InitializeComponent();
            this.var = var;
        }
        int var = 0;
        private Boolean Nuevo;
        List<Button> listBotones;
        private void DetalleEjecucionDevengadosUI_Load(object sender, EventArgs e)
        {
            listBotones = new List<Button>() { btnNuevo, btnGuardar, btnModificar, btnCancelar };
            dgvGastoEspecifico.DefaultCellStyle.ForeColor = Color.Black;
            WinForm.BloquearTextBox(this);
            prcList_Meta();
            prcCargarCbEspecificasDeGasto();
            prcList_MetaEspecificoDeGasto();
           

            Botones.EstablecerEstadoBotones(listBotones, true);
       
       
        }
        private void prcCargarCbEspecificasDeGasto()
        {

            DataTable mDtEspecificoDeGasto = new BUS.EspecificoDeGasto_BUS().getEspecificasDeGastos();
            
            if (mDtEspecificoDeGasto != null)
            {
                this.cmbEspecifica.DataSource = mDtEspecificoDeGasto;
                this.cmbEspecifica.DisplayMember = "EGAS_VCH_IDESPECIFICADEGASTO";
                this.cmbEspecifica.ValueMember = "EGAS_VCH_IDESPECIFICADEGASTO";
                this.cmbEspecifica.SelectedIndex = -1;
            }

        }
        private void prcList_MetaEspecificoDeGasto()
        {

            DataTable mDtMetaEspecificoDeGasto = new BUS.MetaEspecificoDeGasto_BUS().List_MetaEspecificaDeGasto( this.cmbMetas.SelectedValue.ToString());
            if (mDtMetaEspecificoDeGasto != null)
            {
                this.dgvGastoEspecifico.DataSource = null;
                this.dgvGastoEspecifico.DataSource = mDtMetaEspecificoDeGasto;
                this.dgvGastoEspecifico.Update();
            }
        }
        private void prcList_MetaEspecificoDeGastoModificado()
        {
            MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado = new MetaEspecificoDeGastoModificado_VO();
            DataTable mDtMetaEspecificoDeGastoModificado = new BUS.MetaEspecificoDeGastoModificado_BUS().List_MetaEspecificaDeGastoModificado(prcGetMetaEspecificoDeGasto());
            if (mDtMetaEspecificoDeGastoModificado != null)
            {
                this.dgvModificado.DataSource = null;
                this.dgvModificado.DataSource = mDtMetaEspecificoDeGastoModificado;
                this.dgvModificado.Update();
            }
        }
        private void prcList_Meta()
        {

            DataTable mDtMeta = new BUS.Meta_BUS().getMeta();
            if (mDtMeta != null)
            {
                this.cmbMetas.DataSource = null;
                this.cmbMetas.DataSource = mDtMeta;

                this.cmbMetas.DisplayMember = "META_VCH_IDMETA";
                this.cmbMetas.ValueMember = "META_VCH_IDMETA";
                this.cmbMetas.SelectedIndex = 1;
                this.cmbMetas.Update();
            }
        }
        private void CalculoTotal()
        {
            foreach(DataGridViewRow item in dgvGastoEspecifico.Rows)
            {
                int n = item.Index;
                dgvGastoEspecifico.Rows[n].Cells[15].Value =
                (Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[3].Value.ToString()) + 
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[4].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[5].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[6].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[7].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[8].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[9].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[10].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[11].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[12].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[13].Value.ToString()) +
                Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[14].Value.ToString()) 
                ).ToString();
            }
            txtTotal.Text = "0";
            foreach (DataGridViewRow item in dgvGastoEspecifico.Rows)
            {
                int n = item.Index;

                txtTotal.Text = (Decimal.Parse(txtTotal.Text.ToString())
                    + Decimal.Parse(dgvGastoEspecifico.Rows[n].Cells[15].Value.ToString())).ToString();
            }
        }
        private void CalculoSaldo()
        {
            
            foreach (DataGridViewRow item in dgvGastoEspecifico.Rows)
            {
                int n = item.Index;
 
            }
        }
        #region Calculos Pasados
     
        #endregion 
       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
          
           // WinForm.LimpiarTextBox(this);
            WinForm.DesbloquearTextBox(this);
            Botones.EstablecerEstadoBotones(listBotones, false);
            
        }
        private MetaEspecificoDeGasto_VO prcGetMetaEspecificoDeGasto()
        {
            MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();

            pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO = this.cmbEspecifica.SelectedValue.ToString();
            pMetaEspecificoDeGasto.MEGA_VCH_ANIO = this.txtAnio.Text.ToString();
            pMetaEspecificoDeGasto.META_VCH_IDMETA = this.cmbMetas.SelectedValue.ToString();
            pMetaEspecificoDeGasto.MEGA_DEC_PIM = Convert.ToDecimal(this.txtpim.Text);


            return pMetaEspecificoDeGasto;
        }
        private MetaEspecificoDeGastoModificado_VO prcGetMetaEspecificoDeGastoModificado()
        {
            MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado = new MetaEspecificoDeGastoModificado_VO();
            pMetaEspecificoDeGastoModificado.EGAS_VCH_IDESPECIFICADEGASTO = this.cmbEspecifica.SelectedValue.ToString();
            pMetaEspecificoDeGastoModificado.META_VCH_IDMETA = this.cmbMetas.SelectedValue.ToString();
            pMetaEspecificoDeGastoModificado.MEGM_DEC_PIMMODIFICADO = Convert.ToDecimal(this.txtPIModificado.ToString());
            return pMetaEspecificoDeGastoModificado;
        }
        private void prcSeleccionarFilaMetaEspefica()
        {
                txtAnio.Text = dgvGastoEspecifico["colAnio", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
                cmbMetas.SelectedValue = dgvGastoEspecifico["colIdMeta", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
                cmbEspecifica.SelectedValue = dgvGastoEspecifico["colEspecificaGasto", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
                txtpim.Text = dgvGastoEspecifico["colPIM", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
                 prcList_MetaEspecificoDeGastoModificado();
            
        }
        private void prcSeleccionarFilaMetaEspeficaModifica()
        {
            txtPIModificado.Text = dgvGastoEspecifico["colAnio", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();         

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿Guardar el Registro?", "Meta EspecificoDeGasto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();
                pMetaEspecificoDeGasto = this.prcGetMetaEspecificoDeGasto();
  
                if (Nuevo == true)
                {
                    if (new MetaEspecificoDeGasto_BUS().Insert_MetaEspecificoDeGasto(pMetaEspecificoDeGasto))
                    {
                       
                        WinForm.BloquearTextBox(this);
                        prcList_MetaEspecificoDeGasto();
                      
                        Botones.EstablecerEstadoBotones(listBotones, true);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }

                }
                else
                {

                    if (new MetaEspecificoDeGasto_BUS().Update_MetaEspecificoDeGasto(pMetaEspecificoDeGasto))
                    {
                        WinForm.BloquearTextBox(this);
                        prcList_MetaEspecificoDeGasto();
                        Botones.EstablecerEstadoBotones(listBotones, true);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }
                }
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
            //txtBusqueda.Enabled = true;
            Botones.EstablecerEstadoBotones(listBotones, true);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SistemaControlPresupuestalUI pla = new SistemaControlPresupuestalUI();
            this.Hide();
            this.Close();
        }

        private void dgvGastoEspecifico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prcSeleccionarFilaMetaEspefica();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoTotal();
            CalculoSaldo();
        }

        private void btnGuardarModifica_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Guardar el Registro?", "Modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado = new MetaEspecificoDeGastoModificado_VO();
                pMetaEspecificoDeGastoModificado = this.prcGetMetaEspecificoDeGastoModificado();

                if (Nuevo == true)
                {
                    if (new MetaEspecificoDeGastoModificado_BUS().Insert_MetaEspecificoDeGastoModificado(pMetaEspecificoDeGastoModificado))
                    {

                        WinForm.BloquearTextBox(this);
                        prcList_MetaEspecificoDeGastoModificado();

                        Botones.EstablecerEstadoBotones(listBotones, true);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }

                }
                else
                {

                    if (new MetaEspecificoDeGastoModificado_BUS().Update_MetaEspecificoDeGastoModificado(pMetaEspecificoDeGastoModificado))
                    {
                        WinForm.BloquearTextBox(this);
                        prcList_MetaEspecificoDeGastoModificado();
                        Botones.EstablecerEstadoBotones(listBotones, true);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }
                }
            }
        }

        private void txtPIModificado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
