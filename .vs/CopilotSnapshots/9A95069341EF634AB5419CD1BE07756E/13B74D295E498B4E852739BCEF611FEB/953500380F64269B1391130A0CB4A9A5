using _02_CRUD.Controladores;
using _02_CRUD.Modelos;
using _02_CRUD.Vistas.Clientes;
using System.Data;

namespace _02_CRUD.Vistas.Usuarios
{
    public partial class frm_insertar_usuario : Form
    {
        private readonly Usuarios_Controller _usuarios_Controller = new Usuarios_Controller();
        private readonly Auth_Controller _auth_Controller = new Auth_Controller();
        public frm_insertar_usuario()
        {
            InitializeComponent();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Complete los campos para guardar el usuario");
                return;
            }
            if (!validacion_cedula())
            {
                MessageBox.Show("La cedula ingresada no es correcta");
                return;
            }


            var usuario_model = new Usuario_Model
            {
                Apellidos_Usuario = txt_Apellidos.Text.Trim(),
                Nombres_Usuario = txt_Nombres.Text.Trim(),
                Cedula_Usuario = txt_Cedula.Text.Trim(),
                Correo_Usuario = txt_Correo.Text.Trim(),
                Contrasenia = txt_Contrasenia.Text.Trim(),
                Estado_Usuario = chb_Estado.Checked == true,
                Rol_Id = (int)cmb_Rol.SelectedValue
            };
            var nuevo_usuario = _usuarios_Controller.insetar(usuario_model);

            if (nuevo_usuario != "ok")
            {
                MessageBox.Show(nuevo_usuario);
            }
            else
            {
                MessageBox.Show("Usuario insertado con exito");
                limpiar_cajas();
                // Cerrar el dialog indicando éxito para que la lista que llamó refresque
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void limpiar_cajas()
        {
            txt_Apellidos.Text = "";
            txt_Nombres.Text = "";
            txt_Cedula.Text = "";
            txt_Correo.Text = "";
            txt_Contrasenia.Text = "";
            chb_Estado.Checked = false;
        }

        private void txt_Contrasenia_Leave(object sender, EventArgs e)
        {

        }

        private void txt_Cedula_Leave(object sender, EventArgs e)
        {
            validacion_cedula();
        }
        public bool validaciones()
        {
            if (txt_Apellidos.Text.Trim() == "" || txt_Cedula.Text.Trim() == ""
                || txt_Contrasenia.Text.Trim() == "" || txt_Contrasenia.Text.Trim() == ""
                || txt_Nombres.Text.Trim() == "" || cmb_Rol.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool validacion_cedula()
        {
            if (txt_Cedula.Text.Length != 10)
            {
                MessageBox.Show("La cedula ingresada no contiene 10 caracteres");
                return false;
            }
            bool validacion = _auth_Controller.VerificaCedula(txt_Cedula.Text.ToCharArray());
            if (!validacion)
            {
                MessageBox.Show("Cédula inválida. Por favor, ingrese una cédula correcta.");
                txt_Cedula.Text = "";
                txt_Cedula.Focus();
                return false;
            }
            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.limpiar_cajas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_insertar_usuario_Load(object sender, EventArgs e)
        {
            List<Rol_Model> roles = new Rol_Controller().todos();

            // Configurar el ComboBox para mostrar el nombre y usar el ID como valor
            cmb_Rol.DataSource = roles;
            cmb_Rol.DisplayMember = "Nombre_Rol"; // Lo que se ve
            cmb_Rol.ValueMember = "Id_Rol";       // Lo que se guarda
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
