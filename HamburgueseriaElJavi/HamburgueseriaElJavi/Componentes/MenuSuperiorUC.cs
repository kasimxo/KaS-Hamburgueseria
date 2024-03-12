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
    public partial class MenuSuperiorUC : UserControl {
        public MenuSuperiorUC() {
            InitializeComponent();
        }

        private void mS_Button_Carta1_MouseClick(object sender, MouseEventArgs e) {
            mS_Button_Carta1.MS_Button_Carta_MouseClick(sender, e);
        }

        private void mS_Button_Carta1_MouseHover(object sender, EventArgs e) {

        }

        private void mS_Button_Carta1_MouseEnter(object sender, EventArgs e) {
            mS_Button_Carta1.BackColor = Color.Red;
        }

        private void mS_Button_Carta1_MouseLeave(object sender, EventArgs e) {
            mS_Button_Carta1.BackColor = Color.White;
        }
    }
}
