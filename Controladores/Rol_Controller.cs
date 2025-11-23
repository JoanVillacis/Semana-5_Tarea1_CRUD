using _02_CRUD.Config;
using _02_CRUD.Modelos;
using System;

namespace _02_CRUD.Controladores
{
    public class Rol_Controller
    {
        public readonly sqlServer_dbcontext _Rol_Dbcontext = new sqlServer_dbcontext();

        public List<Rol_Model> todos()
        {
            var list = new List<Rol_Model>();
            list = _Rol_Dbcontext.Roles.ToList();
            return list;
        }

        public Rol_Model uno(int id)
        {
            return _Rol_Dbcontext.Roles.FirstOrDefault(r => r.Id_Rol == id);
        }

        public string insetar(Rol_Model Rol_Model)
        {
            if (Rol_Model == null)
            {
                return "Debe completar la caja de texto para guardar al rol";
            }
            else
            {
                _Rol_Dbcontext.Add(Rol_Model);
                _Rol_Dbcontext.SaveChanges();
                return "ok";
            }
        }

        public string editar(Rol_Model Rol_Model)
        {
            if (Rol_Model == null)
            {
                return "Debe completar la caja de texto para guardar al rol";
            }
            else
            {
                var rol_existente = _Rol_Dbcontext.Roles.FirstOrDefault(r => r.Id_Rol == Rol_Model.Id_Rol);
                if (rol_existente == null)
                {
                    return "Rol no encontrado";
                }

                rol_existente.Nombre_Rol = Rol_Model.Nombre_Rol;
                rol_existente.Descripcion_Rol = Rol_Model.Descripcion_Rol;
                rol_existente.Estado_Rol = Rol_Model.Estado_Rol;

                _Rol_Dbcontext.SaveChanges();
                return "ok";
            }
        }

        public string eliminar(int id)
        {
            // Buscar la entidad y la elimina
            var rol = _Rol_Dbcontext.Roles.Find(id);
            if (rol == null)
            {
                return "No se encontró el rol a eliminar";
            }

            try
            {
                _Rol_Dbcontext.Roles.Remove(rol);
                _Rol_Dbcontext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Ocurrio un error al eliminar el rol: " + ex.Message;
            }
        }
    }
}
