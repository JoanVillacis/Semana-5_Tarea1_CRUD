namespace _02_CRUD.Controladores
{
    using _02_CRUD.Config;
    using _02_CRUD.Modelos;
    using System;

    public class Cliente_Controller
    {
        public readonly sqlServer_dbcontext _Cliente_Dbcontext = new sqlServer_dbcontext();
        public List<ClienteModel> todos()
        {
            var list = new List<ClienteModel>();
            list = _Cliente_Dbcontext.Clientes.ToList();
            foreach (var cliente in list)
            {
                cliente.Nombre_Completo = cliente.Nombres + " " + cliente.Apellidos;
            }
            return list;
        }

        public ClienteModel uno(int id)
        {
            return _Cliente_Dbcontext.Clientes.FirstOrDefault(c => c.id == id);
        }

        public string insetar(ClienteModel clienteModel)
        {
            if (clienteModel == null)
            {
                return "Debe completar las cajas de texto para guardar al cliente";
            }
            else
            {
                _Cliente_Dbcontext.Add(clienteModel);
                _Cliente_Dbcontext.SaveChanges();
                return "ok";
            }
        }

        public string editar(ClienteModel clienteModel)
        {
            if (clienteModel == null)
            {
                return "Debe completar las cajas de texto para guardar al cliente";
            }
            else
            {
                //_Rol_Dbcontext.Update(clienteModel);
                var cliente_existente = _Cliente_Dbcontext.Clientes.FirstOrDefault(c => c.id == clienteModel.id);
                if (cliente_existente == null)
                {
                    return "Cliente no encontrado";
                }

                cliente_existente.Nombres = clienteModel.Nombres;
                cliente_existente.Apellidos = clienteModel.Apellidos;
                cliente_existente.RUC = clienteModel.RUC;
                cliente_existente.Direccion = clienteModel.Direccion;
                cliente_existente.Correo = clienteModel.Correo;
                cliente_existente.Telefono = clienteModel.Telefono;
                cliente_existente.Estado = clienteModel.Estado;

                _Cliente_Dbcontext.SaveChanges();
                return "ok";
            }
        }

        public string eliminar(int id)
        {
            var cliente = _Cliente_Dbcontext.Clientes.Find(id);
            if (cliente == null)
            {
                return "No se encontró el cliente a eliminar";
            }

            try
            {
                _Cliente_Dbcontext.Clientes.Remove(cliente);
                _Cliente_Dbcontext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Ocurrio un error al eliminar el cliente: " + ex.Message;
            }
        }

        public string eliminacion_suave(int id)
        {
            if(id <=0) return "Error al eliminar, el cliente no existe";
            var cliente = _Cliente_Dbcontext.Clientes.FirstOrDefault(c => c.id == id);
            if (cliente != null)
            {
                cliente.Estado = false;
                _Cliente_Dbcontext.SaveChanges();
                return "ok";
            }
            else
            {
                return "Ocurrio un error al guardar";
            }
        }
    }
}
