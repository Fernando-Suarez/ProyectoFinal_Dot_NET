using EntidadesADO.Models;
using EntidadesADO.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesADO.services
{
    public static class VentaService
    {
        public static List<Venta> ListarVentas()
        {
            return VentaData.ListarVentas();
        }

        public static Venta ObtenerVenta(int id)
        {
            return VentaData.ObtenerVenta(id);
        }

        public static void CrearVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }

        public static void ModificarVenta(Venta venta, int id)
        {
            VentaData.ModificarVenta(venta, id);
        }

        public static bool EliminarVenta(int id)
        {
            return VentaData.EliminarVenta(id);
        }
    }
}
