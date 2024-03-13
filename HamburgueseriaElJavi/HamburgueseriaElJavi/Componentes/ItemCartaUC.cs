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
        public ItemCartaUC()
        {
            InitializeComponent();
        }

        public void nombre(string nombre)
        {
            nombreProducto.Text = nombre;
        }
    }
}
