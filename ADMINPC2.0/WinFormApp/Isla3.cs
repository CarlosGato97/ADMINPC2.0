using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
