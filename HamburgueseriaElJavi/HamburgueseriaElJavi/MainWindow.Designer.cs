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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            carta = new TabControl();
            tab_hamburguesas = new TabPage();
            table_hamburguesas = new TableLayoutPanel();
            tab_bebidas = new TabPage();
            table_bebidas = new TableLayoutPanel();
            tab_patatas = new TabPage();
            table_patatas = new TableLayoutPanel();
            btn_pagar = new Button();
            tiket = new Label();
            carta.SuspendLayout();
            tab_hamburguesas.SuspendLayout();
            tab_bebidas.SuspendLayout();
            tab_patatas.SuspendLayout();
            SuspendLayout();
            // 
            // carta
            // 
            carta.Controls.Add(tab_hamburguesas);
            carta.Controls.Add(tab_bebidas);
            carta.Controls.Add(tab_patatas);
            carta.Location = new Point(12, 12);
            carta.Name = "carta";
            carta.SelectedIndex = 0;
            carta.Size = new Size(496, 426);
            carta.TabIndex = 0;
            // 
            // tab_hamburguesas
            // 
            tab_hamburguesas.Controls.Add(table_hamburguesas);
            tab_hamburguesas.Location = new Point(4, 24);
            tab_hamburguesas.Name = "tab_hamburguesas";
            tab_hamburguesas.Padding = new Padding(3);
            tab_hamburguesas.Size = new Size(488, 398);
            tab_hamburguesas.TabIndex = 0;
            tab_hamburguesas.Text = "Hamburguesas";
            tab_hamburguesas.UseVisualStyleBackColor = true;
            // 
            // table_hamburguesas
            // 
            table_hamburguesas.AutoScroll = true;
            table_hamburguesas.ColumnCount = 1;
            table_hamburguesas.ColumnStyles.Add(new ColumnStyle());
            table_hamburguesas.Location = new Point(6, 6);
            table_hamburguesas.Name = "table_hamburguesas";
            table_hamburguesas.RowCount = 1;
            table_hamburguesas.RowStyles.Add(new RowStyle());
            table_hamburguesas.Size = new Size(479, 386);
            table_hamburguesas.TabIndex = 0;
            // 
            // tab_bebidas
            // 
            tab_bebidas.Controls.Add(table_bebidas);
            tab_bebidas.Location = new Point(4, 24);
            tab_bebidas.Name = "tab_bebidas";
            tab_bebidas.Padding = new Padding(3);
            tab_bebidas.Size = new Size(488, 398);
            tab_bebidas.TabIndex = 1;
            tab_bebidas.Text = "Bebidas";
            tab_bebidas.UseVisualStyleBackColor = true;
            // 
            // table_bebidas
            // 
            table_bebidas.AutoScroll = true;
            table_bebidas.ColumnCount = 1;
            table_bebidas.ColumnStyles.Add(new ColumnStyle());
            table_bebidas.Location = new Point(6, 3);
            table_bebidas.Name = "table_bebidas";
            table_bebidas.RowCount = 1;
            table_bebidas.RowStyles.Add(new RowStyle());
            table_bebidas.Size = new Size(479, 389);
            table_bebidas.TabIndex = 0;
            // 
            // tab_patatas
            // 
            tab_patatas.Controls.Add(table_patatas);
            tab_patatas.Location = new Point(4, 24);
            tab_patatas.Name = "tab_patatas";
            tab_patatas.Size = new Size(488, 398);
            tab_patatas.TabIndex = 2;
            tab_patatas.Text = "Patatas";
            tab_patatas.UseVisualStyleBackColor = true;
            // 
            // table_patatas
            // 
            table_patatas.AutoScroll = true;
            table_patatas.ColumnCount = 1;
            table_patatas.ColumnStyles.Add(new ColumnStyle());
            table_patatas.Location = new Point(3, 3);
            table_patatas.Name = "table_patatas";
            table_patatas.RowCount = 1;
            table_patatas.RowStyles.Add(new RowStyle());
            table_patatas.Size = new Size(482, 392);
            table_patatas.TabIndex = 0;
            // 
            // btn_pagar
            // 
            btn_pagar.Location = new Point(713, 415);
            btn_pagar.Name = "btn_pagar";
            btn_pagar.Size = new Size(75, 23);
            btn_pagar.TabIndex = 1;
            btn_pagar.Text = "Pagar";
            btn_pagar.UseVisualStyleBackColor = true;
            btn_pagar.Click += this.btn_pagarFunc;
            // 
            // tiket
            // 
            tiket.Location = new Point(531, 36);
            tiket.Name = "tiket";
            tiket.Size = new Size(257, 376);
            tiket.TabIndex = 2;
            tiket.Text = "Ticket";
            tiket.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tiket);
            Controls.Add(btn_pagar);
            Controls.Add(carta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Haburguesería El Javi";
            Load += MainWindow_Load;
            carta.ResumeLayout(false);
            tab_hamburguesas.ResumeLayout(false);
            tab_bebidas.ResumeLayout(false);
            tab_patatas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl carta;
        private TabPage tab_hamburguesas;
        private TabPage tab_bebidas;
        private TabPage tab_patatas;
        private Button btn_pagar;
        private TableLayoutPanel table_hamburguesas;
        private TableLayoutPanel table_bebidas;
        private TableLayoutPanel table_patatas;
        private Label tiket;
    }
}