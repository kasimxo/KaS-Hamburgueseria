using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using HamburgueseriaElJavi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HamburgueseriaElJavi.views
{
    public partial class Historial : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5GAMRW5jQmVVpVMpA9AwfsRtKW3co9i64eqrnzO7",
            BasePath = "https://burguerjavi-a9427-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;
        public Historial()
        {

            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();

            cargarHistorialPedidos();
        }

        public async void cargarHistorialPedidos()
        {
            FirebaseResponse respNum = await client.GetTaskAsync("Tickets/contador");
            if (respNum != null)
            {
                CntFB num = respNum.ResultAs<CntFB>(); //Numero de hamburguesas en la base de datos
                for (int i = 1; i <= num.Cnt; i++)
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Tickets/T" + i);
                    if (resp != null)
                    {
                        string ticket = resp.Body.ToString();
                        string json = JsonConvert.ToString(resp.Body);
                        ticket = ticket.Replace(@"\n", "\n");
                        ticket = ticket.Replace("\"", "");
                        Label lab = new Label();
                        lab.AutoSize = true;
                        lab.TextAlign = ContentAlignment.MiddleCenter;
                        lab.BackColor = Color.ForestGreen;
                        lab.Margin = new Padding(3);
                        lab.Padding = new Padding(3);
                        lab.Text = ticket;
                        lab.Anchor = AnchorStyles.None;
                        panel.Controls.Add(lab, 1, panel.RowCount - 1);
                        panel.RowCount++;

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
