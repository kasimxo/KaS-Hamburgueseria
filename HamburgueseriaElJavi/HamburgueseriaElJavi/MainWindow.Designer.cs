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
            tab_bebidas = new TabPage();
            tab_patatas = new TabPage();
            button1 = new Button();
            carta.SuspendLayout();
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
            carta.Size = new Size(496, 303);
            carta.TabIndex = 0;
            // 
            // tab_hamburguesas
            // 
            tab_hamburguesas.Location = new Point(4, 24);
            tab_hamburguesas.Name = "tab_hamburguesas";
            tab_hamburguesas.Padding = new Padding(3);
            tab_hamburguesas.Size = new Size(488, 275);
            tab_hamburguesas.TabIndex = 0;
            tab_hamburguesas.Text = "Hamburguesas";
            tab_hamburguesas.UseVisualStyleBackColor = true;
            // 
            // tab_bebidas
            // 
            tab_bebidas.Location = new Point(4, 24);
            tab_bebidas.Name = "tab_bebidas";
            tab_bebidas.Padding = new Padding(3);
            tab_bebidas.Size = new Size(488, 275);
            tab_bebidas.TabIndex = 1;
            tab_bebidas.Text = "Bebidas";
            tab_bebidas.UseVisualStyleBackColor = true;
            // 
            // tab_patatas
            // 
            tab_patatas.Location = new Point(4, 24);
            tab_patatas.Name = "tab_patatas";
            tab_patatas.Size = new Size(488, 275);
            tab_patatas.TabIndex = 2;
            tab_patatas.Text = "Patatas";
            tab_patatas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(587, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_ham_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(carta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Haburguesería El Javi";
            Load += MainWindow_Load;
            carta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl carta;
        private TabPage tab_hamburguesas;
        private TabPage tab_bebidas;
        private TabPage tab_patatas;
        private Button button1;
    }
}