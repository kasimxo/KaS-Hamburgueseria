using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using HamburgueseriaElJavi.Componentes;
using HamburgueseriaElJavi.Model;
using HamburgueseriaElJavi.views;
using MyBurguerLib_Ex2;
using System;
using System.Data;
using System.Windows.Forms;

namespace HamburgueseriaElJavi {
    public partial class MainWindow : Form
    {
        //Estas listas guardan todos los tipos de proucto, a modo de carta
        public List<Hamburguesa> hamburguesas;
        public List<Bebida> bebidas;
        public List<Patatas> patatas;
        public List<FavoritoFB> listado_favoritos;

        public decimal total;

        public Dictionary<string, ItemCartaUC> cartas;
        public Dictionary<Producto, int> productos;


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5GAMRW5jQmVVpVMpA9AwfsRtKW3co9i64eqrnzO7",
            BasePath = "https://burguerjavi-a9427-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;

        public MainWindow()
        {
            listado_favoritos = new List<FavoritoFB>();
            hamburguesas = new List<Hamburguesa>();
            bebidas = new List<Bebida>();
            patatas = new List<Patatas>();
            cartas = new Dictionary<string, ItemCartaUC>();

            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
            total = 0;

            productos = new Dictionary<Producto, int>();

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
            cargarFavoritos();
        }

        /// <summary>
        /// Actualiza toda la información del ticket
        /// </summary>
        public void actualizarTicket()
        {
            string texto = "Ticket\n\n";
            int filasHamburguesas = table_hamburguesas.RowCount;
            total = 0;
            for (int i = 0; i < filasHamburguesas; i++)
            {
                ItemCartaUC icUC = (ItemCartaUC)table_hamburguesas.GetControlFromPosition(0, i);

                if (icUC.cantidad > 0)
                {
                    decimal precio = Math.Round((decimal)(icUC.cantidad * icUC.producto.precio), 2);
                    total += precio;
                    texto += icUC.producto.NombreProducto + "    x " + icUC.cantidad + "    " + precio + " €\n";
                }

            }
            int filasBebidas = table_bebidas.RowCount;
            for (int i = 0; i < filasBebidas; i++)
            {
                ItemCartaUC icUC = (ItemCartaUC)table_bebidas.GetControlFromPosition(0, i);
                if (icUC.cantidad > 0)
                {
                    decimal precio = Math.Round((decimal)(icUC.cantidad * icUC.producto.precio), 2);
                    total += precio;
                    texto += icUC.producto.NombreProducto + "    x " + icUC.cantidad + "    " + precio + " €\n";
                }

            }
            int filasPatatas = table_patatas.RowCount;
            for (int i = 0; i < filasPatatas; i++)
            {
                ItemCartaUC icUC = (ItemCartaUC)table_patatas.GetControlFromPosition(0, i);
                if (icUC.cantidad > 0)
                {
                    decimal precio = Math.Round((decimal)(icUC.cantidad * icUC.producto.precio), 2);
                    total += precio;
                    texto += icUC.producto.NombreProducto + "    x " + icUC.cantidad + "    " + precio + " €\n";
                }

            }
            texto += "\nTOTAL A PAGAR: " + total + " €";

            tiket.Text = texto;
        }

        private void cargarHamburguesas()
        {
            foreach (Hamburguesa h in hamburguesas)
            {
                ItemCartaUC item = new ItemCartaUC(h);
                item.nombre(h.nombreProducto);
                item.ingredientes(h.ListarIngredientes());
                item.precio(h.precio.ToString() + " €");
                item.Size = new System.Drawing.Size(table_hamburguesas.Size.Width - 25, item.Size.Height); //Ajustamos el ancho del user controll al ancho de la tabla
                table_hamburguesas.Controls.Add(item, 1, table_hamburguesas.RowCount - 1);
                table_hamburguesas.RowCount++;
                cartas.Add(h.nombreProducto, item);
            }
            table_hamburguesas.RowCount--;
        }

        private void cargarBebidas()
        {
            foreach (Bebida b in bebidas)
            {
                ItemCartaUC item = new ItemCartaUC(b);
                item.nombre(b.nombreProducto);
                string ingredientesH = "Ingredientes: " + b.ListarIngredientes();
                item.ingredientes(ingredientesH);
                item.precio(b.precio.ToString() + " €");
                item.Size = new System.Drawing.Size(table_bebidas.Size.Width - 25, item.Size.Height); //Ajustamos el ancho del user controll al ancho de la tabla
                table_bebidas.Controls.Add(item, 1, table_bebidas.RowCount - 1);
                table_bebidas.RowCount++;
                cartas.Add(b.nombreProducto, item);
            }
            table_bebidas.RowCount--;
        }

