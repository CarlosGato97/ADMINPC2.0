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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Nombre = txtUsuario.Text;
            string Matricula = txtMatricula.Text;
            string RFC = txtRFC.Text;

            string cade = "insert into Usuarios(Nombre, Matricula, RFC) values ('" + Nombre + "','" + Matricula + "','" + RFC + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("Usuario registrado correctamente ");
            txtUsuario.Text = "";
            txtMatricula.Text = "";
            txtRFC.Text = "";

            conex.Close();




            Login Logi = new Login();
            Logi.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Hide();
        }
    }
}
