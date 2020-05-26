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
        [Display(Name = "Código")]
        public int supplierId { get; set; }
        [Display(Name = "Identificación")]
        public string supplierCode { get; set; }
        [Display(Name = "Nombre")]
        public string supplierName { get; set; }

        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        [Display(Name = "Dirección")]
        public string Address { get; set; }        

    }
}