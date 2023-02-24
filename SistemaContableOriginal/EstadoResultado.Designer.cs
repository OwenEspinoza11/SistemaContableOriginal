namespace SistemaContableOriginal
{
    partial class EstadoResultado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.mtIngAct = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIngrOperaNeto = new System.Windows.Forms.TextBox();
            this.txtReslBruto = new System.Windows.Forms.TextBox();
            this.txtResultadoOperOrdinarias = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResultImpuestoGanancias = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUtiliodadNeta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mTDescuentoBon = new System.Windows.Forms.MaskedTextBox();
            this.mTCosteBienesVernd = new System.Windows.Forms.MaskedTextBox();
            this.mTGastoVentas = new System.Windows.Forms.MaskedTextBox();
            this.mTGastosAdm = new System.Windows.Forms.MaskedTextBox();
            this.mTGastosExtra = new System.Windows.Forms.MaskedTextBox();
            this.mTIngresosExtra = new System.Windows.Forms.MaskedTextBox();
            this.mTGastosFinancieros = new System.Windows.Forms.MaskedTextBox();
            this.mtIngresosFinancieros = new System.Windows.Forms.MaskedTextBox();
            this.mTGastoEjreAnteriores = new System.Windows.Forms.MaskedTextBox();
            this.mtImpGanancias = new System.Windows.Forms.MaskedTextBox();
            this.mTIngresoEjreAnteriores = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(32, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(7, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(600, 76);
            this.label18.TabIndex = 53;
            this.label18.Text = "FERRETERIA EL MARTILLITO\r\nEstado de Resultados\r\nA Febrero del 2022\r\n(Expresado en" +
    " cordobas oro)\r\n";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(7, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 183);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cuenta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso por actividades";
            // 
            // mtIngAct
            // 
            this.mtIngAct.Location = new System.Drawing.Point(103, 46);
            this.mtIngAct.Mask = "999999999999999999";
            this.mtIngAct.Name = "mtIngAct";
            this.mtIngAct.Size = new System.Drawing.Size(110, 23);
            this.mtIngAct.TabIndex = 2;
            this.mtIngAct.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coste de los bienes vendidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descuento por bonificaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(32, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado bruto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingresos extraordinarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gasto de ventas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(248, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Resultado de las operaciones ordinarias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(32, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ingresos Operativos netos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ingreso de ejercicios anteriores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gastos extraordinarios";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ingresos financieros";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Gasto de administracions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(511, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Gastos financieros";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(737, 574);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(101, 33);
            this.btnCalc.TabIndex = 27;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(737, 643);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 33);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(878, 643);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 33);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(878, 574);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 33);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIngrOperaNeto
            // 
            this.txtIngrOperaNeto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtIngrOperaNeto.Enabled = false;
            this.txtIngrOperaNeto.Location = new System.Drawing.Point(103, 170);
            this.txtIngrOperaNeto.Name = "txtIngrOperaNeto";
            this.txtIngrOperaNeto.Size = new System.Drawing.Size(110, 23);
            this.txtIngrOperaNeto.TabIndex = 31;
            // 
            // txtReslBruto
            // 
            this.txtReslBruto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtReslBruto.Enabled = false;
            this.txtReslBruto.Location = new System.Drawing.Point(103, 285);
            this.txtReslBruto.Name = "txtReslBruto";
            this.txtReslBruto.Size = new System.Drawing.Size(110, 23);
            this.txtReslBruto.TabIndex = 32;
            // 
            // txtResultadoOperOrdinarias
            // 
            this.txtResultadoOperOrdinarias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtResultadoOperOrdinarias.Enabled = false;
            this.txtResultadoOperOrdinarias.Location = new System.Drawing.Point(319, 170);
            this.txtResultadoOperOrdinarias.Name = "txtResultadoOperOrdinarias";
            this.txtResultadoOperOrdinarias.Size = new System.Drawing.Size(110, 23);
            this.txtResultadoOperOrdinarias.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(511, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Gastos de ejercicios anteriores";
            // 
            // txtResultImpuestoGanancias
            // 
            this.txtResultImpuestoGanancias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtResultImpuestoGanancias.Enabled = false;
            this.txtResultImpuestoGanancias.Location = new System.Drawing.Point(827, 46);
            this.txtResultImpuestoGanancias.Name = "txtResultImpuestoGanancias";
            this.txtResultImpuestoGanancias.Size = new System.Drawing.Size(110, 23);
            this.txtResultImpuestoGanancias.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(755, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(254, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Resultado antes del impuesto de las ganancias ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(755, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Impuesto a las ganancias ";
            // 
            // txtUtiliodadNeta
            // 
            this.txtUtiliodadNeta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUtiliodadNeta.Enabled = false;
            this.txtUtiliodadNeta.Location = new System.Drawing.Point(827, 170);
            this.txtUtiliodadNeta.Name = "txtUtiliodadNeta";
            this.txtUtiliodadNeta.Size = new System.Drawing.Size(110, 23);
            this.txtUtiliodadNeta.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(756, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Resultado neto";
            // 
            // mTDescuentoBon
            // 
            this.mTDescuentoBon.Location = new System.Drawing.Point(103, 109);
            this.mTDescuentoBon.Mask = "999999999999999999";
            this.mTDescuentoBon.Name = "mTDescuentoBon";
            this.mTDescuentoBon.Size = new System.Drawing.Size(110, 23);
            this.mTDescuentoBon.TabIndex = 42;
            this.mTDescuentoBon.ValidatingType = typeof(int);
            // 
            // mTCosteBienesVernd
            // 
            this.mTCosteBienesVernd.Location = new System.Drawing.Point(103, 222);
            this.mTCosteBienesVernd.Mask = "999999999999999999";
            this.mTCosteBienesVernd.Name = "mTCosteBienesVernd";
            this.mTCosteBienesVernd.Size = new System.Drawing.Size(110, 23);
            this.mTCosteBienesVernd.TabIndex = 43;
            this.mTCosteBienesVernd.ValidatingType = typeof(int);
            // 
            // mTGastoVentas
            // 
            this.mTGastoVentas.Location = new System.Drawing.Point(319, 46);
            this.mTGastoVentas.Mask = "999999999999999999";
            this.mTGastoVentas.Name = "mTGastoVentas";
            this.mTGastoVentas.Size = new System.Drawing.Size(110, 23);
            this.mTGastoVentas.TabIndex = 44;
            this.mTGastoVentas.ValidatingType = typeof(int);
            // 
            // mTGastosAdm
            // 
            this.mTGastosAdm.Location = new System.Drawing.Point(319, 109);
            this.mTGastosAdm.Mask = "999999999999999999";
            this.mTGastosAdm.Name = "mTGastosAdm";
            this.mTGastosAdm.Size = new System.Drawing.Size(110, 23);
            this.mTGastosAdm.TabIndex = 45;
            this.mTGastosAdm.ValidatingType = typeof(int);
            // 
            // mTGastosExtra
            // 
            this.mTGastosExtra.Location = new System.Drawing.Point(582, 222);
            this.mTGastosExtra.Mask = "999999999999999999";
            this.mTGastosExtra.Name = "mTGastosExtra";
            this.mTGastosExtra.Size = new System.Drawing.Size(110, 23);
            this.mTGastosExtra.TabIndex = 46;
            this.mTGastosExtra.ValidatingType = typeof(int);
            // 
            // mTIngresosExtra
            // 
            this.mTIngresosExtra.Location = new System.Drawing.Point(582, 170);
            this.mTIngresosExtra.Mask = "999999999999999999";
            this.mTIngresosExtra.Name = "mTIngresosExtra";
            this.mTIngresosExtra.Size = new System.Drawing.Size(110, 23);
            this.mTIngresosExtra.TabIndex = 47;
            this.mTIngresosExtra.ValidatingType = typeof(int);
            // 
            // mTGastosFinancieros
            // 
            this.mTGastosFinancieros.Location = new System.Drawing.Point(582, 109);
            this.mTGastosFinancieros.Mask = "999999999999999999";
            this.mTGastosFinancieros.Name = "mTGastosFinancieros";
            this.mTGastosFinancieros.Size = new System.Drawing.Size(110, 23);
            this.mTGastosFinancieros.TabIndex = 48;
            this.mTGastosFinancieros.ValidatingType = typeof(int);
            // 
            // mtIngresosFinancieros
            // 
            this.mtIngresosFinancieros.Location = new System.Drawing.Point(582, 46);
            this.mtIngresosFinancieros.Mask = "999999999999999999";
            this.mtIngresosFinancieros.Name = "mtIngresosFinancieros";
            this.mtIngresosFinancieros.Size = new System.Drawing.Size(110, 23);
            this.mtIngresosFinancieros.TabIndex = 49;
            this.mtIngresosFinancieros.ValidatingType = typeof(int);
            // 
            // mTGastoEjreAnteriores
            // 
            this.mTGastoEjreAnteriores.Location = new System.Drawing.Point(582, 341);
            this.mTGastoEjreAnteriores.Mask = "999999999999999999";
            this.mTGastoEjreAnteriores.Name = "mTGastoEjreAnteriores";
            this.mTGastoEjreAnteriores.Size = new System.Drawing.Size(110, 23);
            this.mTGastoEjreAnteriores.TabIndex = 50;
            this.mTGastoEjreAnteriores.ValidatingType = typeof(int);
            this.mTGastoEjreAnteriores.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTGastoEjreAnteriores_MaskInputRejected);
            // 
            // mtImpGanancias
            // 
            this.mtImpGanancias.Location = new System.Drawing.Point(827, 109);
            this.mtImpGanancias.Mask = "999999999999999999";
            this.mtImpGanancias.Name = "mtImpGanancias";
            this.mtImpGanancias.Size = new System.Drawing.Size(110, 23);
            this.mtImpGanancias.TabIndex = 51;
            this.mtImpGanancias.ValidatingType = typeof(int);
            // 
            // mTIngresoEjreAnteriores
            // 
            this.mTIngresoEjreAnteriores.Location = new System.Drawing.Point(582, 285);
            this.mTIngresoEjreAnteriores.Mask = "999999999999999999";
            this.mTIngresoEjreAnteriores.Name = "mTIngresoEjreAnteriores";
            this.mTIngresoEjreAnteriores.Size = new System.Drawing.Size(110, 23);
            this.mTIngresoEjreAnteriores.TabIndex = 52;
            this.mTIngresoEjreAnteriores.ValidatingType = typeof(int);
            // 
            // EstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 735);
            this.Controls.Add(this.mTIngresoEjreAnteriores);
            this.Controls.Add(this.mtImpGanancias);
            this.Controls.Add(this.mTGastoEjreAnteriores);
            this.Controls.Add(this.mtIngresosFinancieros);
            this.Controls.Add(this.mTGastosFinancieros);
            this.Controls.Add(this.mTIngresosExtra);
            this.Controls.Add(this.mTGastosExtra);
            this.Controls.Add(this.mTGastosAdm);
            this.Controls.Add(this.mTGastoVentas);
            this.Controls.Add(this.mTCosteBienesVernd);
            this.Controls.Add(this.mTDescuentoBon);
            this.Controls.Add(this.txtUtiliodadNeta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtResultImpuestoGanancias);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtResultadoOperOrdinarias);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtReslBruto);
            this.Controls.Add(this.txtIngrOperaNeto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtIngAct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstadoResultado";
            this.Text = "EstadoResultado";
            this.Load += new System.EventHandler(this.EstadoResultado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private MaskedTextBox mtIngAct;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private Button btnAdd;
        private TextBox txtIngrOperaNeto;
        private TextBox txtReslBruto;
        private TextBox txtResultadoOperOrdinarias;
        private Label label14;
        private TextBox txtResultImpuestoGanancias;
        private Label label15;
        private Label label16;
        private TextBox txtUtiliodadNeta;
        private Label label17;
        private MaskedTextBox mTDescuentoBon;
        private MaskedTextBox mTCosteBienesVernd;
        private MaskedTextBox mTGastoVentas;
        private MaskedTextBox mTGastosAdm;
        private MaskedTextBox mTGastosExtra;
        private MaskedTextBox mTIngresosExtra;
        private MaskedTextBox mTGastosFinancieros;
        private MaskedTextBox mtIngresosFinancieros;
        private MaskedTextBox mTGastoEjreAnteriores;
        private MaskedTextBox mtImpGanancias;
        private MaskedTextBox mTIngresoEjreAnteriores;
        private Label label18;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}