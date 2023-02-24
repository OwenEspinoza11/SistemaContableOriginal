using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContableOriginal
{
    public partial class BalanceGeneral : Form
    {
        int n;
        TreeView tV = new TreeView();
        public BalanceGeneral()
        {
            InitializeComponent();
        }


        /*TEXTBOX TITULO*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*BOTON AGREGAR*/
        double monto, sumaActivos = 0, sumaPasivos = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            if (treeView1.SelectedNode.Text.Equals("")) {
                MessageBox.Show("Seleccione una opcion");
                treeView1.Focus();
            }else {

                if (treeView1.SelectedNode.Text.Equals("Caja"))
                {
                    nombreCuentas.Text = "Caja";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Caja";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Instituciones Bancarias"))
                {
                    nombreCuentas.Text = "Instituciones Bancarias";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Instituciones Bancarias";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Inversiones Disponibles Para La Venta"))
                {
                    nombreCuentas.Text = "Inversiones Disponibles Para La Venta";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Inversiones Disponibles Para La Venta";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Documentos Por Cobrar"))
                {
                    nombreCuentas.Text = "Documentos Por Cobrar";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Documentos Por Cobrar";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Inversiones Mantenidas Hasta El Vencimineto"))
                {
                    nombreCuentas.Text = "Inversiones Mantenidas Hasta El Vencimineto";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Inversiones Mantenidas Hasta El Vencimineto";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Inventario"))
                {
                    nombreCuentas.Text = "Inventario";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Inventario";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Edificio"))
                {
                    nombreCuentas.Text = "Edificio";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Edificio";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Vehiculos"))
                {
                    nombreCuentas.Text = "Vehiculos";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Vehiculos";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Maquinaria"))
                {
                    nombreCuentas.Text = "Maquinaria";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Maquinaria";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Planta y equipo"))
                {
                    nombreCuentas.Text = "Planta y equipo";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Planta y equipo";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Inversiones De Largo Plazo"))
                {
                    nombreCuentas.Text = "Inversiones De Largo Plazo";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Inversiones De Largo Plazo";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Otros Activos"))
                {
                    nombreCuentas.Text = "Otros Activos";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Otros Activos";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
                else if (treeView1.SelectedNode.Text.Equals("Activo Diferido"))
                {
                    nombreCuentas.Text = "Activo Diferido";
                    monto = Convert.ToDouble(maskedTextBox1.Text);
                    sumaActivos += monto;
                    n = dataMostrar.Rows.Add();

                    dataMostrar.Rows[n].Cells[0].Value = "Activo Diferido";
                    dataMostrar.Rows[n].Cells[1].Value = maskedTextBox1.Text;
                    Cambios();
                }
            }

        }

        private void btnAddPasivo_Click(object sender, EventArgs e)
        {

            /*Pasivos*/
            if (treeView2.SelectedNode.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una opcion");
                treeView2.Focus();
            }
            else
            {


                if (treeView2.SelectedNode.Text.Equals("Documentos Por Pagar"))
                {
                    nombreCuentasPasivos.Text = "Documentos Por Pagar";
                    monto = Convert.ToDouble(campoMontoPasivos.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Documentos Por Pagar";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoPasivos.Text;
                }
                else if (treeView2.SelectedNode.Text.Equals("Cuentas Por Pagar"))
                {
                    nombreCuentasPasivos.Text = "Cuentas Por Pagar";
                    monto = Convert.ToDouble(campoMontoPasivos.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Cuentas Por Pagar";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoPasivos.Text;
                }
                else if (treeView2.SelectedNode.Text.Equals("Otros Pasivos"))
                {
                    nombreCuentasPasivos.Text = "Otros Pasivos";
                    monto = Convert.ToDouble(campoMontoPasivos.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Otros Pasivos";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoPasivos.Text;
                }
                else if (treeView2.SelectedNode.Text.Equals("Documentos Por Pagar Relacionados"))
                {
                    nombreCuentasPasivos.Text = "Documentos Por Pagar Relacionados";
                    monto = Convert.ToDouble(campoMontoPasivos.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Documentos Por Pagar Relacionados";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoPasivos.Text;
                }
                else if (treeView2.SelectedNode.Text.Equals("Documentos Por Pagar a Bancos"))
                {
                    nombreCuentasPasivos.Text = "Documentos Por Pagar a Bancos";
                    monto = Convert.ToDouble(campoMontoPasivos.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Documentos Por Pagar a Bancos";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoPasivos.Text;
                }
                else if (treeView2.SelectedNode.Text.Equals("Otros Pasivos No Corrientes"))
                {
                    nombreCuentasPasivos.Text = "Otros Pasivos No Corrientes";
                    monto = Convert.ToDouble(campoMontoPasivos.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Otros Pasivos No Corrientes";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoPasivos.Text;
                }
            }
        }

        private void btnAddCap_Click(object sender, EventArgs e)
        {
            if (treeView3.SelectedNode.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una opcion");
                treeView3.Focus();
            }
            else {
                if (treeView3.SelectedNode.Text.Equals("Capital"))
                {
                    nombreCuentasCapital.Text = "Capital";
                    monto = Convert.ToDouble(campoMontoCapital.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Capital";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoCapital.Text;
                }
                else if (treeView3.SelectedNode.Text.Equals("Reserva Legal"))
                {
                    nombreCuentasCapital.Text = "Reserva Legal";
                    monto = Convert.ToDouble(campoMontoCapital.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Reserva Legal";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoCapital.Text;
                }
                else if (treeView3.SelectedNode.Text.Equals("Reserva Facultativa"))
                {
                    nombreCuentasCapital.Text = "Reserva Facultativa";
                    monto = Convert.ToDouble(campoMontoCapital.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Reserva Facultativa";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoCapital.Text;
                }
                else if (treeView3.SelectedNode.Text.Equals("Utilidad Acumulada"))
                {
                    nombreCuentasCapital.Text = "Utilidad Acumulada";
                    monto = Convert.ToDouble(campoMontoCapital.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Utilidad Acumulada";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoCapital.Text;
                }
                else if (treeView3.SelectedNode.Text.Equals("Utilidades Del Ejercicio"))
                {
                    nombreCuentasCapital.Text = "Utilidades Del Ejercicio";
                    monto = Convert.ToDouble(campoMontoCapital.Text);
                    sumaPasivos += monto;
                    n = dataMostrarPasivos.Rows.Add();

                    dataMostrarPasivos.Rows[n].Cells[0].Value = "Utilidades Del Ejercicio";
                    dataMostrarPasivos.Rows[n].Cells[1].Value = campoMontoCapital.Text;
                }

            }
        }

        //Aqui muestra en el label 
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nombreCuentasPasivos.Text = treeView2.SelectedNode.Text;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nombreCuentas.Text = treeView1.SelectedNode.Text;
        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nombreCuentasCapital.Text = treeView3.SelectedNode.Text;
        }
        //public void Agregar()
        //{
        //    //TreeView tV = new TreeView();
        //    nombreCuentas.Text = tV.Text;
        //    //DataGridView dG = new DataGridView();

        //    monto = Convert.ToDouble(maskedTextBox1.Text);


        //    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
        //    row.Cells[0].Value = tV.SelectedNode.Text;
        //    row.Cells[1].Value = maskedTextBox1.Text;
        //    dataGridView1.Rows.Add(row);
        //}
        public void Cambios() {
            nombreCuentas.Text = "Nombre de la cuenta";
            maskedTextBox1.Clear();
        }

        private void activarActivos_Click(object sender, EventArgs e)
        {
            if (activarActivos.Checked == true)
            {
                treeView2.Enabled = false;
                campoMontoPasivos.Enabled = false;
                treeView3.Enabled = false;
                btnAddPasivo.Enabled = false;
                btnAddCap.Enabled = false;
                btnAddPasivo.Enabled = false;
                btnActivarPasivos.Enabled = false;
                btnActCapital.Enabled = false;
                campoMontoCapital.Enabled = false;

            } else if (activarActivos.Checked == false) {
                treeView2.Enabled = true;
                campoMontoPasivos.Enabled = true;
                treeView3.Enabled = true;
                btnAddPasivo.Enabled = true;
                btnActivarPasivos.Enabled = true;
                btnActCapital.Enabled = true;
                btnAddCap.Enabled = true;
                campoMontoCapital.Enabled = true;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (btnActivarPasivos.Checked == true)
            {
                treeView1.Enabled = false;
                maskedTextBox1.Enabled = false;
                treeView3.Enabled = false;
                btnAdd.Enabled = false;
                activarActivos.Enabled = false;
                btnActCapital.Enabled=false;
                btnAddCap.Enabled = false;
                campoMontoCapital.Enabled = false;

            }
            else if (btnActivarPasivos.Checked == false)
            {
                treeView1.Enabled = true;
                maskedTextBox1.Enabled = true;
                treeView3.Enabled = true;
                activarActivos.Enabled = true;
                btnAdd.Enabled = true;
                btnActCapital.Enabled = true;
                btnAddCap.Enabled = true;
                campoMontoCapital.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataMostrar.Rows.RemoveAt(n);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularTActivo_Click(object sender, EventArgs e)
        {
            campoTotalActivo.Text = sumaActivos.ToString();
            campoPasMasCap.Text = sumaPasivos.ToString();

            if (sumaActivos == sumaPasivos)
            {
                MessageBox.Show("SU TOTAL ACTIVO ES IGUAL A SU TOTAL PASIVO, FELICIDADES");
            }
            else {
                MessageBox.Show("SU TOTAL ACTIVO NO IGUAL A SU TOTAL PASIVO, REVISE BIEN");
                return;
            }

        }

        private void btnActCapital_Click(object sender, EventArgs e)
        {
            if (btnActCapital.Checked == true)
            {
                treeView1.Enabled = false;
                maskedTextBox1.Enabled = false;
                treeView2.Enabled = false;
                btnAdd.Enabled=false;
                btnActivarPasivos.Enabled=false;
                activarActivos.Enabled = false;
                btnAddPasivo.Enabled = false;
                campoMontoPasivos.Enabled = false;
            }
            else {
                treeView1.Enabled = true;
                maskedTextBox1.Enabled = true;
                treeView2.Enabled = true;
                btnAdd.Enabled = true;
                btnActivarPasivos.Enabled = true;
                activarActivos.Enabled = true;
                btnAddPasivo.Enabled = true;
                campoMontoPasivos.Enabled = true;
            }
            
        }
    }
}
