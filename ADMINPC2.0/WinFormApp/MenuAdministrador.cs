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
            LoginAdmin Menu = new LoginAdmin();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AltaIsla IslaAlta = new AltaIsla();
            IslaAlta.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AltaReactivo AltaReac = new AltaReactivo();
            AltaReac.Show();
            this.Hide();
        }
    }
}
