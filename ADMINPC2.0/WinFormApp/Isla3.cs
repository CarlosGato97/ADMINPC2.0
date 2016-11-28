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
    public partial class Isla3 : Form
    {
        public Isla3()
        {
            InitializeComponent();
        }

       

        private void Isla3_Load(object sender, EventArgs e)
        {

        }

        private void txtID3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Id3 = comboBoxID.Text;
            string NumIsla3 = comboBox1.Text;
            string Fecha3 = txtFecha3.Text;
            string Hora3 = txtHora3.Text;
            string Descripcion3 = txtDescripcion3.Text;


            string cade = "insert into ReportIslas (Id, NumIsla, Fecha, Hora, Descripcion) values ('" + Id3 + "','" + NumIsla3 + "','" + Fecha3 + "','" + Hora3 + "','" + Descripcion3 + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            if ((comboBoxID.Text == "") || (comboBox1.Text == "") || (txtFecha3.Text == "") || (txtHora3.Text == "") || (txtDescripcion3.Text == ""))
            {
                MessageBox.Show("Error, llena el dato que falta");
            }
            else
            {
                MessageBox.Show("Mensaje enviado correctamente ");
                comboBoxID.Text = "";
                comboBox1.Text = "";
                txtFecha3.Text = "";
                txtHora3.Text = "";
                txtDescripcion3.Text = "";

            }

        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
