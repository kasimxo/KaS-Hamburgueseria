using MyBurguerLib_Ex2;

namespace HamburgueseriaElJavi {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btn_hamburguesas = new Button();
            menuSuperioruc1 = new MenuSuperiorUC();
            btn_patatas = new Button();
            btn_bebidas = new Button();
            tlp_menu = new TableLayoutPanel();
            tlp_cartaProductos = new TableLayoutPanel();
            btn_ham = new Button();
            btn_bebida = new Button();
            btn_patata = new Button();
            tlp_menu.SuspendLayout();
            SuspendLayout();
            // 
            // btn_hamburguesas
            // 
            btn_hamburguesas.Anchor = AnchorStyles.None;
            btn_hamburguesas.Location = new Point(126, 13);
            btn_hamburguesas.Name = "btn_hamburguesas";
            btn_hamburguesas.Size = new Size(127, 23);
            btn_hamburguesas.TabIndex = 1;
            btn_hamburguesas.Text = "Hamburguesas";
            btn_hamburguesas.UseVisualStyleBackColor = true;
            btn_hamburguesas.Click += btn_hamburguesas_Click;
            // 
            // menuSuperioruc1
            // 
            menuSuperioruc1.Location = new Point(9, 0);
            menuSuperioruc1.Margin = new Padding(0);
            menuSuperioruc1.Name = "menuSuperioruc1";
            menuSuperioruc1.Size = new Size(800, 120);
            menuSuperioruc1.TabIndex = 2;
            // 
            // btn_patatas
            // 
            btn_patatas.Anchor = AnchorStyles.None;
            btn_patatas.Location = new Point(126, 62);
            btn_patatas.Name = "btn_patatas";
            btn_patatas.Size = new Size(127, 23);
            btn_patatas.TabIndex = 3;
            btn_patatas.Text = "Patatas";
            btn_patatas.UseVisualStyleBackColor = true;
            // 
            // btn_bebidas
            // 
            btn_bebidas.Anchor = AnchorStyles.None;
            btn_bebidas.Location = new Point(126, 112);
            btn_bebidas.Name = "btn_bebidas";
            btn_bebidas.Size = new Size(127, 23);
            btn_bebidas.TabIndex = 4;
            btn_bebidas.Text = "Bebidas";
            btn_bebidas.UseVisualStyleBackColor = true;
            // 
            // tlp_menu
            // 
            tlp_menu.ColumnCount = 1;
            tlp_menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_menu.Controls.Add(btn_hamburguesas, 0, 0);
            tlp_menu.Controls.Add(btn_bebidas, 0, 2);
            tlp_menu.Controls.Add(btn_patatas, 0, 1);
            tlp_menu.Location = new Point(36, 148);
            tlp_menu.Name = "tlp_menu";
            tlp_menu.RowCount = 3;
            tlp_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 32.6732674F));
            tlp_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 32.6732674F));
            tlp_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 34.6534653F));
            tlp_menu.Size = new Size(380, 150);
            tlp_menu.TabIndex = 5;
            // 
            // tlp_cartaProductos
            // 
            tlp_cartaProductos.ColumnCount = 1;
            tlp_cartaProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_cartaProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_cartaProductos.Location = new Point(27, 148);
            tlp_cartaProductos.Margin = new Padding(0);
            tlp_cartaProductos.Name = "tlp_cartaProductos";
            tlp_cartaProductos.RowCount = 1;
            tlp_cartaProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_cartaProductos.Size = new Size(728, 282);
            tlp_cartaProductos.TabIndex = 6;
            // 
            // btn_ham
            // 
            btn_ham.Location = new Point(27, 119);
            btn_ham.Name = "btn_ham";
            btn_ham.Size = new Size(104, 23);
            btn_ham.TabIndex = 7;
            btn_ham.Text = "Hamburguesas";
            btn_ham.UseVisualStyleBackColor = true;
            btn_ham.Click += btn_ham_Click;
            // 
            // btn_bebida
            // 
            btn_bebida.Location = new Point(137, 119);
            btn_bebida.Name = "btn_bebida";
            btn_bebida.Size = new Size(75, 23);
            btn_bebida.TabIndex = 8;
            btn_bebida.Text = "Bebida";
            btn_bebida.UseVisualStyleBackColor = true;
            // 
            // btn_patata
            // 
            btn_patata.Location = new Point(218, 119);
            btn_patata.Name = "btn_patata";
            btn_patata.Size = new Size(75, 23);
            btn_patata.TabIndex = 9;
            btn_patata.Text = "Patatas";
            btn_patata.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_patata);
            Controls.Add(btn_bebida);
            Controls.Add(btn_ham);
            Controls.Add(tlp_cartaProductos);
            Controls.Add(tlp_menu);
            Controls.Add(menuSuperioruc1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Haburguesería El Javi";
            tlp_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_hamburguesas;
        private MenuSuperiorUC menuSuperioruc1;
        private Button btn_patatas;
        private Button btn_bebidas;
        public TableLayoutPanel tlp_menu;
        private TableLayoutPanel tlp_cartaProductos;
        private Button btn_ham;
        private Button btn_bebida;
        private Button btn_patata;
    }
}