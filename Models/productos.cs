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
        [Display(Name ="Código")]
        public string productCode { get; set; }
        [Display(Name = "Folio")]
        public string productName { get; set; }
        [Display(Name = "Nombre")]
        public string description { get; set; }
        [Display(Name = "Descripción")]
        public int quantity { get; set; }
        [Display(Name = "Cantidad")]
        public decimal precio { get; set; }
        [Display(Name = "Código")]

        [ForeignKey("proveedores")]
        public int supplierId { get; set; }
        public virtual proveedores proveedores { get; set; }
    }
}