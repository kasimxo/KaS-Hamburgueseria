using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueseriaElJavi.DBHandler {
    public class FirebaseHandler {
        IFirebaseConfig config = new FirebaseConfig {
            AuthSecret = "FULF5ElQLr8EBX2hu2EAtqSpI85i5jxPpb1lvQnY",
            BasePath = "https://pruebadesarrollointerfaces-default-rtdb.europe-west1.firebasedatabase.app/"


        };

        IFirebaseClient client;


        public void  creacion() {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
