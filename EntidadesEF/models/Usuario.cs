using System;
using System.Collections.Generic;

namespace EntidadesEF.models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Productos = new HashSet<Producto>();
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string Mail { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id} \nNOMBRE: {this.Nombre} \nAPELLIDO: {this.Apellido} \nNOMBREUSUARIO: {this.NombreUsuario} \nCONTRASEÑA: {this.Contraseña} \nEMAIL:{this.Mail}\n";
        }
    }
}
