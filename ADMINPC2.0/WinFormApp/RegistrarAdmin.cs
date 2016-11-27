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
    public partial class RegistrarAdmin : Form
    {
        public RegistrarAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            LoginAdmin LoginAdm = new LoginAdmin();
            LoginAdm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Nombre = txtNombre.Text;
            string RFC = txtRFC.Text;

            string cade = "insert into UsuarioAdmin(Nombre, RFC) values ('" + Nombre + "','" + RFC + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("Administrador registrado correctamente");
            conex.Close();

            LoginAdmin Log = new LoginAdmin();
            Log.Show();
            this.Hide();
        }
    }
}
