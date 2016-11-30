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
    public partial class BorrarIsla : Form
    {
        public BorrarIsla()
        {
            InitializeComponent();
        }

        

        private void btnBus_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();
            string cod = txtBus.Text;
            string cade = "select NombreIsla from CatalogoIslas where NombreIsla=" + cod;

            SqlCommand coman = new SqlCommand(cade, conex);
            SqlDataReader regis = coman.ExecuteReader();

            if (regis.Read())
            {
                txtNumIsla.Text = regis["NombreIsla"].ToString();


                btnBorr.Enabled = true;
            }
            else
            {
                MessageBox.Show("El numero de isla no existe");
                conex.Close();
            }
        }
        private void btnBorr_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();
            string reac = txtBus.Text;

            string sqlIns = "DELETE FROM CatalogoIslas WHERE NombreIsla = " + reac;
            SqlCommand coman = new SqlCommand(sqlIns, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("La isla se a borrado");

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaIsla alt = new AltaIsla();
            alt.Show();
            this.Hide();
        }
    }
}
