﻿using System;
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
    public partial class Isla5 : Form
    {
        public Isla5()
        {
            InitializeComponent();
        }

        private void Isla5_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar5_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source=IVANLOPEZ;Initial Catalog=ADMINPC;User ID=sa;Password=qewebatengo1");
            conex.Open();

            string Id = comboBoxID.Text;
            string NumIsla = comboBox1.Text;
            string Fecha = txtFecha5.Text;
            string Hora = txtHora5.Text;
            string Descripcion = txtDescripcion5.Text;


            string cade = "insert into ReportIslas (Id, NumIsla, Fecha, Hora, Descripcion) values ('" + Id + "','" + NumIsla + "','" + Fecha + "','" + Hora + "','" + Descripcion + "')";
            SqlCommand coman = new SqlCommand(cade, conex);
            coman.ExecuteNonQuery();

            if ((comboBoxID.Text == "") || (comboBox1.Text == "") || (txtFecha5.Text == "") || (txtHora5.Text == "") || (txtDescripcion5.Text == ""))
            {
                MessageBox.Show("Error, llena el dato que falta");
            }
            else
            {
                MessageBox.Show("Mensaje enviado correctamente ");
                comboBoxID.Text = "";
                comboBox1.Text = "";
                txtFecha5.Text = "";
                txtHora5.Text = "";
                txtDescripcion5.Text = "";

            }


            conex.Close();
        }

        private void btnVolver5_Click(object sender, EventArgs e)
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
