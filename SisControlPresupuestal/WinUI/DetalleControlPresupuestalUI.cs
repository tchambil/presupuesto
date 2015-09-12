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
            txtID.Text = var.ToString();
            listBotones = new List<Button>() { btnNuevo, btnGuardar, btnModificar, btnCancelar };
            dgvDetalleDevengados.DefaultCellStyle.ForeColor = Color.Black;
            WinForm.BloquearTextBox(this);
          //  WinForm.LimpiarTextBox(this);
            DatosTabla();    

            Botones.EstablecerEstadoBotones(listBotones, true);
            List<int> listaColumnas = new List<int>() { 15, 17 };
            Grilla.EsconderColumnas(dgvDetalleDevengados, listaColumnas);

            string[] cabeceras = { "", "","PIM", "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO","SET","OCT","NOV","DIC","Total","Saldo" };
            Grilla.PonerCabeceraAGrid(dgvDetalleDevengados, cabeceras);
        }
        private void DatosTabla()
        {
            DetalleControlPresupuestal_BUS deven = new DetalleControlPresupuestal_BUS();
            //dgvDetalleDevengados.DataSource = deven.VerDetalleControlPresupuestal(txtID.Text);
        //    dgvDatos.DataSource = dat.BusquedaDeDatosDePlanilla(txtID.Text);

        }
        private void CalculoTotal()
        {
            foreach(DataGridViewRow item in dgvDetalleDevengados.Rows)
            {
                int n = item.Index;
                dgvDetalleDevengados.Rows[n].Cells[15].Value =
                (Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[3].Value.ToString()) + 
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[4].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[5].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[6].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[7].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[8].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[9].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[10].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[11].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[12].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[13].Value.ToString()) +
                Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[14].Value.ToString()) 
                ).ToString();
            }
            txtTotal.Text = "0";
            foreach (DataGridViewRow item in dgvDetalleDevengados.Rows)
            {
                int n = item.Index;

                txtTotal.Text = (Decimal.Parse(txtTotal.Text.ToString())
                    + Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[15].Value.ToString())).ToString();
            }
        }
        private void CalculoSaldo()
        {
            txtSaldo.Text = "0";
            foreach (DataGridViewRow item in dgvDetalleDevengados.Rows)
            {
                int n = item.Index;

                txtSaldo.Text = (Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[2].Value.ToString()) - Decimal.Parse(txtTotal.Text.ToString())).ToString();
                dgvDetalleDevengados.Rows[n].Cells[16].Value = txtSaldo.Text;
            }
        }
        #region Calculos Pasados
    
        //private void CalculoSaldo()
        //{
        //    foreach (DataGridViewRow item in dgvDetalleDevengados.Rows)
        //    {
        //        int n = item.Index;
        //        txtTotal.Text = (Decimal.Parse(txtTotal.Text.ToString())
        //            + Decimal.Parse(dgvDetalleDevengados.Rows[n].Cells[14].Value.ToString())).ToString();
        //    }
        //}
        //private void CalculoTotalDevengados()
        //{
        //    //int i = this.dgvDevengados.RowCount; 
        //    //decimal sum=0;
        //    //for (i = 1; i < dgvDevengados.RowCount; i++)
        //    //{
        //    //    sum += Convert.ToDecimal(dgvDevengados.Rows[i].Cells[7].Value.ToString());
        //    //}
        //    decimal sumatoria = 0;
        //    foreach (DataGridViewRow row in dgvDetalleDevengados.Rows)
        //    {
        //        sumatoria += Convert.ToDecimal(row.Cells["Enero"].Value) + Convert.ToDecimal(row.Cells["Febrero"].Value);
        //    }
        //    txtTotal.Text = Convert.ToString(sumatoria);
        //}
        //private void CalculoDeSaldo()
        //{
        //    decimal totdeven = Convert.ToDecimal(txtTotal.Text);
        //    decimal pim = Convert.ToDecimal(txtPIM.Text);
        //    decimal saldo = 0;
        //    saldo = pim - totdeven;
        //    txtSaldo.Text = Convert.ToString(saldo);
        //}
        #endregion 
        private void CalculoPIM()
        {
            if ((rbtnAumentar.Checked == true) && (rbtnDisminuir.Checked == false))
            {
                decimal suma = Convert.ToDecimal(txtPIM.Text);
                suma += Convert.ToDecimal(txtAumentar.Text);
              //  MessageBox.Show("Presupuesto Inicial ¡Actualizado! igual a " + suma);
                txtPIM.Text = suma.ToString();
            }
            else if ((rbtnDisminuir.Checked == true) && (rbtnAumentar.Checked == false))
            {
                decimal resta = Convert.ToDecimal(txtPIM.Text); ;
                resta -= Convert.ToDecimal(txtDisminuir.Text);
              //  MessageBox.Show("Presupuesto Inicial ¡Actualizado! igual a " + resta);
                txtPIM.Text = resta.ToString();
            }
        }
        //private void SeleccionarFila()
        //{
        //    // cbUsuarios.SelectedIndex = cbUsuarios.FindStringExact(dgvPlanillas[1, dgvPlanillas.CurrentRow.Index].Value.ToString());
        //    //var = Convert.ToInt32(dgvPlanillas[0, dgvPlanillas.CurrentRow.Index].Value.ToString());
        //    //lblID.Text = var.ToString();
        //    ///////////////////////////////////////////////////////////////////////////////////////////////
        //    txtIdDevengado.Text = dgvDetalleDevengados[1, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtPIM.Text = dgvDetalleDevengados[2, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtEnero.Text = dgvDetalleDevengados[3, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtFebrero.Text = dgvDetalleDevengados[4, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtMarzo.Text = dgvDetalleDevengados[5, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtAbril.Text = dgvDetalleDevengados[6, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtMayo.Text = dgvDetalleDevengados[7, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtJunio.Text = dgvDetalleDevengados[8, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtJulio.Text = dgvDetalleDevengados[9, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtAgosto.Text = dgvDetalleDevengados[10, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtSetiembre.Text = dgvDetalleDevengados[11, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtOctubre.Text = dgvDetalleDevengados[12, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtNoviembre.Text = dgvDetalleDevengados[13, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtDiciembre.Text = dgvDetalleDevengados[14, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtTotal.Text = dgvDetalleDevengados[15, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();
        //    txtSaldo.Text = dgvDetalleDevengados[16, dgvDetalleDevengados.CurrentRow.Index].Value.ToString();

        //}
        //private void AgregarDetalleDevengado()
        //{
        //    DetalleControlPresupuestalVO detdevengado = new DetalleControlPresupuestalVO();
        ////    detdevengado.IdDevengados = var;
        //    detdevengado.Pim = Convert.ToDecimal(txtPIM.Text);
        //    detdevengado.Enero = Convert.ToDecimal(txtEnero.Text);
        //    detdevengado.Febrero = Convert.ToDecimal(txtFebrero.Text);
        //    detdevengado.Marzo = Convert.ToDecimal(txtMarzo.Text);
        //    detdevengado.Abril = Convert.ToDecimal(txtAbril.Text);
        //    detdevengado.Mayo = Convert.ToDecimal(txtMayo.Text);
        //    detdevengado.Junio = Convert.ToDecimal(txtJunio.Text);
        //    detdevengado.Julio = Convert.ToDecimal(txtJulio.Text);
        //    detdevengado.Agosto = Convert.ToDecimal(txtAgosto.Text);
        //    detdevengado.Setiembre = Convert.ToDecimal(txtSetiembre.Text);
        //    detdevengado.Octubre = Convert.ToDecimal(txtOctubre.Text);
        //    detdevengado.Noviembre = Convert.ToDecimal(txtNoviembre.Text);
        //    detdevengado.Diciembre = Convert.ToDecimal(txtDiciembre.Text);
        //    detdevengado.TotalDevengados = Convert.ToDecimal(txtTotal.Text);
        //    detdevengado.Saldo = Convert.ToDecimal(txtSaldo.Text);

        //    DetalleControlPresupuestalBUS detdevenBUS = new DetalleControlPresupuestalBUS();
        //    detdevenBUS.AgregarDetalleDevengado(detdevengado);

        //    MessageBox.Show("Se ha agregado un Nuevo Detalle...");
        //}
        //private void ModificarDetalleDevengado()
        //{
        //    DetalleControlPresupuestalVO detdevengado = new DetalleControlPresupuestalVO();

        //    detdevengado.IdDetalleDevengados = Convert.ToInt32(dgvDetalleDevengados.SelectedRows[0].Cells[0].Value);
        //    detdevengado.IdDevengados = Convert.ToInt32(txtID.Text);
        //    detdevengado.Pim = Convert.ToDecimal(txtPIM.Text);
        //    detdevengado.Enero = Convert.ToDecimal(txtEnero.Text);
        //    detdevengado.Febrero = Convert.ToDecimal(txtFebrero.Text);
        //    detdevengado.Marzo = Convert.ToDecimal(txtMarzo.Text);
        //    detdevengado.Abril = Convert.ToDecimal(txtAbril.Text);
        //    detdevengado.Mayo = Convert.ToDecimal(txtMayo.Text);
        //    detdevengado.Junio = Convert.ToDecimal(txtJunio.Text);
        //    detdevengado.Julio = Convert.ToDecimal(txtJulio.Text);
        //    detdevengado.Agosto = Convert.ToDecimal(txtAgosto.Text);
        //    detdevengado.Setiembre = Convert.ToDecimal(txtSetiembre.Text);
        //    detdevengado.Octubre = Convert.ToDecimal(txtOctubre.Text);
        //    detdevengado.Noviembre = Convert.ToDecimal(txtNoviembre.Text);
        //    detdevengado.Diciembre = Convert.ToDecimal(txtDiciembre.Text);
        //    detdevengado.TotalDevengados = Convert.ToDecimal(txtTotal.Text);
        //    detdevengado.Saldo = Convert.ToDecimal(txtSaldo.Text);

        //    DetalleControlPresupuestalBUS devenBUS = new DetalleControlPresupuestalBUS();
        //    devenBUS.ModificarDetalleDevengado(detdevengado);

        //    MessageBox.Show("Se ha modificado la Especificación de Gasto...");
        //}
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            rbtnAumentar.Enabled = false;
            rbtnDisminuir.Enabled = false;
            txtAumentar.ReadOnly = true;
            txtDisminuir.ReadOnly = true;
            txtSaldo.Text = "";
            txtTotal.Text = "";
           // WinForm.LimpiarTextBox(this);
            WinForm.DesbloquearTextBox(this);
            Botones.EstablecerEstadoBotones(listBotones, false);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo == true)
            {

              //  AgregarDetalleDevengado();
                CalculoTotal();
                WinForm.BloquearTextBox(this);
                DatosTabla();
                Botones.EstablecerEstadoBotones(listBotones, true);
            }
            else
            {
               // ModificarDetalleDevengado();
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
            //txtBusqueda.Enabled = true;
            Botones.EstablecerEstadoBotones(listBotones, true);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SistemaControlPresupuestalUI pla = new SistemaControlPresupuestalUI();
            this.Hide();
            this.Close();
        }

        private void dgvDetalleDevengados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  SeleccionarFila();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculoTotal();
            CalculoSaldo();
        }

      
    }
}
