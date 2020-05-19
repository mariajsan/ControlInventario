using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class proveedorescontextdb : DbContext
    {
        public proveedorescontextdb() : base("MyConnection")
        {
        }
        public DbSet<proveedores> Proveedor { get; set; }
    }
}