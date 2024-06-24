using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMvvm1.Models
{
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [SQLite.NotNull]
        public string Nombre { get; set; }

        public string Proveedor { get; set; }

        public double Precio_compra { get; set; }

        public double Total { get; set; }


    }
}
