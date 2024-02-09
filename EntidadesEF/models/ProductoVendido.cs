using System;
using System.Collections.Generic;

namespace EntidadesEF.models
{
    public partial class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
        public virtual Venta IdVentaNavigation { get; set; } = null!;

        public override string ToString()
        {
            return $"ID: {this.Id} \nSTOCK: {this.Stock} \nIDPRODUCTO: {this.IdProducto} \nIDVENTA: {this.IdVenta} \n  ";
        }
    }
}
