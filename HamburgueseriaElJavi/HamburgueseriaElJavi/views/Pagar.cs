using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaElJavi.views
{
    public partial class Pagar : Form
    {
        public decimal total;
        public Pagar()
        {
            InitializeComponent();
        }

        public Pagar(string texto, decimal total)
        {

            InitializeComponent();
            ticket.Text = texto;
            this.total = total;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int introducido;
            Boolean success = Int32.TryParse(cantidad_cliente.Text, out introducido);
            if (!success || introducido < total)
            {
                MessageBox.Show("Se ha producido un error. La cantidad introducida debe ser mayor de la cantidad a pagar.");
                return;
            }
            decimal devolverNum = introducido - total;
            devolver.Text = devolverNum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
