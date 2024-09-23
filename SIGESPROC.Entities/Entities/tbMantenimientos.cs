﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbMantenimientos
    {
        public tbMantenimientos()
        {
            tbProcesosVentas = new HashSet<tbProcesosVentas>();
        }

        public int mant_Id { get; set; }
        public string? mant_DNI { get; set; }
        public string mant_NombreCompleto { get; set; }
        public decimal? mant_Telefono { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime mant_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? mant_FechaModificacion { get; set; }
        public bool? mant_Estado { get; set; }
        [NotMapped]
        public string codigo { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }

        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbProcesosVentas> tbProcesosVentas { get; set; }
    }
}