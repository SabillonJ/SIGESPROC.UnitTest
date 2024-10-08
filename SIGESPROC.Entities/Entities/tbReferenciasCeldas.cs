﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbReferenciasCeldas
    {
        public int rece_Id { get; set; }
        public string rece_Referencia { get; set; }
        public string rece_Tipo { get; set; }
        public int acet_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? rece_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? rece_FechaModificacion { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }
        public virtual tbActividadesPorEtapas acet { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}