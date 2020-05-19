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
        [Display(Name = "Código")]
        public string supplierCode { get; set; }
        [Display(Name = "Identificación")]
        public string supplierName { get; set; }
        [Display(Name = "Nombre")]

        public string Email { get; set; }
        [Display(Name = "Correo electrónico")]
        public string Phone { get; set; }
        [Display(Name = "Teléfono")]
        public string Address { get; set; }   
        //[Display(Name = "Dirección")]

    }
}