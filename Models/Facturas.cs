using System;
using System.Collections.Generic;

namespace aspnetefmysql.Models
{
    public partial class Facturas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public int Usuario { get; set; }
        public DateTime Creado { get; set; }
    }
}
