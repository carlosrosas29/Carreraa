using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            Liebre m = new Liebre();
            txtMuestra.Text += Convert.ToString(m.Avanzar()) + Environment.NewLine;  
        }
    }
}
