using _02_CRUD.Controladores;
using _02_CRUD.Modelos;
using _02_CRUD.Vistas.Usuarios;

namespace _02_CRUD.Vistas.Roles
{
    public partial class frm_agregar_rol : Form
    {
        private readonly Rol_Controller _roles_Controller = new Rol_Controller();
        public frm_agregar_rol()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Complete los campos para guardar el rol");
                return;
            }

            var rol = new Rol_Model
            {
                Nombre_Rol = txt_Nombre.Text.Trim(),
                Descripcion_Rol = txt_Descricion.Text.Trim(),
                Estado_Rol = chb_Estado.Checked == true,
            };

            var nuevo_rol = _roles_Controller.insetar(rol);

            if (nuevo_rol != "ok")
            {
                MessageBox.Show(nuevo_rol);
            }
            else
            {
                MessageBox.Show("Rol insertado con exito");
                limpiar_cajas();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public bool validaciones()
        {
            if (txt_Nombre.Text.Trim() == "" || txt_Descricion.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void limpiar_cajas()
        {
            txt_Nombre.Text = "";
            txt_Descricion.Text = "";
            chb_Estado.Checked = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.limpiar_cajas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
