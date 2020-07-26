using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtValor.Text);
            double iva = 0;
            double total = 0;

            iva = numero1 * 0.19;
            lblIva.Text = Convert.ToString(iva); 

            total = numero1 + iva;

            lblTotal.Text = Convert.ToString(total); 

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Text = String.Empty;
            lblIva.Text = "0";
            lblTotal.Text = "0";
            txtValor.Focus(); 
        }
    }
}
