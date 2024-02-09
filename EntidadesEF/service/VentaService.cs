using EntidadesEF.models;
using EntidadesEF.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntidadesEF.service
{
    public static class VentaService
    {

        public static List<Venta> ListarVentas()
        {
            try
            {
                using (Context context = new Context())
                {
                    List<Venta> ventas = context.Venta.ToList();
                    return ventas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar las Ventas", ex);
            }
        }

        public static Venta ObtenerVenta(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    Venta? venta = context.Venta.Where((v) => v.Id == id).FirstOrDefault();

                    return venta;

                }


            }
            catch (Exception ex)
            {
                throw new Exception("No Se pudo obtener la Venta", ex);
            }
        }

        public static bool CrearVenta(Venta venta)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.Venta.Add(venta);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear la Venta", ex);
            }
        }

        public static bool ModificarVenta(Venta venta, int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    Venta? ventaId = context.Venta.Where(v => v.Id == id).FirstOrDefault();
                    ventaId.Comentarios = venta.Comentarios;
                    ventaId.IdUsuario = venta.IdUsuario;                   
                    context.Venta.Update(ventaId);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Modificar la Venta", ex);
            }
        }

        public static bool EliminarVenta(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    Venta? venta = context.Venta.Include((p)=> p.ProductoVendidos). Where((v) => v.Id == id).FirstOrDefault();
                    if (venta != null)
                    {
                        context.Remove(venta);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar la Venta", ex);
            }

        }

    }
}
