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
    public partial class MDI : Form
    {
        public Conectar con;
        public MDI()
        {
            InitializeComponent();
        }

        public MDI(Conectar con) {
            this.con = con;
            InitializeComponent();
        }


        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceGeneral bg = new BalanceGeneral();
            bg.MdiParent = this;
            bg.Show();

        }

        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoResultado er = new EstadoResultado();
            er.MdiParent = this;
            er.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
