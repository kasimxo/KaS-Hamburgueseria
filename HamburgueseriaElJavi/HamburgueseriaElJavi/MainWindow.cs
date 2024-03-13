using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MyBurguerLib_Ex2;

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



            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }


        private async void btn_ham_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Carta/");
            if (resp != null)
            {

            }
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

        private async void sincronizarHamburguesas() {
            FirebaseResponse resp = await client.GetTaskAsync("Carta/Hamburguesas/");
            if (resp != null)
            {

            }
        }
        private async void sincronizarBebidas() {
            FirebaseResponse resp = await client.GetTaskAsync("Carta/Bebidas/");
            if (resp != null)
            {

            }
        }
        private async void sincronizarPatatas() {
            FirebaseResponse resp = await client.GetTaskAsync("Carta/Patatas/");
            if (resp != null)
            {
                resp.Body.GetEnumerator().MoveNext();
                IEnumerable<Patatas> ite = resp.Body.Cast<Patatas>();
                foreach(Patatas p in ite) {
                    
                    Console.WriteLine();
                }
            }
        }
    }
}