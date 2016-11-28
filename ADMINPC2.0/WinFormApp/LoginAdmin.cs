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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarAdmin MenuAdmin = new RegistrarAdmin();
            MenuAdmin.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From UsuarioAdmin where Nombre='" + txtNombre.Text + "' and RFC='" + txtRFC.Text + "'", conex);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Bienvenido " + txtNombre.Text);
                MenuAdministrador Menu = new MenuAdministrador();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifica tu nombre y RFC");
                txtNombre.Text = "";
                txtRFC.Text = "";
            }
            conex.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
