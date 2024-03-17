namespace HamburgueseriaElJavi.views
{
    partial class Pagar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ticket = new Label();
            label3 = new Label();
            label2 = new Label();
            cantidad_cliente = new TextBox();
            devolver = new Label();
            btn_calcular = new Button();
            button1 = new Button();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // ticket
            // 
            ticket.AutoSize = true;
            ticket.Location = new Point(47, 18);
            ticket.Name = "ticket";
            ticket.Size = new Size(38, 15);
            ticket.TabIndex = 0;
            ticket.Text = "label1";
            ticket.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 56);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 1;
            label3.Text = "Cantidad pagada:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 123);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad a devolver:";
            // 
            // cantidad_cliente
            // 
            cantidad_cliente.Location = new Point(389, 53);
            cantidad_cliente.Name = "cantidad_cliente";
            cantidad_cliente.Size = new Size(70, 23);
            cantidad_cliente.TabIndex = 3;
            // 
            // devolver
            // 
            devolver.AutoSize = true;
            devolver.Location = new Point(389, 123);
            devolver.Name = "devolver";
            devolver.Size = new Size(22, 15);
            devolver.TabIndex = 4;
            devolver.Text = "0 €";
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(474, 53);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(75, 23);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(480, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_calcular);
            Controls.Add(devolver);
            Controls.Add(cantidad_cliente);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(ticket);
            Name = "Pagar";
            Text = "Pagar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ticket;
        private Label label3;
        private Label label2;
        private TextBox cantidad_cliente;
        private Label devolver;
        private Button btn_calcular;
        private Button button1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}