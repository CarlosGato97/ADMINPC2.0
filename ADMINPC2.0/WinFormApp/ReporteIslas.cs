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
    public partial class ReporteIslas : Form
    {
        public ReporteIslas()
        {
            InitializeComponent();
        }

        private void ReporteIslas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDMINPCDataSet5.ReportIslas' table. You can move, or remove it, as needed.
            this.reportIslasTableAdapter.Fill(this.aDMINPCDataSet5.ReportIslas);
 
        }

        private void btnVolverMenuAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministrador MenuAdmin = new MenuAdministrador();
            MenuAdmin.Show();
            this.Hide();
        }
    }
}
