using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1, v2, res;
            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);
            res = v1 + v2;
            txtResultado.Text = res.ToString();
        }
    }
}
