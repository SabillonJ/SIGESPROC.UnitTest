﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbGestionesAdicionales
    {
        public tbGestionesAdicionales()
        {
            tbImagenesPorGestionesAdicionales = new HashSet<tbImagenesPorGestionesAdicionales>();
        }

        public int adic_Id { get; set; }
        public string adic_Descripcion { get; set; }
        public DateTime adic_Fecha { get; set; }
        public decimal adic_PresupuestoAdicional { get; set; }
        public int? Proy_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime adic_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? adic_FechaModificacion { get; set; }
        public bool? adic_Estado { get; set; }

        [NotMapped]
        public int acet_Id { get; set; }

        [NotMapped]
        public int codigo { get; set; }

        public string acti_Descripcion { get; set; }
        [NotMapped]
        public int acet_Cantidad { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string etap_Id { get; set; }
        [NotMapped]
        public string etpr_Id { get; set; }
        [NotMapped]
        public string etap_Descripcion { get; set; }

        [NotMapped]
        public string proy_Descripcion { get; set; }
        [NotMapped]

        public string adic_UsuarioCreacion { get; set; }
        [NotMapped]

        public string adic_UsuarioModificacion { get; set; }
        public virtual tbProyectos Proy { get; set; }

        public virtual tbActividadesPorEtapas acet { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbImagenesPorGestionesAdicionales> tbImagenesPorGestionesAdicionales { get; set; }
    }
}