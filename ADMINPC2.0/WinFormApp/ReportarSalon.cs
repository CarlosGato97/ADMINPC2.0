using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormApp
{
    public partial class ReportarSalon : Form
    {
        public ReportarSalon()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Fecha = txtFecha.Text;
            string Hora = txtHora.Text;
            string Turno = txtTurno.Text;
            string DescripcionAula = txtDescripcion.Text;

            string cade = "insert into ReporteAula (Fecha, Hora, Turno, DescripcionAula) values ('" + Fecha + "','" + Hora + "','" + Turno + "','" + DescripcionAula + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("Reporte enviado correctamente");
            txtFecha.Text = "";
            txtHora.Text = "";
            txtTurno.Text = "";
            txtDescripcion.Text = "";


            conex.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
