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
    public partial class AltaIsla : Form
    {
        public AltaIsla()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string NombreIsla=txtAltaIsla.Text;



            string cade = "insert into CatalogoIslas (NombreIsla) values ('" + NombreIsla + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            if (txtAltaIsla.Text == "")
            {
                MessageBox.Show("Error, debe llenar el dato");
            }
            else
            {
                MessageBox.Show("se a dado de alta el numero de la isla");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuAdministrador men = new MenuAdministrador();
            men.Show();
            this.Hide();
        }

        private void AltaIsla_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BorrarIsla isl = new BorrarIsla();
            isl.Show();
            this.Hide();
        }
    }
}
