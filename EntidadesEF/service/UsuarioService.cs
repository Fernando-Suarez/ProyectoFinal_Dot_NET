using EntidadesEF.database;
using EntidadesEF.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEF.service
{
    public static class UsuarioService
    {
        public static List<Usuario> ListarUsuarios()
        {
            
            using (Context context = new Context())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();
                return usuarios;
            }
        }

        public static List<Usuario> ObtenerUsuario(int id)
        {
            
            using (Context context = new Context())
            {
                 ;
                List<Usuario> lista = new List<Usuario>();
                Usuario? UsuarioId = context.Usuarios.Where((usuario) => usuario.Id  == id).FirstOrDefault();
                
                lista.Add(UsuarioId);
                return lista;

                

            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            using (Context context = new Context())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return true;
            }
        }

        public static bool ModificarUsuario(Usuario usuario, int id)
        {
            using(Context context = new Context())
            {
                Usuario? usuarioId = context.Usuarios.Where((usuario) => usuario.Id == id).FirstOrDefault();
                usuarioId.Nombre = usuario.Nombre;
                usuarioId.Apellido = usuario.Apellido;
                usuarioId.NombreUsuario = usuario.NombreUsuario;
                usuarioId.Mail = usuario.Mail;

                context.Usuarios.Update(usuarioId);
                context.SaveChanges();
                return true;
            }
        }

        public static bool EliminarUsuario(int id)
        {
            using (Context context = new Context())
            {
                Usuario? usuario = context.Usuarios.Include((u) => u.Productos).Where((u) => u.Id == id).FirstOrDefault();
                if (usuario != null)
                {
                    context.Remove(usuario);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
