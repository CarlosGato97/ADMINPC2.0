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
    public partial class BorrarReactivo : Form
    {
        public BorrarReactivo()
        {
            InitializeComponent();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();
            string cod = txtBus.Text;
            string cade = "select NumeroReactivo from CatalogoReactivo where NumeroReactivo=" + cod;

            SqlCommand coman = new SqlCommand(cade, conex);
            SqlDataReader regis = coman.ExecuteReader();

            if (regis.Read())
            {
                txtReac.Text = regis["NumeroReactivo"].ToString();
                

                btnBorr.Enabled = true;
            }
            else
            {
                MessageBox.Show("El reactivo que ingreso no existe");
                conex.Close();
            }
        }

        private void btnBorr_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();
            string reac = txtBus.Text;

            string sqlIns = "DELETE FROM CatalogoReactivo WHERE NumeroReactivo = " + reac;
            SqlCommand coman = new SqlCommand(sqlIns, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("El reactivo se a borrado");



        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaReactivo al = new AltaReactivo();
            al.Show();
            this.Hide();
        }
    }
}
