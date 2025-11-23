namespace _02_CRUD.Vistas.Roles
{
    partial class frm_editar_rol
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
            chb_Estado = new CheckBox();
            label3 = new Label();
            txt_Descricion = new TextBox();
            btn_Salir = new Button();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            label2 = new Label();
            txt_Nombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // chb_Estado
            // 
            chb_Estado.AutoSize = true;
            chb_Estado.Location = new Point(233, 272);
            chb_Estado.Margin = new Padding(5);
            chb_Estado.Name = "chb_Estado";
            chb_Estado.Size = new Size(106, 36);
            chb_Estado.TabIndex = 3;
            chb_Estado.Text = "Estado";
            chb_Estado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 164);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 44;
            label3.Text = "Descripción ";
            // 
            // txt_Descricion
            // 
            txt_Descricion.Location = new Point(161, 212);
            txt_Descricion.Margin = new Padding(5);
            txt_Descricion.MaxLength = 50;
            txt_Descricion.Name = "txt_Descricion";
            txt_Descricion.Size = new Size(313, 39);
            txt_Descricion.TabIndex = 2;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 119, 182);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(18, 228);
            btn_Salir.Margin = new Padding(5);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(124, 49);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click_1;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(0, 180, 216);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(18, 151);
            btn_Cancelar.Margin = new Padding(5);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(124, 49);
            btn_Cancelar.TabIndex = 5;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(0, 119, 182);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(18, 76);
            btn_Guardar.Margin = new Padding(5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(124, 49);
            btn_Guardar.TabIndex = 4;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 58);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 39;
            label2.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(161, 106);
            txt_Nombre.Margin = new Padding(5);
            txt_Nombre.MaxLength = 50;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(313, 39);
            txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(174, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 37;
            label1.Text = "EDITAR ROL";
            // 
            // frm_editar_rol
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(491, 318);
            Controls.Add(chb_Estado);
            Controls.Add(label3);
            Controls.Add(txt_Descricion);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(label2);
            Controls.Add(txt_Nombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            ForeColor = Color.FromArgb(3, 4, 94);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_editar_rol";
            ShowIcon = false;
            Text = "Editar Rol";
            Load += frm_editar_rol_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chb_Estado;
        private Label label3;
        private TextBox txt_Descricion;
        private Button btn_Salir;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Label label2;
        private TextBox txt_Nombre;
        private Label label1;
    }
}