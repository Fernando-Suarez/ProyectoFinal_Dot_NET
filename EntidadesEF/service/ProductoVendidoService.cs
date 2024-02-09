using EntidadesEF.models;
using EntidadesEF.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEF.service
{
    public static class ProductoVendidoService
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            try
            {
                using (Context context = new Context())
                {
                    List<ProductoVendido> productosVendidos = context.ProductoVendidos.ToList();
                    return productosVendidos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar los Productos Vendidos", ex);
            }
        }

        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    ProductoVendido? productoVendido = context.ProductoVendidos.Where((p) => p.Id == id).FirstOrDefault();

                    return productoVendido;

                }


            }
            catch (Exception ex)
            {
                throw new Exception("No Se pudo obtener el Producto Vendido", ex);
            }
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                using (Context context = new Context())
                {
                    context.ProductoVendidos.Add(productoVendido);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear el Producto Vendido", ex);
            }
        }

        public static bool ModificarProducto(ProductoVendido productoVendido, int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    ProductoVendido? productoId = context.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();
                    productoId.Stock = productoVendido.Stock;
                    productoId.IdProducto = productoVendido.IdProducto;
                    productoId.IdVenta = productoVendido.IdVenta;
                    context.ProductoVendidos.Update(productoId);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Modificar el Producto Vendido", ex);
            }
        }

        public static bool EliminarProductoVendido(int id)
        {
            try
            {
                using (Context context = new Context())
                {
                    ProductoVendido? productoVendido = context.ProductoVendidos.Where((p) => p.Id == id).FirstOrDefault();
                    if (productoVendido != null)
                    {
                        context.Remove(productoVendido);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el Producto Vendido", ex);
            }

        }

    }
}
