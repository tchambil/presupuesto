namespace WinUI
{
    partial class SistemaControlPresupuestalUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecificaDeGasto = new System.Windows.Forms.ComboBox();
            this.dgvControlPresupuestal = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbDocumentos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtSIAF = new System.Windows.Forms.TextBox();
            this.dtpFechaGiro = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalImporteMeta = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPartidaContable = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleControlPresupuestal = new System.Windows.Forms.DataGridView();
            this.colMeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colnro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFGiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartidaEspecifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartidaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col0034 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col0062 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col0063 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPresupuestal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleControlPresupuestal)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especifica Gasto:";
            // 
            // cmbEspecificaDeGasto
            // 
            this.cmbEspecificaDeGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecificaDeGasto.FormattingEnabled = true;
            this.cmbEspecificaDeGasto.Location = new System.Drawing.Point(101, 83);
            this.cmbEspecificaDeGasto.Name = "cmbEspecificaDeGasto";
            this.cmbEspecificaDeGasto.Size = new System.Drawing.Size(128, 21);
            this.cmbEspecificaDeGasto.TabIndex = 3;
            // 
            // dgvControlPresupuestal
            // 
            this.dgvControlPresupuestal.AllowUserToAddRows = false;
            this.dgvControlPresupuestal.AllowUserToDeleteRows = false;
            this.dgvControlPresupuestal.AllowUserToResizeRows = false;
            this.dgvControlPresupuestal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvControlPresupuestal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlPresupuestal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnro,
            this.coldocumento,
            this.colNroDocumento,
            this.colFIngreso,
            this.colCP,
            this.colSiaf,
            this.colFGiro,
            this.colFPago,
            this.colDetalle,
            this.colConcepto,
            this.colPartidaEspecifica,
            this.colPartidaContable,
            this.col0034,
            this.col0062,
            this.col0063,
            this.colTotal});
            this.dgvControlPresupuestal.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvControlPresupuestal.Location = new System.Drawing.Point(16, 214);
            this.dgvControlPresupuestal.MultiSelect = false;
            this.dgvControlPresupuestal.Name = "dgvControlPresupuestal";
            this.dgvControlPresupuestal.ReadOnly = true;
            this.dgvControlPresupuestal.RowHeadersVisible = false;
            this.dgvControlPresupuestal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlPresupuestal.Size = new System.Drawing.Size(1299, 375);
            this.dgvControlPresupuestal.TabIndex = 6;
            this.dgvControlPresupuestal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlPresupuestal_CellClick);
            this.dgvControlPresupuestal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlPresupuestal_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(73, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "EJECUCIÓN DEVENGADOS VS MARCO PRESUPUESTAL";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(542, 596);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(623, 596);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(705, 595);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(787, 596);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbDocumentos
            // 
            this.cmbDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentos.FormattingEnabled = true;
            this.cmbDocumentos.Location = new System.Drawing.Point(51, 20);
            this.cmbDocumentos.Name = "cmbDocumentos";
            this.cmbDocumentos.Size = new System.Drawing.Size(209, 21);
            this.cmbDocumentos.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(51, 22);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaIngreso.TabIndex = 26;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(235, 81);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(45, 23);
            this.btnVer.TabIndex = 27;
            this.btnVer.Text = "Ver...";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(441, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 18);
            this.lblID.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nro. ";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDoc.Location = new System.Drawing.Point(327, 21);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(91, 20);
            this.txtNroDoc.TabIndex = 31;
            // 
            // txtSIAF
            // 
            this.txtSIAF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSIAF.Location = new System.Drawing.Point(393, 18);
            this.txtSIAF.Name = "txtSIAF";
            this.txtSIAF.Size = new System.Drawing.Size(91, 20);
            this.txtSIAF.TabIndex = 35;
            // 
            // dtpFechaGiro
            // 
            this.dtpFechaGiro.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpFechaGiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGiro.Location = new System.Drawing.Point(101, 49);
            this.dtpFechaGiro.Name = "dtpFechaGiro";
            this.dtpFechaGiro.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaGiro.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Fecha de Giro";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(395, 50);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaPago.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fecha de Pago";
            // 
            // lblTotalImporteMeta
            // 
            this.lblTotalImporteMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalImporteMeta.Location = new System.Drawing.Point(108, 128);
            this.lblTotalImporteMeta.Name = "lblTotalImporteMeta";
            this.lblTotalImporteMeta.Size = new System.Drawing.Size(77, 17);
            this.lblTotalImporteMeta.TabIndex = 43;
            this.lblTotalImporteMeta.Text = "lblTotalImporteMeta";
            this.lblTotalImporteMeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(101, 135);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(383, 20);
            this.txtDetalle.TabIndex = 55;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(101, 109);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(383, 20);
            this.txtConcepto.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Detalle:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Concepto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Partida Contable:";
            // 
            // txtPartidaContable
            // 
            this.txtPartidaContable.Location = new System.Drawing.Point(393, 83);
            this.txtPartidaContable.Name = "txtPartidaContable";
            this.txtPartidaContable.Size = new System.Drawing.Size(91, 20);
            this.txtPartidaContable.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbDocumentos);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(65, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 58);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento";
            // 
            // txtComprobante
            // 
            this.txtComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComprobante.Location = new System.Drawing.Point(40, 18);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Size = new System.Drawing.Size(141, 20);
            this.txtComprobante.TabIndex = 32;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtComprobante);
            this.groupBox4.Controls.Add(this.txtPartidaContable);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtSIAF);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtDetalle);
            this.groupBox4.Controls.Add(this.dtpFechaGiro);
            this.groupBox4.Controls.Add(this.txtConcepto);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dtpFechaPago);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbEspecificaDeGasto);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnVer);
            this.groupBox4.Location = new System.Drawing.Point(561, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 169);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ejecución";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(347, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "SIAF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "C/P";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalleControlPresupuestal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTotalImporteMeta);
            this.groupBox2.Location = new System.Drawing.Point(1055, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 169);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso Importe(Metas)";
            // 
            // dgvDetalleControlPresupuestal
            // 
            this.dgvDetalleControlPresupuestal.AllowUserToAddRows = false;
            this.dgvDetalleControlPresupuestal.AllowUserToDeleteRows = false;
            this.dgvDetalleControlPresupuestal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleControlPresupuestal.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleControlPresupuestal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleControlPresupuestal.ColumnHeadersVisible = false;
            this.dgvDetalleControlPresupuestal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMeta,
            this.colImporte});
            this.dgvDetalleControlPresupuestal.Location = new System.Drawing.Point(8, 42);
            this.dgvDetalleControlPresupuestal.MultiSelect = false;
            this.dgvDetalleControlPresupuestal.Name = "dgvDetalleControlPresupuestal";
            this.dgvDetalleControlPresupuestal.RowHeadersVisible = false;
            this.dgvDetalleControlPresupuestal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDetalleControlPresupuestal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleControlPresupuestal.Size = new System.Drawing.Size(180, 83);
            this.dgvDetalleControlPresupuestal.TabIndex = 71;
            this.dgvDetalleControlPresupuestal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeta_CellContentClick);
            this.dgvDetalleControlPresupuestal.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMeta_CellValidating);
            // 
            // colMeta
            // 
            this.colMeta.DataPropertyName = "META_VCH_IDMETA";
            this.colMeta.HeaderText = "Meta";
            this.colMeta.Name = "colMeta";
            this.colMeta.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.DataPropertyName = "DCPR_DEC_IMPORTE";
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(79, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Importe";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Meta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFechaIngreso);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(65, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 58);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(935, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 20);
            this.txtId.TabIndex = 68;
            this.txtId.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Ver...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colnro
            // 
            this.colnro.DataPropertyName = "CPRE_INT_IDCONTROLPRESUPUESTAL";
            this.colnro.HeaderText = "N°";
            this.colnro.Name = "colnro";
            this.colnro.Width = 5;
            // 
            // coldocumento
            // 
            this.coldocumento.DataPropertyName = "DOCU_VCH_NOMBRE";
            this.coldocumento.HeaderText = "Documento";
            this.coldocumento.Name = "coldocumento";
            this.coldocumento.Width = 5;
            // 
            // colNroDocumento
            // 
            this.colNroDocumento.DataPropertyName = "CPRE_VCH_NRODOCUMENTO";
            this.colNroDocumento.HeaderText = "#";
            this.colNroDocumento.Name = "colNroDocumento";
            this.colNroDocumento.Width = 5;
            // 
            // colFIngreso
            // 
            this.colFIngreso.DataPropertyName = "CPRE_DAT_FECHAINGRESO";
            this.colFIngreso.HeaderText = "Fecha Ingreso";
            this.colFIngreso.Name = "colFIngreso";
            this.colFIngreso.Width = 5;
            // 
            // colCP
            // 
            this.colCP.DataPropertyName = "CPRE_VCH_NROCOMPROBANTEPAGO";
            this.colCP.HeaderText = "C/P";
            this.colCP.Name = "colCP";
            this.colCP.Width = 5;
            // 
            // colSiaf
            // 
            this.colSiaf.DataPropertyName = "CPRE_VCH_NROSIAF";
            this.colSiaf.HeaderText = "SIAF";
            this.colSiaf.Name = "colSiaf";
            this.colSiaf.Width = 5;
            // 
            // colFGiro
            // 
            this.colFGiro.DataPropertyName = "CPRE_DAT_FECHAGIRO";
            this.colFGiro.HeaderText = "Fecha Giro";
            this.colFGiro.Name = "colFGiro";
            this.colFGiro.Width = 5;
            // 
            // colFPago
            // 
            this.colFPago.DataPropertyName = "CPRE_DAT_FECHAPAGO";
            this.colFPago.HeaderText = "Fecha Pago";
            this.colFPago.Name = "colFPago";
            this.colFPago.Width = 5;
            // 
            // colDetalle
            // 
            this.colDetalle.DataPropertyName = "CPRE_VCH_DETALLEESPECIFICADEGASTO";
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Width = 5;
            // 
            // colConcepto
            // 
            this.colConcepto.DataPropertyName = "CPRE_VCH_CONCEPTOESPECIFICADEGASTO";
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.Width = 5;
            // 
            // colPartidaEspecifica
            // 
            this.colPartidaEspecifica.DataPropertyName = "EGAS_VCH_IDESPECIFICADEGASTO";
            this.colPartidaEspecifica.HeaderText = "Partida Especifica";
            this.colPartidaEspecifica.Name = "colPartidaEspecifica";
            this.colPartidaEspecifica.Width = 5;
            // 
            // colPartidaContable
            // 
            this.colPartidaContable.DataPropertyName = "CPRE_VCH_PARTIDACONTABLE";
            this.colPartidaContable.HeaderText = "Partida Contoble";
            this.colPartidaContable.Name = "colPartidaContable";
            this.colPartidaContable.Width = 5;
            // 
            // col0034
            // 
            this.col0034.DataPropertyName = "META_DEC_META_34";
            this.col0034.HeaderText = "0034";
            this.col0034.Name = "col0034";
            this.col0034.Width = 5;
            // 
            // col0062
            // 
            this.col0062.DataPropertyName = "META_DEC_META_62";
            this.col0062.HeaderText = "0062";
            this.col0062.Name = "col0062";
            this.col0062.Width = 5;
            // 
            // col0063
            // 
            this.col0063.DataPropertyName = "META_DEC_META_63";
            this.col0063.HeaderText = "0063";
            this.col0063.Name = "col0063";
            this.col0063.Width = 5;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "META_DEC_TOTAL";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 5;
            // 
            // SistemaControlPresupuestalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvControlPresupuestal);
            this.Name = "SistemaControlPresupuestalUI";
            this.Text = "Formulario Principal - Control Presupuestal";
            this.Load += new System.EventHandler(this.SistemaControlPresupuestalUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPresupuestal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleControlPresupuestal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecificaDeGasto;
        private System.Windows.Forms.DataGridView dgvControlPresupuestal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbDocumentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtSIAF;
        private System.Windows.Forms.DateTimePicker dtpFechaGiro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalImporteMeta;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPartidaContable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetalleControlPresupuestal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnro;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFGiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartidaEspecifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartidaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0034;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0062;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0063;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}