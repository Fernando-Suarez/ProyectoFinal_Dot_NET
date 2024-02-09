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
    public static class ProductoService
    {
        public static List<Producto> ListarProductos()
        {
            try
            {
                using (Context context = new Context())
                {
                    List<Producto> productos = context.Productos.ToList();
                    return productos;
                }
            }catch (Exception ex)
                {
                    throw new Exception("No se pudo listar los Productos", ex);
                }
        }

        public static Producto ObtenerProducto(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    Producto? producto = context.Productos.Where((p) => p.Id == id).FirstOrDefault();
                    
                    return producto;
   
                }
                

            } catch (Exception ex)
                {
                    throw new Exception("No Se pudo obtener el Producto",ex);
                }
        }

        public static bool CrearProducto(Producto producto)
        {
            try
            {
                using(Context context = new Context())
                {
                    context.Productos.Add(producto);
                    context.SaveChanges();
                    return true;

                }
            } catch (Exception ex)
            {
                throw new Exception("No se pudo crear el Producto", ex);
            }
        }

        public static bool ModificarProducto(Producto producto, int id)
        {
            try
            {
                using(Context context = new Context())
                {
                    Producto? productoId = context.Productos.Where(p => p.Id == id).FirstOrDefault();
                    productoId.Descripciones = producto.Descripciones;
                    productoId.Costo = producto.Costo;
                    productoId.PrecioVenta = producto.PrecioVenta;
                    productoId.Stock = producto.Stock;
                    context.Productos.Update(productoId);
                    context.SaveChanges();
                    return true;
                }
            } catch (Exception ex)
            {
              throw new Exception("No se puedo Modificar el Producto",ex);
            }
        }

        public static bool EliminarProducto(int id)
        {   
            try
            {
            using (Context context = new Context())
            {
                Producto? producto = context.Productos.Include((p) => p.ProductoVendidos).Where((p) => p.Id == id).FirstOrDefault();
                if (producto != null)
                {
                    context.Remove(producto);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

            }catch (Exception ex)
                {
                    throw new Exception("No se pudo eliminar el Producto", ex);
                }

        }

    }
}
