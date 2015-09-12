namespace WinUI
{
    partial class DetalleControlPresupuestalUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAumentar = new System.Windows.Forms.TextBox();
            this.txtDisminuir = new System.Windows.Forms.TextBox();
            this.rbtnDisminuir = new System.Windows.Forms.RadioButton();
            this.txtPIM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnAumentar = new System.Windows.Forms.RadioButton();
            this.dgvDetalleDevengados = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMetas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDevengados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAumentar
            // 
            this.txtAumentar.Location = new System.Drawing.Point(468, 114);
            this.txtAumentar.Name = "txtAumentar";
            this.txtAumentar.Size = new System.Drawing.Size(57, 20);
            this.txtAumentar.TabIndex = 38;
            // 
            // txtDisminuir
            // 
            this.txtDisminuir.Location = new System.Drawing.Point(468, 137);
            this.txtDisminuir.Name = "txtDisminuir";
            this.txtDisminuir.Size = new System.Drawing.Size(57, 20);
            this.txtDisminuir.TabIndex = 37;
            // 
            // rbtnDisminuir
            // 
            this.rbtnDisminuir.AutoSize = true;
            this.rbtnDisminuir.Location = new System.Drawing.Point(395, 141);
            this.rbtnDisminuir.Name = "rbtnDisminuir";
            this.rbtnDisminuir.Size = new System.Drawing.Size(67, 17);
            this.rbtnDisminuir.TabIndex = 36;
            this.rbtnDisminuir.TabStop = true;
            this.rbtnDisminuir.Text = "Disminuir";
            this.rbtnDisminuir.UseVisualStyleBackColor = true;
            // 
            // txtPIM
            // 
            this.txtPIM.Location = new System.Drawing.Point(450, 82);
            this.txtPIM.Name = "txtPIM";
            this.txtPIM.Size = new System.Drawing.Size(75, 20);
            this.txtPIM.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "PIM:";
            // 
            // rbtnAumentar
            // 
            this.rbtnAumentar.AutoSize = true;
            this.rbtnAumentar.Location = new System.Drawing.Point(395, 116);
            this.rbtnAumentar.Name = "rbtnAumentar";
            this.rbtnAumentar.Size = new System.Drawing.Size(70, 17);
            this.rbtnAumentar.TabIndex = 45;
            this.rbtnAumentar.TabStop = true;
            this.rbtnAumentar.Text = "Aumentar";
            this.rbtnAumentar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleDevengados
            // 
            this.dgvDetalleDevengados.AllowUserToAddRows = false;
            this.dgvDetalleDevengados.AllowUserToDeleteRows = false;
            this.dgvDetalleDevengados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetalleDevengados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleDevengados.Location = new System.Drawing.Point(17, 230);
            this.dgvDetalleDevengados.Name = "dgvDetalleDevengados";
            this.dgvDetalleDevengados.ReadOnly = true;
            this.dgvDetalleDevengados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleDevengados.Size = new System.Drawing.Size(900, 143);
            this.dgvDetalleDevengados.TabIndex = 46;
            this.dgvDetalleDevengados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleDevengados_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(514, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(432, 179);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(350, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(269, 180);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 72;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Image = global::WinUI.Properties.Resources.Boton_Retroceder1;
            this.btnVolver.Location = new System.Drawing.Point(-1, -3);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(50, 48);
            this.btnVolver.TabIndex = 81;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(595, 179);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 82;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "META 0034";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "META 0063";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "META 0062";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 138);
            this.dataGridView1.TabIndex = 89;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 594);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(895, 127);
            this.dataGridView2.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "Metas:";
            // 
            // cmbMetas
            // 
            this.cmbMetas.FormattingEnabled = true;
            this.cmbMetas.Location = new System.Drawing.Point(450, 55);
            this.cmbMetas.Name = "cmbMetas";
            this.cmbMetas.Size = new System.Drawing.Size(75, 21);
            this.cmbMetas.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "FORMULARIO - DETALLE DE CONTROL PRESUPUESTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(685, 116);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(57, 20);
            this.txtTotal.TabIndex = 94;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(685, 142);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(57, 20);
            this.txtSaldo.TabIndex = 95;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(685, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 20);
            this.txtID.TabIndex = 96;
            // 
            // DetalleControlPresupuestalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 735);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbMetas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDetalleDevengados);
            this.Controls.Add(this.rbtnAumentar);
            this.Controls.Add(this.txtAumentar);
            this.Controls.Add(this.txtDisminuir);
            this.Controls.Add(this.rbtnDisminuir);
            this.Controls.Add(this.txtPIM);
            this.Controls.Add(this.label4);
            this.Name = "DetalleControlPresupuestalUI";
            this.Text = "Formulario-Detalle de Control Presupuestal";
            this.Load += new System.EventHandler(this.DetalleEjecucionDevengadosUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDevengados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAumentar;
        private System.Windows.Forms.TextBox txtDisminuir;
        private System.Windows.Forms.RadioButton rbtnDisminuir;
        private System.Windows.Forms.TextBox txtPIM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnAumentar;
        private System.Windows.Forms.DataGridView dgvDetalleDevengados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMetas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtID;
    }
}