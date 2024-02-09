﻿using EntidadesADO.Database;
using EntidadesADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesADO.services
{
    public class ProductoService
    {
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static Producto ObtenerProducto(int id)
        {
            return ProductoData.ObtenerProducto(id);
        }

        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(Producto producto, int id)
        {
            ProductoData.ModificarProducto(producto, id);
        }

        public static bool EliminarProducto(int id)
        {
            return ProductoData.EliminarProducto(id);
        }
    }
}
