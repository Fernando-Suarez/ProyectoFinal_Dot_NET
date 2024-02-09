using EntidadesADO.Models;
using EntidadesADO.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesADO.services
{
    public static class ProductoVendidoService
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido, int id)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido, id);
        }

        public static bool EliminarProductoVendido(int id)
        {
            return ProductoVendidoData.EliminarProductoVendido(id);
        }
    }
}
