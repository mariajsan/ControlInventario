using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlInventario.Models
{
    public class productos
    {
        [Key]
        public int productId { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public decimal precio { get; set; }

        [ForeignKey("proveedores")]
        public int supplierId { get; set; }
        public virtual proveedores proveedores { get; set; }
    }
}