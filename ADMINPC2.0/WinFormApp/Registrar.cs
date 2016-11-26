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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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
