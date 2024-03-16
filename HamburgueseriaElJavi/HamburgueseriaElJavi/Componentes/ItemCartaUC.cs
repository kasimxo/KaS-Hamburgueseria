using MyBurguerLib_Ex2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaElJavi.Componentes
{
    public partial class ItemCartaUC : UserControl
    {

        public Producto producto;
        public int cantidad;

        public ItemCartaUC()
        {
            InitializeComponent();
        }

        public ItemCartaUC(Producto p)
        {
            InitializeComponent();
            producto = p;
            cantidad = 0;
        }

        public void actualizarCantidad(int num)
        {
            cantidad = num;
            Program.mW.actualizarTicket();
        }

        public void nombre(string nombre)
        {
            nombreProducto.Text = nombre;
        }

        public void ingredientes(string ingredientes)
        {
            ingredientesProducto.Text = ingredientes;
        }

        public void precio(string precio)
        {
            precioProducto.Text = precio;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int num;
            Int32.TryParse(cuantity.Text, out num);
            num++;
            cuantity.Text = num.ToString();
            actualizarCantidad(num);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int num;
            Int32.TryParse(cuantity.Text, out num);
            if (num > 0) { num--; }
            cuantity.Text = num.ToString();
            actualizarCantidad(num);
        }
    }
}
