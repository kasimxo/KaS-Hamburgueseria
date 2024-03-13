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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btn_acceder_Click(object sender, EventArgs e) {
            if (txt_username.Text.Length < 3 || txt_password.Text.Length < 5) {
                MessageBox.Show("Usuario o contraseña no válidos");
            } else {
                string dir = txt_username.Text;

                if (!Directory.Exists("data\\" + dir)) {
                    MessageBox.Show("Usuario o contraseña no válidos");
                } else {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if (decusr == txt_username.Text && decpss == txt_password.Text) {
                        MessageBox.Show("In");
                    } else {
                        MessageBox.Show("Out");
                    }
                }



                /*
                Directory.CreateDirectory("data\\" + dir);
                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encusr = AesCryp.Encrypt(txt_username.Text);
                string encpss = AesCryp.Encrypt(txt_password.Text);

                sw.WriteLine(encusr);
                sw.WriteLine(encpss);
                sw.Close();
                */
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e) {
            RegForm rf = new RegForm();
            rf.Show();
        }
    }
}
