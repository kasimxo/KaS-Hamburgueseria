namespace HamburgueseriaElJavi.Componentes
{
    partial class ItemCartaUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombreProducto = new Label();
            SuspendLayout();
            // 
            // nombreProducto
            // 
            nombreProducto.AutoSize = true;
            nombreProducto.Location = new Point(63, 0);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Size = new Size(38, 15);
            nombreProducto.TabIndex = 0;
            nombreProducto.Text = "label1";
            // 
            // ItemCartaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(nombreProducto);
            Name = "ItemCartaUC";
            Size = new Size(356, 73);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreProducto;
    }
}
