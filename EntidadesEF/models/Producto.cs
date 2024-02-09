using System;
using System.Collections.Generic;

namespace EntidadesEF.models
{
    public partial class Producto
    {
        public Producto()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public int Id { get; set; }
        public string Descripciones { get; set; } = null!;
        public decimal? Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id} \nDESCRIPCIONES: {this.Descripciones} \nCOSTO: {this.Costo} \nPRECIOVENTA: {this.PrecioVenta} \nSTOCK: {this.Stock} \nIDUSUARIO:{this.IdUsuario} \n";
        }
    }
}
