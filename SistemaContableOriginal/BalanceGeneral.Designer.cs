namespace SistemaContableOriginal
{
    partial class BalanceGeneral
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Caja");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Instituciones Bancarias");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inversiones Disponibles Para La Venta");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Documentos Por Cobrar");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Inversiones Mantenidas Hasta El Vencimiento");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Inventario");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Activo Corriente", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Edificios");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Vehiculos");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Maquinaria");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Planta y equipo");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Inversiones De Largo Plazo");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Otros Activos");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Activo Diferido");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Activo No Corriente", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Activo", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Documentos Por Pagar");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Cuentas Por Pagar");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Otros Pasivos");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Pasivo Corriente", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Documentos Por Pagar Relacionados");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Documentos Por Pagar a Bancos");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Otros Pasivos No corrientes");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Pasivo No Corriente", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Pasivo", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Capital");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Reserva Legal");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Reserva Facultativa");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Utilidad Acumulada");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Utilidades Del Ejercicio");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Patrimonio", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.nombreCuentas = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMostrar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstadoR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoPasMasCap = new System.Windows.Forms.MaskedTextBox();
            this.campoTotalActivo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMostrarPasivos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPasivo = new System.Windows.Forms.Button();
            this.campoMontoPasivos = new System.Windows.Forms.MaskedTextBox();
            this.nombreCuentasPasivos = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddCap = new System.Windows.Forms.Button();
            this.campoMontoCapital = new System.Windows.Forms.MaskedTextBox();
            this.nombreCuentasCapital = new System.Windows.Forms.Label();
            this.btnCalcularTActivo = new System.Windows.Forms.Button();
            this.activarActivos = new System.Windows.Forms.CheckBox();
            this.btnActivarPasivos = new System.Windows.Forms.CheckBox();
            this.btnActCapital = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarPasivos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 46);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Caja";
            treeNode2.Name = "Nodo3";
            treeNode2.Text = "Instituciones Bancarias";
            treeNode3.Name = "Nodo4";
            treeNode3.Text = "Inversiones Disponibles Para La Venta";
            treeNode4.Name = "Nodo5";
            treeNode4.Text = "Documentos Por Cobrar";
            treeNode5.Name = "Nodo6";
            treeNode5.Text = "Inversiones Mantenidas Hasta El Vencimiento";
            treeNode6.Name = "Nodo7";
            treeNode6.Text = "Inventario";
            treeNode7.Name = "Nodo1";
            treeNode7.Text = "Activo Corriente";
            treeNode8.Name = "Nodo9";
            treeNode8.Text = "Edificios";
            treeNode9.Name = "Nodo10";
            treeNode9.Text = "Vehiculos";
            treeNode10.Name = "Nodo11";
            treeNode10.Text = "Maquinaria";
            treeNode11.Name = "Nodo12";
            treeNode11.Text = "Planta y equipo";
            treeNode12.Name = "Nodo13";
            treeNode12.Text = "Inversiones De Largo Plazo";
            treeNode13.Name = "Nodo14";
            treeNode13.Text = "Otros Activos";
            treeNode14.Name = "Nodo15";
            treeNode14.Text = "Activo Diferido";
            treeNode15.Name = "Nodo8";
            treeNode15.Text = "Activo No Corriente";
            treeNode16.Name = "Nodo0";
            treeNode16.Text = "Activo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(308, 156);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(392, 46);
            this.treeView2.Name = "treeView2";
            treeNode17.Name = "Nodo2";
            treeNode17.Text = "Documentos Por Pagar";
            treeNode18.Name = "Nodo3";
            treeNode18.Text = "Cuentas Por Pagar";
            treeNode19.Name = "Nodo4";
            treeNode19.Text = "Otros Pasivos";
            treeNode20.Name = "Nodo1";
            treeNode20.Text = "Pasivo Corriente";
            treeNode21.Name = "Nodo6";
            treeNode21.Text = "Documentos Por Pagar Relacionados";
            treeNode22.Name = "Nodo7";
            treeNode22.Text = "Documentos Por Pagar a Bancos";
            treeNode23.Name = "Nodo8";
            treeNode23.Text = "Otros Pasivos No corrientes";
            treeNode24.Name = "Nodo5";
            treeNode24.Text = "Pasivo No Corriente";
            treeNode25.Name = "Nodo0";
            treeNode25.Text = "Pasivo";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25});
            this.treeView2.Size = new System.Drawing.Size(352, 156);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(795, 46);
            this.treeView3.Name = "treeView3";
            treeNode26.Name = "Nodo1";
            treeNode26.Text = "Capital";
            treeNode27.Name = "Nodo2";
            treeNode27.Text = "Reserva Legal";
            treeNode28.Name = "Nodo3";
            treeNode28.Text = "Reserva Facultativa";
            treeNode29.Name = "Nodo4";
            treeNode29.Text = "Utilidad Acumulada";
            treeNode30.Name = "Nodo5";
            treeNode30.Text = "Utilidades Del Ejercicio";
            treeNode31.Name = "Nodo0";
            treeNode31.Text = "Patrimonio";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31});
            this.treeView3.Size = new System.Drawing.Size(352, 156);
            this.treeView3.TabIndex = 2;
            this.treeView3.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView3_AfterSelect);
            // 
            // nombreCuentas
            // 
            this.nombreCuentas.Location = new System.Drawing.Point(6, 43);
            this.nombreCuentas.Name = "nombreCuentas";
            this.nombreCuentas.Size = new System.Drawing.Size(129, 20);
            this.nombreCuentas.TabIndex = 3;
            this.nombreCuentas.Text = "Nombre de la Cuenta";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 40);
            this.maskedTextBox1.Mask = "99999999999999999999999999999999999999999999999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(80, 23);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.nombreCuentas);
            this.groupBox1.Location = new System.Drawing.Point(28, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Activos";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "B A L A N C E      G E N E R A L";
            // 
            // dataMostrar
            // 
            this.dataMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataMostrar.Location = new System.Drawing.Point(38, 126);
            this.dataMostrar.Name = "dataMostrar";
            this.dataMostrar.RowTemplate.Height = 25;
            this.dataMostrar.Size = new System.Drawing.Size(425, 147);
            this.dataMostrar.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cuentras";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1026, 371);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 31);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Eliminar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1026, 691);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 31);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEstadoR
            // 
            this.btnEstadoR.Location = new System.Drawing.Point(901, 753);
            this.btnEstadoR.Name = "btnEstadoR";
            this.btnEstadoR.Size = new System.Drawing.Size(189, 31);
            this.btnEstadoR.TabIndex = 10;
            this.btnEstadoR.Text = "Generar Estado De Resultado";
            this.btnEstadoR.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(858, 55);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "FERRETERIA EL MARTILLITO\r\nDel 01 de enero al 31 de diciembre del 2021\r\nBALANCE GE" +
    "NERAL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.campoPasMasCap);
            this.groupBox2.Controls.Add(this.campoTotalActivo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataMostrarPasivos);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dataMostrar);
            this.groupBox2.Location = new System.Drawing.Point(87, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 359);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMACION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "T O T A L     P A S I V O + C A P I T A L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "T O T A L     A C T I V O";
            // 
            // campoPasMasCap
            // 
            this.campoPasMasCap.Location = new System.Drawing.Point(559, 307);
            this.campoPasMasCap.Name = "campoPasMasCap";
            this.campoPasMasCap.Size = new System.Drawing.Size(183, 23);
            this.campoPasMasCap.TabIndex = 16;
            // 
            // campoTotalActivo
            // 
            this.campoTotalActivo.Location = new System.Drawing.Point(38, 307);
            this.campoTotalActivo.Name = "campoTotalActivo";
            this.campoTotalActivo.Size = new System.Drawing.Size(183, 23);
            this.campoTotalActivo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "PASIVOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "ACTIVOS";
            // 
            // dataMostrarPasivos
            // 
            this.dataMostrarPasivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMostrarPasivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMostrarPasivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataMostrarPasivos.Location = new System.Drawing.Point(484, 126);
            this.dataMostrarPasivos.Name = "dataMostrarPasivos";
            this.dataMostrarPasivos.RowTemplate.Height = 25;
            this.dataMostrarPasivos.Size = new System.Drawing.Size(412, 147);
            this.dataMostrarPasivos.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuentras";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Imprimir PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPasivo);
            this.groupBox3.Controls.Add(this.campoMontoPasivos);
            this.groupBox3.Controls.Add(this.nombreCuentasPasivos);
            this.groupBox3.Location = new System.Drawing.Point(392, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 95);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Pasivos";
            // 
            // btnAddPasivo
            // 
            this.btnAddPasivo.Location = new System.Drawing.Point(227, 39);
            this.btnAddPasivo.Name = "btnAddPasivo";
            this.btnAddPasivo.Size = new System.Drawing.Size(72, 23);
            this.btnAddPasivo.TabIndex = 5;
            this.btnAddPasivo.Text = "Agregar";
            this.btnAddPasivo.UseVisualStyleBackColor = true;
            this.btnAddPasivo.Click += new System.EventHandler(this.btnAddPasivo_Click);
            // 
            // campoMontoPasivos
            // 
            this.campoMontoPasivos.Location = new System.Drawing.Point(141, 40);
            this.campoMontoPasivos.Mask = "99999999999999999999999999999999999999999999999999";
            this.campoMontoPasivos.Name = "campoMontoPasivos";
            this.campoMontoPasivos.Size = new System.Drawing.Size(80, 23);
            this.campoMontoPasivos.TabIndex = 4;
            this.campoMontoPasivos.ValidatingType = typeof(int);
            // 
            // nombreCuentasPasivos
            // 
            this.nombreCuentasPasivos.Location = new System.Drawing.Point(6, 43);
            this.nombreCuentasPasivos.Name = "nombreCuentasPasivos";
            this.nombreCuentasPasivos.Size = new System.Drawing.Size(129, 20);
            this.nombreCuentasPasivos.TabIndex = 3;
            this.nombreCuentasPasivos.Text = "Nombre de la Cuenta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddCap);
            this.groupBox4.Controls.Add(this.campoMontoCapital);
            this.groupBox4.Controls.Add(this.nombreCuentasCapital);
            this.groupBox4.Location = new System.Drawing.Point(795, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 95);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Capital";
            // 
            // btnAddCap
            // 
            this.btnAddCap.Location = new System.Drawing.Point(227, 39);
            this.btnAddCap.Name = "btnAddCap";
            this.btnAddCap.Size = new System.Drawing.Size(72, 23);
            this.btnAddCap.TabIndex = 5;
            this.btnAddCap.Text = "Agregar";
            this.btnAddCap.UseVisualStyleBackColor = true;
            this.btnAddCap.Click += new System.EventHandler(this.btnAddCap_Click);
            // 
            // campoMontoCapital
            // 
            this.campoMontoCapital.Location = new System.Drawing.Point(141, 40);
            this.campoMontoCapital.Mask = "99999999999999999999999999999999999999999999999999";
            this.campoMontoCapital.Name = "campoMontoCapital";
            this.campoMontoCapital.Size = new System.Drawing.Size(80, 23);
            this.campoMontoCapital.TabIndex = 4;
            this.campoMontoCapital.ValidatingType = typeof(int);
            // 
            // nombreCuentasCapital
            // 
            this.nombreCuentasCapital.Location = new System.Drawing.Point(6, 43);
            this.nombreCuentasCapital.Name = "nombreCuentasCapital";
            this.nombreCuentasCapital.Size = new System.Drawing.Size(129, 20);
            this.nombreCuentasCapital.TabIndex = 3;
            this.nombreCuentasCapital.Text = "Nombre de la Cuenta";
            // 
            // btnCalcularTActivo
            // 
            this.btnCalcularTActivo.Location = new System.Drawing.Point(1026, 652);
            this.btnCalcularTActivo.Name = "btnCalcularTActivo";
            this.btnCalcularTActivo.Size = new System.Drawing.Size(121, 31);
            this.btnCalcularTActivo.TabIndex = 19;
            this.btnCalcularTActivo.Text = "Calcular";
            this.btnCalcularTActivo.UseVisualStyleBackColor = true;
            this.btnCalcularTActivo.Click += new System.EventHandler(this.btnCalcularTActivo_Click);
            // 
            // activarActivos
            // 
            this.activarActivos.AutoSize = true;
            this.activarActivos.Location = new System.Drawing.Point(228, 203);
            this.activarActivos.Name = "activarActivos";
            this.activarActivos.Size = new System.Drawing.Size(105, 19);
            this.activarActivos.TabIndex = 20;
            this.activarActivos.Text = "Activar Activos";
            this.activarActivos.UseVisualStyleBackColor = true;
            this.activarActivos.Click += new System.EventHandler(this.activarActivos_Click);
            // 
            // btnActivarPasivos
            // 
            this.btnActivarPasivos.AutoSize = true;
            this.btnActivarPasivos.Location = new System.Drawing.Point(639, 203);
            this.btnActivarPasivos.Name = "btnActivarPasivos";
            this.btnActivarPasivos.Size = new System.Drawing.Size(105, 19);
            this.btnActivarPasivos.TabIndex = 21;
            this.btnActivarPasivos.Text = "Activar Pasivos";
            this.btnActivarPasivos.UseVisualStyleBackColor = true;
            this.btnActivarPasivos.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // btnActCapital
            // 
            this.btnActCapital.AutoSize = true;
            this.btnActCapital.Location = new System.Drawing.Point(1042, 203);
            this.btnActCapital.Name = "btnActCapital";
            this.btnActCapital.Size = new System.Drawing.Size(103, 19);
            this.btnActCapital.TabIndex = 22;
            this.btnActCapital.Text = "Activar Capital";
            this.btnActCapital.UseVisualStyleBackColor = true;
            this.btnActCapital.Click += new System.EventHandler(this.btnActCapital_Click);
            // 
            // BalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 749);
            this.Controls.Add(this.btnActCapital);
            this.Controls.Add(this.btnActivarPasivos);
            this.Controls.Add(this.activarActivos);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcularTActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEstadoR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Name = "BalanceGeneral";
            this.Text = "BalanceGeneral";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarPasivos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private TreeView treeView2;
        private TreeView treeView3;
        private Label nombreCuentas;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Label label1;
        private DataGridView dataMostrar;
        private Button btnEditar;
        private Button btnSalir;
        private Button btnEstadoR;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label3;
        private Label label2;
        private DataGridView dataMostrarPasivos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private GroupBox groupBox3;
        private Button btnAddPasivo;
        private MaskedTextBox campoMontoPasivos;
        private Label nombreCuentasPasivos;
        private GroupBox groupBox4;
        private Button btnAddCap;
        private MaskedTextBox campoMontoCapital;
        private Label nombreCuentasCapital;
        private Label label7;
        private Label label6;
        private MaskedTextBox campoPasMasCap;
        private MaskedTextBox campoTotalActivo;
        private Button btnCalcularTActivo;
        private CheckBox activarActivos;
        private CheckBox btnActivarPasivos;
        private CheckBox btnActCapital;
    }
}