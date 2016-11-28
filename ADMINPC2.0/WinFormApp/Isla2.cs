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
    public partial class Isla2 : Form
    {
        public Isla2()
        {
            InitializeComponent();
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Id2 = comboBoxID.Text;
            string NumIsla2 = comboBoxNumIsla.Text;
            string Fecha2 = txtFecha2.Text;
            string Hora2 = txtHora2.Text;
            string Descripcion2 = txtDescripcion2.Text;


            string cade = "insert into ReportIslas (Id, NumIsla, Fecha, Hora, Descripcion) values ('" + Id2 + "','" + NumIsla2 + "','" + Fecha2 + "','" + Hora2 + "','" + Descripcion2 + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            MessageBox.Show("Mensaje enviado correctamente");
            comboBoxID.Text = "";
            comboBoxNumIsla.Text = "";
            txtFecha2.Text = "";
            txtHora2.Text = "";
            txtDescripcion2.Text = "";
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxNumIsla_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumIsla.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
