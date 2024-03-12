using MyBurguerLib_Ex2;

namespace HamburgueseriaElJavi {
    public static class Program {

        //Aqui gestionaremos la lista de productos
        public static List<Producto> productos;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //MainWindow mW = new MainWindow();
            Login mW = new Login();

            Application.Run(mW);

            




        }
    }
}