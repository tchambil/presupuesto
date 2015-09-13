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
    public partial class SistemaControlPresupuestalUI : Form
    {
        public SistemaControlPresupuestalUI()
        {
            InitializeComponent();


            cmbEspecificaDeGasto.DropDownStyle = ComboBoxStyle.DropDownList;
 
        }
        int var = 0;
        private Boolean Nuevo;
        List<Button> listBotones;

        private void SistemaControlPresupuestalUI_Load(object sender, EventArgs e)
        {


            //-------------------------------------------------------------------------------------//
            listBotones = new List<Button>() { btnNuevo, btnGuardar, btnModificar, btnCancelar };
            dgvControlPresupuestal.DefaultCellStyle.ForeColor = Color.Black;
            WinForm.BloquearTextBox(this);
            WinForm.LimpiarTextBox(this);
            prcCargarCbDocumentos();
            prcCargarCbEspecificasDeGasto();
            prcPrepareMeta();
            prcList_ControlPrespuestal();
            // txtBusqueda.Enabled = true;

            Botones.EstablecerEstadoBotones(listBotones, true);
            List<int> listaColumnas = new List<int>() { 15, 16 };
            Grilla.EsconderColumnas(dgvControlPresupuestal, listaColumnas);
            dgvControlPresupuestal.Columns[1].Name = "N°";
            dgvControlPresupuestal.Columns[2].Name = "Doc.";
            dgvControlPresupuestal.Columns[3].Name = "#";
            dgvControlPresupuestal.Columns[4].Name = "Fecha de Ingreso";
            dgvControlPresupuestal.Columns[5].Name = "C/P";
            dgvControlPresupuestal.Columns[6].Name = "SIAF";
            dgvControlPresupuestal.Columns[7].Name = "Fecha de Giro";
            dgvControlPresupuestal.Columns[8].Name = "Fecha de Pago";
            dgvControlPresupuestal.Columns[9].Name = "Detalle";
            dgvControlPresupuestal.Columns[10].Name = "Concepto";
            dgvControlPresupuestal.Columns[11].Name = "Partida Específica";
            dgvControlPresupuestal.Columns[12].Name = "Partida Contable";
            dgvControlPresupuestal.Columns[13].Name = "0034";
            dgvControlPresupuestal.Columns[14].Name = "0062";
            dgvControlPresupuestal.Columns[15].Name = "0063";

            string[] cabeceras = { "N°", "Doc.", "#", "Fecha de Ingreso", "C/P", "SIAF", "Fecha de Giro", "Fecha de Pago", "Detalle", "Concepto", "Partida Específica", "Partida Contable", "0034", "0062", "0063", "Total" };
            Grilla.PonerCabeceraAGrid(dgvControlPresupuestal, cabeceras);
        }

        private void prcCargarCbDocumentos()
        {

            DataTable mDtDocumento = new Documento_BUS().getDocumento();
            if (mDtDocumento != null)
            {

                cmbDocumentos.DataSource = mDtDocumento;
                cmbDocumentos.DisplayMember = "DOCU_VCH_NOMBRE";
                cmbDocumentos.ValueMember = "DOCU_INT_IDDOCUMENTO";
                cmbDocumentos.SelectedIndex = -1;
            }
        }


        private void prcCargarCbEspecificasDeGasto()
        {

            DataTable mDtEspecificoDeGasto = new BUS.EspecificoDeGasto_BUS().getEspecificasDeGastos();
            if (mDtEspecificoDeGasto != null)
            {
                cmbEspecificaDeGasto.DataSource = mDtEspecificoDeGasto;
                cmbEspecificaDeGasto.DisplayMember = "EGAS_VCH_IDESPECIFICADEGASTO";
                cmbEspecificaDeGasto.ValueMember = "EGAS_VCH_IDESPECIFICADEGASTO";
                cmbEspecificaDeGasto.SelectedIndex = -1;
            }


        }
        private void prcList_ControlPrespuestal()
        {

            DataTable mDtControlPresupuestal = new BUS.ControlPresupuestal_BUS().List_ControlPresupuestal();
            if (mDtControlPresupuestal != null)
            {
                this.dgvControlPresupuestal.DataSource = null;
                this.dgvControlPresupuestal.DataSource = mDtControlPresupuestal;
                this.dgvControlPresupuestal.Update();
            }
        }
        private void prcList_DetalleControlPrespuestal(int inIdControlPresupuestal)
        {

            DataTable mDtDetalleControlPresupuestal = new BUS.DetalleControlPresupuestal_BUS().List_DetalleControlPresupuestal(inIdControlPresupuestal);
            if (mDtDetalleControlPresupuestal != null)
            {
                this.dgvDetalleControlPresupuestal.DataSource = null;
                this.dgvDetalleControlPresupuestal.DataSource = mDtDetalleControlPresupuestal;
                this.dgvDetalleControlPresupuestal.Update();
                prcCalculoMeta();
            }
        }
        private void prcCalculoMeta()
        {
            double sumatoria = 0;
             foreach (DataGridViewRow item in dgvDetalleControlPresupuestal.Rows)
            {
                sumatoria += Convert.ToDouble(item.Cells[1].Value);

            }
            this.lblTotalImporteMeta.Text = sumatoria.ToString();
        }
        private void prcSeleccionarFila()
        {
             cmbDocumentos.Text = dgvControlPresupuestal[1, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtNroDoc.Text = dgvControlPresupuestal[2, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            dtpFechaIngreso.Text = dgvControlPresupuestal[3, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtComprobante.Text = dgvControlPresupuestal[4, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtSIAF.Text = dgvControlPresupuestal[5, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            dtpFechaGiro.Text = dgvControlPresupuestal[6, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            dtpFechaPago.Text = dgvControlPresupuestal[7, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtConcepto.Text = dgvControlPresupuestal[8, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtDetalle.Text = dgvControlPresupuestal[9, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            cmbEspecificaDeGasto.Text = dgvControlPresupuestal[10, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtPartidaContable.Text = dgvControlPresupuestal[11, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            txtId.Text = dgvControlPresupuestal[0, dgvControlPresupuestal.CurrentRow.Index].Value.ToString();
            prcList_DetalleControlPrespuestal(Convert.ToInt32(dgvControlPresupuestal[0, dgvControlPresupuestal.CurrentRow.Index].Value));
        }
        private void prcPrepareMeta()
        {
            dgvDetalleControlPresupuestal.Rows.Clear();
            string[] row_0034 = new string[] { "0034", "0.00" };
            dgvDetalleControlPresupuestal.Rows.Add(row_0034);
            string[] row_0062 = new string[] { "0062", "0.00" };
            dgvDetalleControlPresupuestal.Rows.Add(row_0062);
            string[] row_0063 = new string[] { "0063", "0.00" };
            dgvDetalleControlPresupuestal.Rows.Add(row_0063);

        }
        private ControlPresupuestal_VO prcGetControlPresupuestal()
        {
            ControlPresupuestal_VO pControlPresupuestal = new ControlPresupuestal_VO();
            pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL = Convert.ToInt32(this.txtId.Text); ;
            pControlPresupuestal.DOCU_INT_IDDOCUMENTO = Convert.ToInt32(cmbDocumentos.SelectedValue);
            pControlPresupuestal.CPRE_VCH_NRODOCUMENTO = txtNroDoc.Text;
            pControlPresupuestal.CPRE_DAT_FECHAINGRESO = dtpFechaIngreso.Value;
            pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO = txtComprobante.Text;
            pControlPresupuestal.CPRE_VCH_NROSIAF = txtSIAF.Text;
            pControlPresupuestal.CPRE_DAT_FECHAGIRO = dtpFechaGiro.Value;
            pControlPresupuestal.CPRE_DAT_FECHAPAGO = dtpFechaPago.Value;
            pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE = txtPartidaContable.Text;
            pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO = this.txtConcepto.Text;
            pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO = this.txtDetalle.Text;
            pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO = this.cmbEspecificaDeGasto.SelectedValue.ToString();

            return pControlPresupuestal;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Nuevo = true;
            WinForm.LimpiarTextBox(this);
            WinForm.DesbloquearTextBox(this);
            Botones.EstablecerEstadoBotones(listBotones, false);
            txtId.Text = "0";

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Guardar el Registro?", "Control Presupuestal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ControlPresupuestal_VO pControlPresupuestal = new ControlPresupuestal_VO();
                pControlPresupuestal = this.prcGetControlPresupuestal();

                DataTable DtDetalleControlPresupuestal = new DataTable();
                DtDetalleControlPresupuestal = this.prcGetDetalleControlPresupuestal();

                if (Nuevo == true)
                {
                    if (new ControlPresupuestal_BUS().Insert_ControlPresupuestal(ref pControlPresupuestal, DtDetalleControlPresupuestal))
                    {
                        this.txtId.Text = pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL.ToString();
                        WinForm.BloquearTextBox(this);
                        prcList_ControlPrespuestal();
                        Botones.EstablecerEstadoBotones(listBotones, true);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }

                }
                else
                {

                    if (new ControlPresupuestal_BUS().Update_ControlPresupuestal(pControlPresupuestal, DtDetalleControlPresupuestal))
                    {
                                                WinForm.BloquearTextBox(this);
                        prcList_ControlPrespuestal();
                        Botones.EstablecerEstadoBotones(listBotones, true);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }
                }
            }

        }
        private DataTable prcGetDetalleControlPresupuestal()
        {
            DataTable DtDetalleControlPresupuestal = new DataTable();
            DtDetalleControlPresupuestal.Columns.Add("META_VCH_IDMETA");
            DtDetalleControlPresupuestal.Columns.Add("DCPR_DEC_IMPORTE");
            DataRow DrDetalleControlPresupuestal = null;
            foreach (DataGridViewRow item in dgvDetalleControlPresupuestal.Rows)
            {
                DrDetalleControlPresupuestal = DtDetalleControlPresupuestal.NewRow();
                DrDetalleControlPresupuestal["META_VCH_IDMETA"] = item.Cells["colMeta"].Value;
                DrDetalleControlPresupuestal["DCPR_DEC_IMPORTE"] = item.Cells["colImporte"].Value;
                DtDetalleControlPresupuestal.Rows.Add(DrDetalleControlPresupuestal);
            }
            return DtDetalleControlPresupuestal;
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


        private void btnVer_Click(object sender, EventArgs e)
        {
            EspecificaDeGastoUI esp = new EspecificaDeGastoUI();
            esp.ShowDialog();

        }
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            DetalleControlPresupuestalUI det = new DetalleControlPresupuestalUI(var);
            det.ShowDialog();
            this.Show();
        }

        private void dgvControlPresupuestal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prcSeleccionarFila();
        }
        
        private void dgvControlPresupuestal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMeta_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                double NroCell;
                if(!Double.TryParse(e.FormattedValue.ToString(),out NroCell))
                {    e.Cancel = true;
                    this.dgvDetalleControlPresupuestal.Rows[this.dgvDetalleControlPresupuestal.CurrentRow.Index].Cells["colImporte"].Value = 0;
                    MessageBox.Show("Ingreso Numeros");
                }
            }
        }
    }
}
