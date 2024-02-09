using EntidadesADO.Models;
using EntidadesADO.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesADO.services
{
    public static class UsuarioService
    {
        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static Usuario ObtenerUsuario(int id)
        {
            return UsuarioData.ObtenerUsuario(id);
        }

        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario(Usuario usuario, int id)
        {
            UsuarioData.ModificarUsuario(usuario, id);
        }

        public static bool EliminarUsuario(int id)
        {
            return UsuarioData.EliminarUsuario(id);
        }
    }
}
