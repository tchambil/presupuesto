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
using System.Globalization;
using System.Threading;
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
        private Boolean b_Buscar;
        private void DetalleEjecucionDevengadosUI_Load(object sender, EventArgs e)
        {

            WinForm.pfActiveControl(this, true);
            prcActiveButton(true, false);
            prcInitCbo();
            //  prcList_MetaEspecificoDeGasto();
            prcList_Meta();
            prcList_CbEspecificasDeGasto();


        }
        private void prcInitCbo()
        {
            this.cmbMetas.Enabled = true;
            this.txtAnio.Enabled = true;
            this.cmbEspecifica.Enabled = false;
            this.txtpim.Enabled = false;
            this.txtpim.Text = "0";
            this.txtAnio.Text = DateTime.Today.Year.ToString();
            this.dgvGastoEspecifico.Enabled = true;
            this.btnGuardarModifica.Enabled = false;

        }
        private void prcActiveButton(bool b_pState, bool b_lMod)
        {
            WinForm.pfActiveButon(this, b_pState);
            this.btnCancelar.Enabled = !b_pState;
            this.btnGuardar.Enabled = !b_pState;
            this.btnBuscar.Enabled = b_pState;
            this.btnModificar.Enabled = b_lMod;
        }
        private void prcList_CbEspecificasDeGasto()
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
            MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();
            pMetaEspecificoDeGasto = this.prcGetMetaEspecificoDeGasto();


            DataTable mDtMetaEspecificoDeGasto = new MetaEspecificoDeGasto_BUS().List_MetaEspecificaDeGasto(pMetaEspecificoDeGasto);

            if (mDtMetaEspecificoDeGasto != null)
            {
                this.dgvGastoEspecifico.Rows.Clear();
                foreach (DataRow rw in mDtMetaEspecificoDeGasto.Rows)
                {
                    dgvGastoEspecifico.Rows.Add();
                    int RowIndex = dgvGastoEspecifico.RowCount - 1;
                    DataGridViewRow R = dgvGastoEspecifico.Rows[RowIndex];
                    R.Cells["colAnio"].Value = rw["MEGA_VCH_ANIO"];
                    R.Cells["colIdMeta"].Value = rw["META_VCH_IDMETA"];
                    R.Cells["colEspecificaGasto"].Value = rw["EGAS_VCH_IDESPECIFICADEGASTO"];
                    R.Cells["colPIM"].Value = rw["MEGA_DEC_PIM"];
                    R.Cells["colModifiacion"].Value = rw["MEGA_MODIFICACION"];
                    R.Cells["colPresupuesto"].Value = rw["MEGA_PRESUPUESTO"];
                    R.Cells["colEnero"].Value = rw["ENERO"];
                    R.Cells["colFebrero"].Value = rw["FEBRERO"];
                    R.Cells["colMarzo"].Value = rw["MARZO"];
                    R.Cells["colAbril"].Value = rw["ABRIL"];
                    R.Cells["colMayo"].Value = rw["MAYO"];
                    R.Cells["colJunio"].Value = rw["JUNIO"];
                    R.Cells["colJulio"].Value = rw["AGOSTO"];
                    R.Cells["colAgosto"].Value = rw["SEPTIEMBRE"];
                    R.Cells["colSetiembre"].Value = rw["OCTUBRE"];
                    R.Cells["colNoviembre"].Value = rw["NOVIEMBRE"];
                    R.Cells["colDiciembre"].Value = rw["DICIEMBRE"];
                    R.Cells["colEjecutado"].Value = rw["TOTALEJECUTADO"];
                    R.Cells["colSaldo"].Value = rw["SADOEJERCICIO"];
                }
            }
            prcCalculoTotalSaldo();
        }
        private void prcList_MetaEspecificoDeGastoModificado(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto)
        {

            DataTable mDtMetaEspecificoDeGastoModificado = new BUS.MetaEspecificoDeGastoModificado_BUS().List_MetaEspecificaDeGastoModificado(pMetaEspecificoDeGasto);
            if (mDtMetaEspecificoDeGastoModificado != null)
            {
                Int32 i = 0;
                dgvModificado.Rows.Clear();
                foreach (DataRow rw in mDtMetaEspecificoDeGastoModificado.Rows)
                {
                    dgvModificado.Rows.Add();
                    int RowIndex = dgvModificado.RowCount - 1;
                    DataGridViewRow R = dgvModificado.Rows[RowIndex];
                    R.Cells["colIdModificado"].Value = rw["MEGM_INT_IDMODIFICACION"];
                    R.Cells["colidMetaModificado"].Value = rw["META_VCH_IDMETA"];
                    R.Cells["colImporteModificado"].Value = rw["MEGM_DEC_PIMMODIFICADO"];
                    R.Cells["colIdEspecificaModificado"].Value = rw["EGAS_VCH_IDESPECIFICADEGASTO"];
                }
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
        private void prcCalculoTotalSaldo()
        {
            double sumatoria = 0;
            foreach (DataGridViewRow item in dgvGastoEspecifico.Rows)
            {
                sumatoria += Convert.ToDouble(item.Cells[19].Value);

            }
            this.txtTotal.Text = sumatoria.ToString("N2");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            WinForm.pfCleanTextBox(this);
            WinForm.pfActiveControl(this, true);
            prcActiveButton(false, false);
            this.cmbMetas.SelectedValue = -1;
            this.cmbEspecifica.SelectedValue = -1;
            this.txtAnio.Text = DateTime.Today.Year.ToString();

        }
        private MetaEspecificoDeGasto_VO prcGetMetaEspecificoDeGasto()
        {
            MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();
            if (b_Buscar)
            {
                pMetaEspecificoDeGasto.MEGA_VCH_ANIO = this.txtAnio.Text.ToString();
                pMetaEspecificoDeGasto.META_VCH_IDMETA = this.cmbMetas.SelectedValue.ToString();
            }
            else
            {
                pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO = this.cmbEspecifica.SelectedValue.ToString();
                pMetaEspecificoDeGasto.MEGA_VCH_ANIO = this.txtAnio.Text.ToString();
                pMetaEspecificoDeGasto.META_VCH_IDMETA = this.cmbMetas.SelectedValue.ToString();
                pMetaEspecificoDeGasto.MEGA_DEC_PIM = Convert.ToDecimal(this.txtpim.Text);
            }


            return pMetaEspecificoDeGasto;
        }

        private MetaEspecificoDeGastoModificado_VO prcGetMetaEspecificoDeGastoModificado()
        {
            MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado = new MetaEspecificoDeGastoModificado_VO();
            pMetaEspecificoDeGastoModificado.EGAS_VCH_IDESPECIFICADEGASTO = this.cmbEspecifica.SelectedValue.ToString();
            pMetaEspecificoDeGastoModificado.META_VCH_IDMETA = this.cmbMetas.SelectedValue.ToString();
            pMetaEspecificoDeGastoModificado.MEGM_DEC_PIMMODIFICADO = Convert.ToDecimal(this.txtPIModificado.Text);
            return pMetaEspecificoDeGastoModificado;
        }
        private void prcSeleccionarFilaMetaEspefica()
        {
            MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();
            txtAnio.Text = dgvGastoEspecifico["colAnio", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
            cmbMetas.SelectedValue = dgvGastoEspecifico["colIdMeta", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
            cmbEspecifica.SelectedValue = dgvGastoEspecifico["colEspecificaGasto", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
            txtpim.Text = dgvGastoEspecifico["colPIM", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();

            pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO = dgvGastoEspecifico["colEspecificaGasto", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();
            pMetaEspecificoDeGasto.META_VCH_IDMETA = dgvGastoEspecifico["colIdMeta", dgvGastoEspecifico.CurrentRow.Index].Value.ToString();


            prcList_MetaEspecificoDeGastoModificado(pMetaEspecificoDeGasto);

        }
        private void prcSeleccionarFilaMetaEspeficaModificado()
        {
            this.txtPIModificado.Text = dgvModificado["colImporteModificado", dgvModificado.CurrentRow.Index].Value.ToString();


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

                        WinForm.pfActiveButon(this, true);
                        prcList_MetaEspecificoDeGasto();

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
                        WinForm.pfActiveButon(this, true);
                        prcList_MetaEspecificoDeGasto();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }
                }
                WinForm.pfActiveControl(this, false);
                prcActiveButton(true, true);
                this.dgvGastoEspecifico.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            WinForm.pfActiveControl(this, true);
            prcActiveButton(false, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            WinForm.pfCleanTextBox(this);
            WinForm.pfActiveControl(this, false);
            prcActiveButton(true, false);
            prcInitCbo();
            //txtBusqueda.Enabled = true; 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SistemaControlPresupuestalUI pla = new SistemaControlPresupuestalUI();
            this.Hide();
            this.Close();
        }

        private void dgvGastoEspecifico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGastoEspecifico.Rows.Count - 1 > 0)
            {
                prcSeleccionarFilaMetaEspefica();
                this.btnModificar.Enabled = true;
                this.btnGuardarModifica.Enabled = true;
            }

        }



        private void btnGuardarModifica_Click(object sender, EventArgs e)
        {
            if (dgvGastoEspecifico.Rows.Count - 1 > 0)
            {
                if (!(this.txtPIModificado.Text.Equals("")))
                {


                    if (MessageBox.Show("¿Guardar el Registro?", "Modificaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado = new MetaEspecificoDeGastoModificado_VO();
                        pMetaEspecificoDeGastoModificado = this.prcGetMetaEspecificoDeGastoModificado();

                        MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();
                        pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO = pMetaEspecificoDeGastoModificado.EGAS_VCH_IDESPECIFICADEGASTO;
                        pMetaEspecificoDeGasto.META_VCH_IDMETA = pMetaEspecificoDeGastoModificado.META_VCH_IDMETA;

                        if (Nuevo == true)
                        {
                            if (new MetaEspecificoDeGastoModificado_BUS().Insert_MetaEspecificoDeGastoModificado(pMetaEspecificoDeGastoModificado))
                            {


                                prcList_MetaEspecificoDeGastoModificado(pMetaEspecificoDeGasto);
                                prcList_MetaEspecificoDeGasto();
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

                                prcList_MetaEspecificoDeGastoModificado(pMetaEspecificoDeGasto);
                                prcList_MetaEspecificoDeGasto();
                            }
                            else
                            {
                                MessageBox.Show("Error al guardar Registro");
                            }
                        }


                    }
                }
                else
                {

                    MessageBox.Show("Error al ingresa Importe");
                }
            }
        }

        private void txtPIModificado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvModificado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.prcSeleccionarFilaMetaEspeficaModificado();
        }

        private void dgvModificado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvModificado.Columns[e.ColumnIndex].Name == "colImporteModificado")
                {
                    if (e.Value != null)
                    {
                        if (Convert.ToDecimal(e.Value) < 0)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvGastoEspecifico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvGastoEspecifico.Columns[e.ColumnIndex].Name == "colModifiacion")
                {
                    if (e.Value != null)
                    {
                        if (Convert.ToDecimal(e.Value) < 0)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
                if (this.dgvGastoEspecifico.Columns[e.ColumnIndex].Name == "colSaldo")
                {
                    if (e.Value != null)
                    {
                        if (Convert.ToDecimal(e.Value) < 0)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtpim_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtpim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            b_Buscar = true;
            MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto = new MetaEspecificoDeGasto_VO();
            pMetaEspecificoDeGasto = this.prcGetMetaEspecificoDeGasto();

            DataTable mDtMetaEspecificoDeGasto = new MetaEspecificoDeGasto_BUS().List_MetaEspecificaDeGasto(pMetaEspecificoDeGasto);

            if (mDtMetaEspecificoDeGasto != null)
            {
                this.dgvGastoEspecifico.Rows.Clear();
                foreach (DataRow rw in mDtMetaEspecificoDeGasto.Rows)
                {
                    dgvGastoEspecifico.Rows.Add();
                    int RowIndex = dgvGastoEspecifico.RowCount - 1;
                    DataGridViewRow R = dgvGastoEspecifico.Rows[RowIndex];
                    R.Cells["colAnio"].Value = rw["MEGA_VCH_ANIO"];
                    R.Cells["colIdMeta"].Value = rw["META_VCH_IDMETA"];
                    R.Cells["colEspecificaGasto"].Value = rw["EGAS_VCH_IDESPECIFICADEGASTO"];
                    R.Cells["colPIM"].Value = rw["MEGA_DEC_PIM"];
                    R.Cells["colModifiacion"].Value = rw["MEGA_MODIFICACION"];
                    R.Cells["colPresupuesto"].Value = rw["MEGA_PRESUPUESTO"];
                    R.Cells["colEnero"].Value = rw["ENERO"];
                    R.Cells["colFebrero"].Value = rw["FEBRERO"];
                    R.Cells["colMarzo"].Value = rw["MARZO"];
                    R.Cells["colAbril"].Value = rw["ABRIL"];
                    R.Cells["colMayo"].Value = rw["MAYO"];
                    R.Cells["colJunio"].Value = rw["JUNIO"];
                    R.Cells["colJulio"].Value = rw["AGOSTO"];
                    R.Cells["colAgosto"].Value = rw["SEPTIEMBRE"];
                    R.Cells["colSetiembre"].Value = rw["OCTUBRE"];
                    R.Cells["colNoviembre"].Value = rw["NOVIEMBRE"];
                    R.Cells["colDiciembre"].Value = rw["DICIEMBRE"];
                    R.Cells["colEjecutado"].Value = rw["TOTALEJECUTADO"];
                    R.Cells["colSaldo"].Value = rw["SADOEJERCICIO"];
                }
                prcCalculoTotalSaldo();
            }
            b_Buscar = false;
        }

        private void btnModificarModifica_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoModifica_Click(object sender, EventArgs e)
        {
            txtPIModificado.Text = "";
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPIModificado_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
