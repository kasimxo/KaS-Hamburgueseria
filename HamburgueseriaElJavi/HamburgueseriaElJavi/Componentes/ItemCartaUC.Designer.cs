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
            ingredientesProducto = new Label();
            precioProducto = new Label();
            btn_add = new Button();
            btn_sub = new Button();
            cuantity = new Label();
            SuspendLayout();
            // 
            // nombreProducto
            // 
            nombreProducto.AutoSize = true;
            nombreProducto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nombreProducto.Location = new Point(13, 11);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Size = new Size(72, 30);
            nombreProducto.TabIndex = 0;
            nombreProducto.Text = "label1";
            // 
            // ingredientesProducto
            // 
            ingredientesProducto.Location = new Point(13, 56);
            ingredientesProducto.Name = "ingredientesProducto";
            ingredientesProducto.Size = new Size(188, 67);
            ingredientesProducto.TabIndex = 1;
            ingredientesProducto.Text = "label1";
            // 
            // precioProducto
            // 
            precioProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            precioProducto.AutoSize = true;
            precioProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            precioProducto.Location = new Point(337, 11);
            precioProducto.Name = "precioProducto";
            precioProducto.Size = new Size(63, 25);
            precioProducto.TabIndex = 2;
            precioProducto.Text = "label1";
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Location = new Point(390, 100);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(24, 23);
            btn_add.TabIndex = 3;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_sub
            // 
            btn_sub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_sub.Location = new Point(324, 100);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(24, 23);
            btn_sub.TabIndex = 4;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // cuantity
            // 
            cuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuantity.BackColor = Color.White;
            cuantity.Location = new Point(354, 100);
            cuantity.Name = "cuantity";
            cuantity.Size = new Size(30, 23);
            cuantity.TabIndex = 5;
            cuantity.Text = "0";
            cuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ItemCartaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cuantity);
            Controls.Add(btn_sub);
            Controls.Add(btn_add);
            Controls.Add(precioProducto);
            Controls.Add(ingredientesProducto);
            Controls.Add(nombreProducto);
            Name = "ItemCartaUC";
            Size = new Size(429, 145);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreProducto;
        private Label ingredientesProducto;
        private Label precioProducto;
        private Button btn_add;
        private Button btn_sub;
        private Label cuantity;
    }
}
