using EntidadesADO.Models;
using EntidadesADO.services;
namespace pruebasEntidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------PRODUCTO------------------------------
            //Obtener Producto

            Console.WriteLine(ProductoService.ObtenerProducto(1).ToString());


            //Listar Productos

            //foreach (Producto producto in ProductoService.ListarProductos())
            //{
            //    Console.WriteLine(producto.ToString());
            //}

            //Crear Producto

            //Producto productoNuevo = new Producto(1,"gaseosa",1400,2000,100,1);

            //if(productoNuevo is not null)
            //{
            //    ProductoService.CrearProducto(productoNuevo);
            //    Console.WriteLine("Producto Creado con Exito");
            //}


            //Modificar Producto
            //try
            //{
            //    Producto productoModificado = new Producto(2,"Pantalon Jean",900.00,4500.00,12,1);
            //    ProductoService.ModificarProducto(productoModificado, 2);
            //    Console.WriteLine("Producto Modificado con Exito");
            //} catch (Exception ex)
            //{
            //    throw new Exception("No se puedo modificar el producto", ex);
            //}


            //Eliminar Producto
            //try
            //{
            //    ProductoService.EliminarProducto(1);
            //    Console.WriteLine("Producto Eliminado Con Exito");
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("No se Pudo Eliminar el Producto", ex);
            //}


            //----------------- PRODUCTO VENDIDO----------------------
            //Obtener ProductoVendido
            //Console.WriteLine(ProductoVendidoService.ObtenerProductoVendido(1).ToString());


            ////Listar Productos Vendidos

            //foreach (ProductoVendido producto in ProductoVendidoService.ListarProductosVendidos())
            //{
            //    Console.WriteLine(producto.ToString());
            //}

            ////Crear Producto Vendido

            //ProductoVendido productoNuevo = new ProductoVendido(1, 2,50, 1);

            //if (productoNuevo is not null)
            //{
            //    ProductoVendidoService.CrearProductoVendido(productoNuevo);
            //    Console.WriteLine("Producto Vendido Creado con Exito");
            //}


            ////Modificar Producto
            //try
            //{
            //    ProductoVendido productoModificado = new ProductoVendido(1,2,25,1);
            //    ProductoVendidoService.ModificarProductoVendido(productoModificado, 2);
            //    Console.WriteLine("Producto Vendido Modificado con Exito");
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("No se puedo modificar el producto vendido", ex);
            //}


            ////Eliminar Producto
            //try
            //{
            //    ProductoVendidoService.EliminarProductoVendido(1);
            //    Console.WriteLine("Producto Vendido Eliminado Con Exito");
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("No se Pudo Eliminar el Producto Vendido", ex);
            //}
        }
    }
}
