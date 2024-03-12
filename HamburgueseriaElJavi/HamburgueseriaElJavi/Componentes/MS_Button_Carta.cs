using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaElJavi {
    public partial class MS_Button_Carta : UserControl {
        public MS_Button_Carta() {
            InitializeComponent();
        }

        public void MS_Button_Carta_MouseClick(object sender, MouseEventArgs e) {
            changeState();
        }
    }
}
