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

        public string Direccion { get; set; }

        public string Celular { get; set; }

        public string Pais { get; set; }


    }
}
