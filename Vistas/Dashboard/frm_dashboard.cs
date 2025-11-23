
namespace _02_CRUD.Vistas.Dashboard
{
    using _02_CRUD.Vistas.Usuarios;
    using _02_CRUD.Vistas.Clientes;
    using _02_CRUD.Vistas.Roles;
    using Microsoft.IdentityModel.Tokens;

    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_lista_usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_insertar_usuario = new frm_insertar_usuario();
            frm_insertar_usuario.ShowDialog();
        }

        private void editarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_lista_usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_clientes = new frm_lista_clientes();
            frm_lista_clientes.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_cliente = new frm_agregar_cliente();
            frm_agregar_cliente.ShowDialog();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_clientes = new frm_lista_clientes();
            frm_lista_clientes.ShowDialog();
        }

        private void listaDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_roles = new frm_lista_roles();
            frm_lista_roles.ShowDialog();
        }

        private void agregarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_agregar_rol = new frm_agregar_rol();
            frm_agregar_rol.ShowDialog();
        }

        private void editarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_roles = new frm_lista_roles();
            frm_lista_roles.ShowDialog();
        }

        private void eliminarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_roles = new frm_lista_roles();
            frm_lista_roles.ShowDialog();
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_lista_usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_clientes = new frm_lista_clientes();
            frm_lista_clientes.ShowDialog();
        }
    }
}
