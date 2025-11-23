namespace _02_CRUD.Vistas
{
    partial class frm_login
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
            label1 = new Label();
            txt_Correo = new TextBox();
            btn_login1 = new Button();
            txt_Pwd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_login2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(3, 4, 94);
            label1.Location = new Point(82, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(40, 206);
            txt_Correo.Margin = new Padding(5);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(262, 39);
            txt_Correo.TabIndex = 1;
            txt_Correo.Leave += txt_Correo_Leave;
            // 
            // btn_login1
            // 
            btn_login1.BackColor = Color.FromArgb(0, 119, 182);
            btn_login1.ForeColor = Color.White;
            btn_login1.Location = new Point(12, 386);
            btn_login1.Margin = new Padding(5);
            btn_login1.Name = "btn_login1";
            btn_login1.Size = new Size(153, 45);
            btn_login1.TabIndex = 3;
            btn_login1.Text = "Login 1";
            btn_login1.UseVisualStyleBackColor = false;
            btn_login1.Click += btn_login1_Click;
            // 
            // txt_Pwd
            // 
            txt_Pwd.Location = new Point(40, 310);
            txt_Pwd.Margin = new Padding(5);
            txt_Pwd.Name = "txt_Pwd";
            txt_Pwd.Size = new Size(262, 39);
            txt_Pwd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 4, 94);
            label2.Location = new Point(40, 169);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(3, 4, 94);
            label3.Location = new Point(40, 273);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btn_login2
            // 
            btn_login2.BackColor = Color.FromArgb(0, 180, 216);
            btn_login2.ForeColor = Color.White;
            btn_login2.Location = new Point(175, 386);
            btn_login2.Margin = new Padding(5);
            btn_login2.Name = "btn_login2";
            btn_login2.Size = new Size(153, 45);
            btn_login2.TabIndex = 4;
            btn_login2.Text = "Login 2";
            btn_login2.UseVisualStyleBackColor = false;
            btn_login2.Click += btn_login2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_icon_icons_com_57997;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(126, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 97);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(339, 446);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Pwd);
            Controls.Add(btn_login1);
            Controls.Add(txt_Correo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "frm_login";
            ShowIcon = false;
            Text = "Inicio de Sesion";
            Load += frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Correo;
        private Button btn_login1;
        private TextBox txt_Pwd;
        private Label label2;
        private Label label3;
        private Button btn_login2;
        private PictureBox pictureBox1;
    }
}