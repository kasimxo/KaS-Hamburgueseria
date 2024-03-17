using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using HamburgueseriaElJavi.Model;
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

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5GAMRW5jQmVVpVMpA9AwfsRtKW3co9i64eqrnzO7",
            BasePath = "https://burguerjavi-a9427-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;
        public Pagar()
        {
            InitializeComponent();
        }

        public Pagar(string texto, decimal total)
        {

            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
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
            devolver.Text = devolverNum.ToString() + " €";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Acción de aceptar el pago. 
        /// Se guarda el pedido en la base de datos, también se exporta como archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
            //Sacamos el número de ticket maximo
            FirebaseResponse respNum = await client.GetTaskAsync("Tickets/contador");
            if (respNum != null && respNum.Body != "null")
            {

                CntFB num = respNum.ResultAs<CntFB>();
                num.Cnt++;
                //Añadimos el ticket con la notación siguiente
                client.Set("Tickets/T" + num.Cnt, ticket.Text);
                client.Update("Tickets/contador", num);
            }
            else {
                //Si no ha encontrado un contador, iniciamos en 1
                CntFB num = new CntFB();
                num.Cnt = 1;
                client.Set("Tickets/contador/", num);
                client.Set("Tickets/T1", ticket.Text);
            }

            //Le decimos al usuario que seleccione un directorio para guardar el ticket
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            string filename = "Ticket" + DateTime.Now.ToShortDateString().ToString().Replace('/','_') + ".txt";
            File.Create(path +"\\"+ filename ).Close();
            File.WriteAllText(path + "\\" + filename, ticket.Text);

            Program.mW.reset();
            this.Close();
        }
    }
}
