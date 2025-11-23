using System;

namespace _02_CRUD.Vistas
{
    using _02_CRUD.Controladores;
    using _02_CRUD.Modelos;
    using _02_CRUD.Vistas.Dashboard;
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class frm_login : Form
    {
        private readonly Auth_Controller _auth_Controller = new Auth_Controller();
        int _contador = 3;
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login1_Click(object sender, EventArgs e)
        {
            Login_Model model = new Login_Model()
            {
                Correo_Usuario = txt_Correo.Text.Trim(),
                contrasenia = txt_Pwd.Text.Trim()
            };
            Usuario_Model usuario = _auth_Controller.login1(model);
            if (usuario != null)
            {
                MessageBox.Show("Login exitoso");
                var dash = new frm_dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                _contador--;
                if (_contador == 0)
                {
                    MessageBox.Show("Usted a sobre pasado el numero de intentos");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas, le quedan {_contador} intentos");
                }
            }
        }

        private void btn_login2_Click(object sender, EventArgs e)
        {
            Login_Model model = new Login_Model()
            {
                Correo_Usuario = txt_Correo.Text.Trim(),
                contrasenia = txt_Pwd.Text.Trim()
            };
            Usuario_Model usuario = _auth_Controller.login2(model);
            if (usuario != null)
            {
                MessageBox.Show("Login exitoso");
                var dash = new frm_dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                _contador--;
                if (_contador == 0)
                {
                    MessageBox.Show("Usted a sobre pasado el numero de intentos");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas, le quedan {_contador} intentos");
                }
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            bool ok = Regex.IsMatch(txt_Correo.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
            if (!ok)
            {
                txt_Correo.Text = "";
                txt_Correo.Focus();
                MessageBox.Show("El correo no tiene un formato valido");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
