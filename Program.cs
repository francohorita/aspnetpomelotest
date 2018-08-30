using System;
using aspnetefmysql.Models;
using System.Linq;

namespace aspnetefmysql
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new Sql10253958Context();
            var facturas = dbContext.Facturas.ToList();
            foreach (var f in facturas)
            {
                System.Console.WriteLine($"ID:{f.Id} Fecha:{f.Fecha} Cliente:{f.Cliente} Usuario:{f.Usuario}");
            }
        }
    }
}
