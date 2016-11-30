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
    public partial class Islas : Form
    {
        public Islas()
        {
            InitializeComponent();
        }

        private void Islas_Load(object sender, EventArgs e)
        {
            SqlCommand command;
            string connetionString = "";
            SqlConnection connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = "";
            string sql2 = "";
            connetionString = "Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1";
            sql = "select Id_Reactivo , NumeroReactivo from CatalogoReactivo";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                
                ComboBoxId.DataSource = ds.Tables[0];
                ComboBoxId.ValueMember = "Id_Reactivo";
                ComboBoxId.DisplayMember = "NumeroReactivo";


                DataSet ds2 = new DataSet();
                sql2 = "select Id_Isla , NombreIsla from CatalogoIslas";
                command = new SqlCommand(sql2, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds2);
                adapter.Dispose();
                command.Dispose();
                
                comboBoxIsla.DataSource = ds2.Tables[0];
                comboBoxIsla.ValueMember = "Id_Isla";
                comboBoxIsla.DisplayMember = "NombreIsla";
                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not open connection ! ");
            }



        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Menu meni = new Menu();
            meni.Show();
            this.Hide();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Id = ComboBoxId.Text;
            string NumIsla = comboBoxIsla.Text;
            string Fecha = txtFecha.Text;
            string Hora = txtHora.Text;
            string Descripcion = txtDescipcion.Text;


            string cade = "insert into ReportIslas (Id, NumIsla, Fecha, Hora, Descripcion) values ('" + Id + "','" + NumIsla + "','" + Fecha + "','" + Hora + "','" + Descripcion + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();
            if ((ComboBoxId.Text == "") || (comboBoxIsla.Text == "") || (txtFecha.Text == "") || (txtHora.Text == "") || (txtDescipcion.Text == ""))
            {
                MessageBox.Show("Error, llena el dato que falta");
            }
            else
            {
                MessageBox.Show("Mensaje enviado correctamente ");
                ComboBoxId.Text = "";
                comboBoxIsla.Text = "";
                txtFecha.Text = "";
                txtHora.Text = "";
                txtDescipcion.Text = "";

            }
        }

        private void ComboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxIsla_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIsla.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

}

