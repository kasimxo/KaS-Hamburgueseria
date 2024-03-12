namespace HamburgueseriaElJavi {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lvl_username = new Label();
            lvl_password = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_limpiar = new Button();
            btn_registrar = new Button();
            btn_acceder = new Button();
            SuspendLayout();
            // 
            // lvl_username
            // 
            lvl_username.AutoSize = true;
            lvl_username.Location = new Point(12, 20);
            lvl_username.Name = "lvl_username";
            lvl_username.Size = new Size(109, 15);
            lvl_username.TabIndex = 0;
            lvl_username.Text = "Nombre de usuario";
            // 
            // lvl_password
            // 
            lvl_password.AutoSize = true;
            lvl_password.Location = new Point(12, 71);
            lvl_password.Name = "lvl_password";
            lvl_password.Size = new Size(67, 15);
            lvl_password.TabIndex = 1;
            lvl_password.Text = "Contraseña";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(127, 12);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(127, 68);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(14, 127);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 4;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += button1_Click;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(95, 127);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(75, 23);
            btn_registrar.TabIndex = 5;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_acceder
            // 
            btn_acceder.Location = new Point(176, 127);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(75, 23);
            btn_acceder.TabIndex = 6;
            btn_acceder.Text = "Acceder";
            btn_acceder.UseVisualStyleBackColor = true;
            btn_acceder.Click += btn_acceder_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 162);
            Controls.Add(btn_acceder);
            Controls.Add(btn_registrar);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lvl_password);
            Controls.Add(lvl_username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lvl_username;
        private Label lvl_password;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_limpiar;
        private Button btn_registrar;
        private Button btn_acceder;
    }
}