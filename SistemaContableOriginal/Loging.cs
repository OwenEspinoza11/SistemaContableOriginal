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
    public partial class Loging : Form
    {
        int cont = 3;

        Conectar con;
        MDI mDI;
        BackgroundWorker bg = new BackgroundWorker();
        public Loging()
        {
            InitializeComponent();
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }
        //Barra de progreso//
        private void bg_DoWork(object sender, EventArgs e)
        {
            int progreso = 0, porciento = 0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i);
            }
        }
        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Style = ProgressBarStyle.Continuous;


            if (e.ProgressPercentage > 100)
            {
                label3.Text = "100%";
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                label3.Text = Convert.ToString(e.ProgressPercentage) + "%";
                progressBar1.Value = e.ProgressPercentage;
            }


        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            mDI = new MDI(con);
            mDI.Show();
            this.Hide();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Alerta");
                Cursor.Current = Cursors.Default;
                return;
            }

            con = new Conectar(txtUser.Text, txtPass.Text);

            if (this.con.conn.State == ConnectionState.Open)
            {

                bg.WorkerReportsProgress = true;
                bg.ProgressChanged += bg_ProgressChanged;
                bg.DoWork += bg_DoWork;
                bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                bg.RunWorkerAsync();
                label3.Visible = true;
                progressBar1.Visible = true;



            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    Thread.Sleep(3000);
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;

                }


            }
        }
    }
}
