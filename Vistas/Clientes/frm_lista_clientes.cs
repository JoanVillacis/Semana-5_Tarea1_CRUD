namespace _02_CRUD.Vistas.Clientes
{
    using _02_CRUD.Controladores;
    using _02_CRUD.Vistas.Usuarios;
    using System.Windows.Forms.VisualStyles;

    public partial class frm_lista_clientes : Form
    {
        private readonly Cliente_Controller _cliente_controller = new Cliente_Controller();
        public frm_lista_clientes()
        {
            InitializeComponent();
        }

        private void frm_lista_clientes_Load(object sender, EventArgs e)
        {
            cargar_lista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_clientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id_cliente = (int)lst_lista_clientes.SelectedValue;
                var editar_cliente = new frm_editar_cliente(id_cliente);
                editar_cliente.ShowDialog();
            }
                this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var frm_agregar = new frm_agregar_cliente();
            frm_agregar.ShowDialog();
            cargar_lista();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_clientes.SelectedIndex >= 0)
            {
                var confirm = MessageBox.Show("¿Está seguro que desea eliminar el cliente seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                {
                    return;
                }
                var result = _cliente_controller.eliminar((int)lst_lista_clientes.SelectedValue);
                if (result != "ok")
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cargar_lista();
        }

        public void cargar_lista()
        {
            lst_lista_clientes.DataSource = _cliente_controller.todos();
            lst_lista_clientes.ValueMember = "id";
            lst_lista_clientes.DisplayMember = "Nombre_Completo";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
