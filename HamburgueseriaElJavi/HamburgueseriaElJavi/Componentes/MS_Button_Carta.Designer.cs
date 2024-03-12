namespace HamburgueseriaElJavi {
    partial class MS_Button_Carta {

        public Boolean Activ = false;

        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 1;
            label1.Text = "Carta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseClick += MS_Button_Carta_MouseClick;
            // 
            // MS_Button_Carta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "MS_Button_Carta";
            Size = new Size(80, 100);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;

        public void changeState() {
            if (Activ) {
                Activ = false;
                label1.Text = "Carta";
            } else {
                Activ = true;
                label1.Text = "Prueba";

            }
        }
    }
}
