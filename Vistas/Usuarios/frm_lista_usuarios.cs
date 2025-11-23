using _02_CRUD.Controladores;

namespace _02_CRUD.Vistas.Usuarios
{
    public partial class frm_lista_usuarios : Form
    {
        private readonly Usuarios_Controller _usuarios = new Usuarios_Controller();
        public frm_lista_usuarios()
        {
            InitializeComponent();
        }

        private void frm_lista_usuarios_Load(object sender, EventArgs e)
        {
            cargar_lista();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var frm_insetar = new frm_insertar_usuario();
            frm_insetar.ShowDialog();
            this.Close();
            cargar_lista();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedIndex >=0)
            {
                // Confirmar eliminación con el usuario
                var confirm = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                {
                    return; // no eliminar
                }

                var result = _usuarios.eliminar((int)lst_lista_usuarios.SelectedValue);
                if (result != "ok")
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cargar_lista();
        }

        public void cargar_lista()
        {
            lst_lista_usuarios.DataSource = _usuarios.todos();
            lst_lista_usuarios.ValueMember = "Id_Usuario";
            lst_lista_usuarios.DisplayMember = "nombre_completo_Usuario";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id_usuario = (int)lst_lista_usuarios.SelectedValue;
                var editar_usuario = new frm_edita_usuario(id_usuario);
                editar_usuario.ShowDialog();
                this.Close();
            }
        }


    }
}
