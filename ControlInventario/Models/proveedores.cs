using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Models
{
    public class proveedores
    {
        [Key]
        public int supplierId { get; set; }
        public string supplierCode { get; set; }
        public string supplierName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


    }
}