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

            prcCargaControlPrespuestal();
            WinForm.pfActiveControl(this, false);
            prcActiveButton(true, true);
            WinForm.pfCleanTextBox(this);
            prcInitCbo();
            this.dgvControlPresupuestal.ClearSelection();

            this.dgvControlPresupuestal.Enabled = true;
        }
        private void prcInitCbo()
        {
            prcCargarCbDocumentos();
            prcCargarCbEspecificasDeGasto();
            this.cmbDocumentos.SelectedValue = -1;
            this.cmbEspecificaDeGasto.SelectedValue = -1;
        }
        private void prcInitDataGriview()
        {
            prcCargarCbEspecificasDeGasto();

        }
        private void prcActiveButton(bool b_pState, bool b_lMod)
        {
            WinForm.pfActiveButon(this, b_pState);
            this.btnCancelar.Enabled = !b_pState;
            this.btnGuardar.Enabled = !b_pState;
            this.btnModificar.Enabled = b_lMod;
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
        private void prcCargaControlPrespuestal()
        {

            DataTable mDtControlPresupuestal = new BUS.ControlPresupuestal_BUS().List_ControlPresupuestal();
            if (mDtControlPresupuestal != null)
            {
                Int32 i = 0;

                this.dgvControlPresupuestal.Rows.Clear();
                foreach (DataRow rw in mDtControlPresupuestal.Rows)
                {
                    dgvControlPresupuestal.Rows.Add();
                    int RowIndex = dgvControlPresupuestal.RowCount - 1;
                    DataGridViewRow R = dgvControlPresupuestal.Rows[RowIndex];
                    R.Cells["colnro"].Value = rw["CPRE_INT_IDCONTROLPRESUPUESTAL"];
                    R.Cells["coldocumento"].Value = rw["DOCU_VCH_NOMBRE"];
                    R.Cells["colNroDocumento"].Value = rw["CPRE_VCH_NRODOCUMENTO"];
                    R.Cells["colFIngreso"].Value = rw["CPRE_DAT_FECHAINGRESO"];
                    R.Cells["colCP"].Value = rw["CPRE_VCH_NROCOMPROBANTEPAGO"];
                    R.Cells["colSiaf"].Value = rw["CPRE_VCH_NROSIAF"];
                    R.Cells["colFGiro"].Value = rw["CPRE_DAT_FECHAGIRO"];
                    R.Cells["colFPago"].Value = rw["CPRE_DAT_FECHAPAGO"];
                    R.Cells["colDetalle"].Value = rw["CPRE_VCH_DETALLEESPECIFICADEGASTO"];
                    R.Cells["colConcepto"].Value = rw["CPRE_VCH_CONCEPTOESPECIFICADEGASTO"];
                    R.Cells["colPartidaEspecifica"].Value = rw["EGAS_VCH_IDESPECIFICADEGASTO"];
                    R.Cells["colPartidaContable"].Value = rw["CPRE_VCH_PARTIDACONTABLE"];
                    R.Cells["col0034"].Value = rw["META_DEC_META_34"];
                    R.Cells["col0062"].Value = rw["META_DEC_META_62"];
                    R.Cells["col0063"].Value = rw["META_DEC_META_63"];
                    R.Cells["colTotal"].Value = rw["META_DEC_TOTAL"];

                }
            }
        }
        private void prcList_MetaControlPrespuestal(int inIdControlPresupuestal)
        {

            DataTable mDtDetalleControlPresupuestal = new BUS.DetalleControlPresupuestal_BUS().List_DetalleControlPresupuestal(inIdControlPresupuestal);

            if (mDtDetalleControlPresupuestal != null)
            {
                Int32 i = 0;
                dgvDetalleControlPresupuestal.Rows.Clear();
                foreach (DataRow rw in mDtDetalleControlPresupuestal.Rows)
                {
                    dgvDetalleControlPresupuestal.Rows.Add();
                    int RowIndex = dgvDetalleControlPresupuestal.RowCount - 1;
                    DataGridViewRow R = dgvDetalleControlPresupuestal.Rows[RowIndex];
                    R.Cells["colMeta"].Value = rw["META_VCH_IDMETA"];
                    R.Cells["colImporte"].Value = rw["DCPR_DEC_IMPORTE"];


                }
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
            prcList_MetaControlPrespuestal(Convert.ToInt32(dgvControlPresupuestal[0, dgvControlPresupuestal.CurrentRow.Index].Value));
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
            WinForm.pfCleanTextBox(this);
            WinForm.pfActiveControl(this, true);
            prcActiveButton(false, false);
            this.dgvControlPresupuestal.Enabled = false;
            this.dgvControlPresupuestal.ClearSelection();
            this.txtId.Text = "0";
            this.txtId.Enabled = false;
            prcPrepareMeta();

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
                       
                        prcCargaControlPrespuestal();
                     
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar Registro");
                    }
                }
                WinForm.pfActiveControl(this, false);
                prcActiveButton(true, true);

                prcCargaControlPrespuestal();

                this.dgvControlPresupuestal.Enabled = true;
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
            if (this.dgvDetalleControlPresupuestal.Rows.Count > 0)
            {
                Nuevo = false;
                WinForm.pfActiveControl(this, true);
                prcActiveButton(false, false);
                prcSeleccionarFila();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            WinForm.pfActiveControl(this, false);
            prcActiveButton(true, true);
            WinForm.pfCleanTextBox(this);
            this.dgvControlPresupuestal.ClearSelection();
            this.dgvControlPresupuestal.Enabled = true; 
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
                if (!Double.TryParse(e.FormattedValue.ToString(), out NroCell))
                {
                    e.Cancel = true;
                    this.dgvDetalleControlPresupuestal.Rows[this.dgvDetalleControlPresupuestal.CurrentRow.Index].Cells["colImporte"].Value = 0;
                    MessageBox.Show("Ingreso Numeros");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleControlPresupuestalUI esp = new DetalleControlPresupuestalUI(0);
            esp.ShowDialog();
        }
    }
}
