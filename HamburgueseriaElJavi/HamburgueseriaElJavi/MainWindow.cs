using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using HamburgueseriaElJavi.Componentes;
using HamburgueseriaElJavi.Model;
using MyBurguerLib_Ex2;
using System.Windows.Forms;

namespace HamburgueseriaElJavi {
    public partial class MainWindow : Form
    {
        //Estas listas guardan todos los tipos de proucto, a modo de carta
        public List<Hamburguesa> hamburguesas;
        public List<Bebida> bebidas;
        public List<Patatas> patatas;


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5GAMRW5jQmVVpVMpA9AwfsRtKW3co9i64eqrnzO7",
            BasePath = "https://burguerjavi-a9427-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;

        public MainWindow()
        {

            hamburguesas = new List<Hamburguesa>();
            bebidas = new List<Bebida>();
            patatas = new List<Patatas>();

            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();

            //cargarContenido();
        }


        private async void btn_ham_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine();
        }

        /// <summary>
        /// Cuando carga el form principal, se descargan los datos de la carta de la base de datos de firebase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            sincronizarHamburguesas();
            sincronizarBebidas();
            sincronizarPatatas();
            
        }

        private void cargarHamburguesas()
        {
            foreach(Hamburguesa h in hamburguesas)
            {
                ItemCartaUC item = new ItemCartaUC();
                item.nombre(h.nombreProducto);
                item.Size = new System.Drawing.Size(table_hamburguesas.Size.Width-25, item.Size.Height); //Ajustamos el ancho del user controll al ancho de la tabla
                table_hamburguesas.Controls.Add(item, 1, table_hamburguesas.RowCount - 1);
                table_hamburguesas.RowCount++;
            }
            table_hamburguesas.RowCount--;
        }

        private void cargarBebidas()
        {
            foreach (Bebida b in bebidas)
            {
                ItemCartaUC item = new ItemCartaUC();
                item.nombre(b.nombreProducto);
                item.Size = new System.Drawing.Size(table_bebidas.Size.Width - 25, item.Size.Height); //Ajustamos el ancho del user controll al ancho de la tabla
                table_bebidas.Controls.Add(item, 1, table_bebidas.RowCount - 1);
                table_bebidas.RowCount++;
            }
            table_bebidas.RowCount--;
        }

        private void cargarPatatas()
        {
            foreach (Patatas p in patatas)
            {
                ItemCartaUC item = new ItemCartaUC();
                item.nombre(p.nombreProducto);
                item.Size = new System.Drawing.Size(table_patatas.Size.Width - 25, item.Size.Height); //Ajustamos el ancho del user controll al ancho de la tabla
                table_patatas.Controls.Add(item, 1, table_patatas.RowCount - 1);
                table_patatas.RowCount++;
            }
            table_patatas.RowCount--;
        }

        private async void sincronizarHamburguesas() {
            FirebaseResponse respNum = await client.GetTaskAsync("Carta/Hamburguesas/contador");
            if (respNum != null)
            {
                CntFB num = respNum.ResultAs<CntFB>(); //Numero de hamburguesas en la base de datos
                for(int i = 1; i <= num.Cnt; i++)
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Carta/Hamburguesas/H"+i);
                    if (resp != null)
                    {
                        HamburguesaFB ham = resp.ResultAs<HamburguesaFB>();
                        hamburguesas.Add(ham.toHamburguesa());
                    }
                }
            }
            cargarHamburguesas();
        }
        private async void sincronizarBebidas() {
            FirebaseResponse respNum = await client.GetTaskAsync("Carta/Bebidas/contador");
            if (respNum != null)
            {
                CntFB num = respNum.ResultAs<CntFB>(); //Numero de bebidas en la base de datos
                for (int i = 1; i <= num.Cnt; i++)
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Carta/Bebidas/B" + i);
                    if (resp != null)
                    {
                        BebidasFB ham = resp.ResultAs<BebidasFB>();
                        bebidas.Add(ham.toBebida());
                    }
                }
            }
            cargarBebidas();
        }
        private async void sincronizarPatatas() {
            FirebaseResponse respNum = await client.GetTaskAsync("Carta/Patatas/contador");
            if (respNum != null)
            {
                CntFB num = respNum.ResultAs<CntFB>(); //Numero de patatas en la base de datos
                for (int i = 1; i <= num.Cnt; i++)
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Carta/Patatas/P" + i);
                    if (resp != null)
                    {
                        PatatasFB ham = resp.ResultAs<PatatasFB>();
                        patatas.Add(ham.toPatatas());
                    }
                }
            }
            cargarPatatas();
        }

        private async void images()
        {

            //Habría que meter en las clases un string de img
            //Eso seria la imagen del producto en base 64
            //Al crear el producto, se podría seleccionar la imagen del equipo y se meteria a firebase

            MemoryStream ms = new MemoryStream();
            //Image.Save(ms, ImageFormat.Png);

            byte[] arr = ms.GetBuffer();
            string output = Convert.ToBase64String(arr);
            /*
            var data = new Image_model
            {
                Img = output
            };

            SetResponse response = await client.SetTaskAsync();
            Image_model result = response.ResultAs<Image_model>();
            pBox.Image = null;
            */
        }
    }
}