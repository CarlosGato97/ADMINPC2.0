using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class ReporteAula : Form
    {
        public ReporteAula()
        {
            InitializeComponent();
        }

        private void ReporteAula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDMINPCDataSet6.ReporteAula' table. You can move, or remove it, as needed.
            this.reporteAulaTableAdapter.Fill(this.aDMINPCDataSet6.ReporteAula);


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrador MenuAdmin = new MenuAdministrador();
            MenuAdmin.Show();
            this.Hide();
        }
    }
}
