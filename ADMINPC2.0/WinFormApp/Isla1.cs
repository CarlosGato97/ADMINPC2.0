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
    public partial class Isla1 : Form
    {
        public Isla1()
        {
            InitializeComponent();
        }

        private void Isla1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {

            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Id = txtID.Text;
            string NumIsla = txtNumIsla.Text;
            string Fecha = txtFecha.Text;
            string Hora = txtHora.Text;
            string Descripcion = txtDescripcion.Text;


            string cade = "insert into ReportIslas (Id, NumIsla, Fecha, Hora, Descripcion) values ('" + Id + "','" + NumIsla + "','" + Fecha + "','" + Hora + "','" + Descripcion + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("Mensaje enviado correctamente");
            txtID.Text = "";
            txtNumIsla.Text = "";
            txtFecha.Text = "";
            txtHora.Text = "";
            txtDescripcion.Text = "";


            conex.Close(); 
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
