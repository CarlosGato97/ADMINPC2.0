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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Menu = new Login();
            Menu.Show();
            this.Hide();
        }

        private void linkIslas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReporteIslas Islas = new ReporteIslas();
            Islas.Show();
            this.Hide();
        }

        private void linkLaboratorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReporteAula aula = new ReporteAula();
            aula.Show();
            this.Hide();
        }
    }
}
