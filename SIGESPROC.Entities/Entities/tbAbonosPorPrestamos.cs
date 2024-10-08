﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbAbonosPorPrestamos
    {
        [NotMapped]
        public int codigo { get; set; }
        public int abpr_Id { get; set; }
        public int pres_Id { get; set; }
        public decimal abpr_MontoAbonado { get; set; }
        public bool abpr_DeducidoEnPlanilla { get; set; }
        public DateTime abpr_Fecha { get; set; }
        [NotMapped]
        public string fecha { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime abpr_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? abpr_FechaModificacion { get; set; }

        public virtual tbPrestamos pres { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}