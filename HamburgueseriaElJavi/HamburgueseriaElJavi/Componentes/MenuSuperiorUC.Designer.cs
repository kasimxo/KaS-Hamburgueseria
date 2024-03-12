namespace HamburgueseriaElJavi {
    partial class MenuSuperiorUC {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSuperiorUC));
            MS_tl = new TableLayoutPanel();
            MS_logo = new PictureBox();
            mS_Button_Carta1 = new MS_Button_Carta();
            MS_tl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MS_logo).BeginInit();
            SuspendLayout();
            // 
            // MS_tl
            // 
            MS_tl.ColumnCount = 3;
            MS_tl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MS_tl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MS_tl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MS_tl.Controls.Add(MS_logo, 0, 0);
            MS_tl.Controls.Add(mS_Button_Carta1, 1, 0);
            MS_tl.Location = new Point(0, 0);
            MS_tl.Margin = new Padding(0);
            MS_tl.Name = "MS_tl";
            MS_tl.RowCount = 1;
            MS_tl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MS_tl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MS_tl.Size = new Size(800, 120);
            MS_tl.TabIndex = 1;
            // 
            // MS_logo
            // 
            MS_logo.Image = (Image)resources.GetObject("MS_logo.Image");
            MS_logo.Location = new Point(25, 25);
            MS_logo.Margin = new Padding(25);
            MS_logo.Name = "MS_logo";
            MS_logo.Size = new Size(120, 70);
            MS_logo.TabIndex = 1;
            MS_logo.TabStop = false;
            // 
            // mS_Button_Carta1
            // 
            mS_Button_Carta1.Anchor = AnchorStyles.None;
            mS_Button_Carta1.Location = new Point(545, 10);
            mS_Button_Carta1.Margin = new Padding(0);
            mS_Button_Carta1.Name = "mS_Button_Carta1";
            mS_Button_Carta1.Size = new Size(80, 100);
            mS_Button_Carta1.TabIndex = 2;
            mS_Button_Carta1.MouseClick += mS_Button_Carta1_MouseClick;
            mS_Button_Carta1.MouseEnter += mS_Button_Carta1_MouseEnter;
            mS_Button_Carta1.MouseLeave += mS_Button_Carta1_MouseLeave;
            // 
            // MenuSuperiorUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MS_tl);
            Margin = new Padding(0);
            Name = "MenuSuperiorUC";
            Size = new Size(800, 120);
            MS_tl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MS_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel MS_tl;
        private PictureBox MS_logo;

        private MS_Button_Carta mS_Button_Carta1;
    }
}
