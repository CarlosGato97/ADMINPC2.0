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
    public partial class AltaReactivo : Form
    {
        public AltaReactivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string NumeroReactivo = txtAltaReactivo.Text;



            string cade = "insert into CatalogoReactivo (NumeroReactivo) values ('" + NumeroReactivo + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            if (txtAltaReactivo.Text == "")
            {
                MessageBox.Show("Error, debe llenar el dato");
            }
            else
            {
                MessageBox.Show("se a dado de alta el numero del Reactivo");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuAdministrador men = new MenuAdministrador();
            men.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BorrarReactivo del = new BorrarReactivo();
            del.Show();
            this.Hide();
        }
    }
}
