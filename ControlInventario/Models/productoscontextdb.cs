using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class productoscontextdb : DbContext
    {
        public productoscontextdb() : base("MyConnection")
        {
        }
        public DbSet<productos> Producto { get; set; }
    }
}