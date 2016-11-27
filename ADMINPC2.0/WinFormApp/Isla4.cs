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
    public partial class Isla4 : Form
    {
        public Isla4()
        {
            InitializeComponent();
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Id = txtID4.Text;
            string NumIsla = txtNumIsla4.Text;
            string Fecha = txtFecha4.Text;
            string Hora = txtHora4.Text;
            string Descripcion = txtDescripcion4.Text;


            string cade = "insert into ReportIslas (Id, NumIsla, Fecha, Hora, Descripcion) values ('" + Id + "','" + NumIsla + "','" + Fecha + "','" + Hora + "','" + Descripcion + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("Mensaje enviado correctamente");
            txtID4.Text = "";
            txtNumIsla4.Text = "";
            txtFecha4.Text = "";
            txtHora4.Text = "";
            txtDescripcion4.Text = "";


            conex.Close();
        }

        private void btnVolver4_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
