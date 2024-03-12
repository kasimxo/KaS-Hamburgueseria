using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace HamburgueseriaElJavi {
    public partial class MainWindow : Form {

        IFirebaseConfig config = new FirebaseConfig {
            AuthSecret = "FULF5ElQLr8EBX2hu2EAtqSpI85i5jxPpb1lvQnY",
            BasePath = "https://pruebadesarrollointerfaces-default-rtdb.europe-west1.firebasedatabase.app/"


        };

        IFirebaseClient client;

        public MainWindow() {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void btn_hamburguesas_Click(object sender, EventArgs e) {
            tlp_menu.Visible = false;
        }

        private async void btn_ham_Click(object sender, EventArgs e) {
            FirebaseResponse resp = await client.GetTaskAsync("Carta/Hamburguesas/");
            if (resp != null) {
                
            }
        }
    }
}