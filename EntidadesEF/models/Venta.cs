using System;
using System.Collections.Generic;

namespace EntidadesEF.models
{
    public partial class Venta
    {
        public Venta()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id} \nCOMENTARIOS: {this.Comentarios} \nIDUSUARIO: {this.IdUsuario} \n";
        }
    }
}