        private void cargarPatatas()
        {
            foreach (Patatas p in patatas)
            {
                ItemCartaUC item = new ItemCartaUC(p);
                item.nombre(p.nombreProducto);
                string ingredientesH = "Ingredientes: ";
                ingredientesH += p.ListarIngredientes();
                item.ingredientes(ingredientesH);
                item.precio(p.precio.ToString() + " €");
                item.Size = new System.Drawing.Size(table_patatas.Size.Width - 25, item.Size.Height); //Ajustamos el ancho del user controll al ancho de la tabla
                table_patatas.Controls.Add(item, 1, table_patatas.RowCount - 1);
                table_patatas.RowCount++;
                cartas.Add(p.nombreProducto, item);
            }
            table_patatas.RowCount--;
        }

        private async void sincronizarHamburguesas()
        {
            FirebaseResponse respNum = await client.GetTaskAsync("Carta/Hamburguesas/contador");
            if (respNum != null)
            {
                CntFB num = respNum.ResultAs<CntFB>(); //Numero de hamburguesas en la base de datos
                for (int i = 1; i <= num.Cnt; i++)
                {
                    FirebaseResponse resp = await client.GetTaskAsync("Carta/Hamburguesas/H" + i);
                    if (resp != null)
                    {
                        HamburguesaFB ham = resp.ResultAs<HamburguesaFB>();
                        hamburguesas.Add(ham.toHamburguesa());
                    }
                }
            }
            cargarHamburguesas();
        }
        private async void sincronizarBebidas()
        {
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
        private async void sincronizarPatatas()
        {
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

        public void reset()
        {
            tiket.Text = "Ticket\n\n";
            total = 0;
            productos.Clear();
            int filasHamburguesas = table_hamburguesas.RowCount;
            for (int i = 0; i < filasHamburguesas; i++)
            {
                ItemCartaUC icUC = (ItemCartaUC)table_hamburguesas.GetControlFromPosition(0, i);
                icUC.cantidad = 0;
                icUC.resetCantidad();

            }
            int filasBebidas = table_bebidas.RowCount;
            for (int i = 0; i < filasBebidas; i++)
            {
                ItemCartaUC icUC = (ItemCartaUC)table_bebidas.GetControlFromPosition(0, i);
                icUC.cantidad = 0;
                icUC.resetCantidad();

            }
            int filasPatatas = table_patatas.RowCount;
            for (int i = 0; i < filasPatatas; i++)
            {
                ItemCartaUC icUC = (ItemCartaUC)table_patatas.GetControlFromPosition(0, i);
                icUC.cantidad = 0;
                icUC.resetCantidad();

            }
            cb_favoritos.Items.Clear();
            cargarFavoritos();
        }

        private void vaciarTablas()
        {
            table_bebidas.Controls.Clear();
            table_hamburguesas.Controls.Clear();
            table_patatas.Controls.Clear();
        }

        private void btn_pagarFunc(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                return;
            }
            Pagar pagar = new Pagar(tiket.Text, total, productos);
            pagar.Show();
        }

        public async void cargarFavoritos()
        {
            FirebaseResponse respNum = await client.GetTaskAsync("Tickets/favoritos/contador");
            if (respNum != null)
            {

                CntFB num = respNum.ResultAs<CntFB>();
                for (int i = 1; i <= num.Cnt; i++)
                {

                    FirebaseResponse resp = await client.GetTaskAsync("Tickets/favoritos/T" + i);
                    if (resp != null)
                    {
                        try
                        {
                            FavoritoFB ffb = resp.ResultAs<FavoritoFB>();
                            cb_favoritos.Items.Add(ffb.name);
                            listado_favoritos.Add(ffb);
                        }
                        catch (Exception ex)
                        { }
                    }

                }

            }
        }

        private void cb_favoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cb_favoritos.Text;
            foreach(FavoritoFB ffb in listado_favoritos)
            {
                if (ffb.name.Equals(selected))
                {
                    cargarPedidoFavorito(ffb.productos);
                }
            }
        }

        private void cargarPedidoFavorito(string listado)
        {
            string[] productosSeparados = listado.Remove(listado.Length-1).Split(";");

            foreach (string ps in productosSeparados)
            {
                string[] detalle = ps.Split(":");

                cartas[detalle[0]].actualizarCantidad(Int32.Parse(detalle[1]));

            }
        }
    }
}