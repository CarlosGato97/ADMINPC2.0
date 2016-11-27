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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Usuarios where Nombre='" + txtNombre.Text + "' and Matricula='" + txtMatricula.Text + "'",conex );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" )
            {
                MessageBox.Show("Bienvenido " + txtNombre.Text);
                Menu Menu = new Menu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifica tu nombre y matricula");
                txtNombre.Text = "";
                txtMatricula.Text = "";
            }
            conex.Close();


            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar Registra = new Registrar();
            Registra.Show();
            this.Hide();
        }

        private void LinkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
