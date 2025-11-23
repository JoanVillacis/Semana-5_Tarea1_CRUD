namespace _02_CRUD.Vistas.Usuarios
{
    partial class frm_edita_usuario
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
            label7 = new Label();
            txt_Cedula = new TextBox();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            label5 = new Label();
            txt_Contrasenia = new TextBox();
            label4 = new Label();
            txt_Correo = new TextBox();
            label3 = new Label();
            txt_Apellidos = new TextBox();
            label2 = new Label();
            chb_Estado = new CheckBox();
            txt_Nombres = new TextBox();
            label1 = new Label();
            cmb_Rol = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(3, 4, 94);
            label7.Location = new Point(178, 256);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 32);
            label7.TabIndex = 32;
            label7.Text = "Cedula";
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(172, 304);
            txt_Cedula.Margin = new Padding(5);
            txt_Cedula.MaxLength = 10;
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.ReadOnly = true;
            txt_Cedula.Size = new Size(257, 39);
            txt_Cedula.TabIndex = 21;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 119, 182);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(17, 364);
            btn_Salir.Margin = new Padding(5);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(124, 49);
            btn_Salir.TabIndex = 9;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(0, 180, 216);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(17, 287);
            btn_Cancelar.Margin = new Padding(5);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(124, 49);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(0, 119, 182);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(17, 212);
            btn_Guardar.Margin = new Padding(5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(124, 49);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(3, 4, 94);
            label5.Location = new Point(176, 467);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 32);
            label5.TabIndex = 31;
            label5.Text = "Contraseña";
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.Location = new Point(170, 515);
            txt_Contrasenia.Margin = new Padding(5);
            txt_Contrasenia.MaxLength = 50;
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.Size = new Size(257, 39);
            txt_Contrasenia.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(3, 4, 94);
            label4.Location = new Point(176, 357);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 29;
            label4.Text = "Correo";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(170, 405);
            txt_Correo.Margin = new Padding(5);
            txt_Correo.MaxLength = 50;
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(257, 39);
            txt_Correo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 4, 94);
            label3.Location = new Point(176, 164);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 25;
            label3.Text = "Apellidos";
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(170, 212);
            txt_Apellidos.Margin = new Padding(5);
            txt_Apellidos.MaxLength = 50;
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(257, 39);
            txt_Apellidos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 4, 94);
            label2.Location = new Point(176, 56);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 23;
            label2.Text = "Nombres";
            // 
            // chb_Estado
            // 
            chb_Estado.AutoSize = true;
            chb_Estado.ForeColor = Color.FromArgb(3, 4, 94);
            chb_Estado.Location = new Point(156, 653);
            chb_Estado.Margin = new Padding(5);
            chb_Estado.Name = "chb_Estado";
            chb_Estado.Size = new Size(106, 36);
            chb_Estado.TabIndex = 6;
            chb_Estado.Text = "Estado";
            chb_Estado.UseVisualStyleBackColor = true;
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(170, 104);
            txt_Nombres.Margin = new Padding(5);
            txt_Nombres.MaxLength = 50;
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(257, 39);
            txt_Nombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(137, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 18;
            label1.Text = "EDITAR USUARIO";
            // 
            // cmb_Rol
            // 
            cmb_Rol.FormattingEnabled = true;
            cmb_Rol.Location = new Point(170, 605);
            cmb_Rol.Name = "cmb_Rol";
            cmb_Rol.Size = new Size(257, 39);
            cmb_Rol.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(3, 4, 94);
            label6.Location = new Point(186, 561);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 32);
            label6.TabIndex = 33;
            label6.Text = "Rol";
            // 
            // frm_edita_usuario
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(457, 696);
            Controls.Add(cmb_Rol);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_Cedula);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label5);
            Controls.Add(txt_Contrasenia);
            Controls.Add(label4);
            Controls.Add(txt_Correo);
            Controls.Add(label3);
            Controls.Add(txt_Apellidos);
            Controls.Add(label2);
            Controls.Add(chb_Estado);
            Controls.Add(txt_Nombres);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            ForeColor = Color.FromArgb(3, 4, 94);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_edita_usuario";
            ShowIcon = false;
            Text = "Editar Usuario";
            Load += frm_edita_usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txt_Cedula;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label label5;
        private TextBox txt_Contrasenia;
        private Label label4;
        private TextBox txt_Correo;
        private Label label3;
        private TextBox txt_Apellidos;
        private Label label2;
        private CheckBox chb_Estado;
        private TextBox txt_Nombres;
        private Label label1;
        private ComboBox cmb_Rol;
        private Label label6;
    }
}