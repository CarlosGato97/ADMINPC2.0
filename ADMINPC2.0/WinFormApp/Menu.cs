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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Menu = new Login();
            Menu.Show();
            this.Hide();
        }

        private void reportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Isla1 Islauno = new Isla1();
            Islauno.Show();
            this.Hide();
        }

        private void reportarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Isla2 Islados = new Isla2();
            Islados.Show();
            this.Hide();
        }

        private void reportarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Isla3 Islatres = new Isla3();
            Islatres.Show();
            this.Hide();
        }

        private void reportarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Isla4 Islacuatro = new Isla4();
            Islacuatro.Show();
            this.Hide();
        }

        private void reportarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Isla5 Islacinco = new Isla5();
            Islacinco.Show();
            this.Hide();
        }

        private void reportarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ReportarSalon ReportSalon = new ReportarSalon();
            ReportSalon.Show();
            this.Hide();
        }

        private void programasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Programas Programs = new Programas();
            Programs.Show();
            this.Hide();
        }
    }
}
