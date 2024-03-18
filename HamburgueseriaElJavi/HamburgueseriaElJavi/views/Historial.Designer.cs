namespace HamburgueseriaElJavi.views
{
    partial class Historial
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
            panel = new TableLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.ColumnCount = 1;
            panel.ColumnStyles.Add(new ColumnStyle());
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Padding = new Padding(1);
            panel.RowCount = 1;
            panel.RowStyles.Add(new RowStyle());
            panel.Size = new Size(432, 392);
            panel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 410);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 444);
            Controls.Add(button1);
            Controls.Add(panel);
            Name = "Historial";
            Text = "Historial";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panel;
        private Button button1;
    }
}