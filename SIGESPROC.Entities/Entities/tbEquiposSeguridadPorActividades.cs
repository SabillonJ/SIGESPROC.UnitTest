﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbEquiposSeguridadPorActividades
    {
        public int eqac_Id { get; set; }
        public int eqpp_Id { get; set; }
        public decimal eqac_Costo { get; set; }
        public int eqac_Cantidad { get; set; }
        public int? equs_Id { get; set; }
        public int acet_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? eqac_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? eqac_FechaModificacion { get; set; }
        public bool? eqac_Estado { get; set; }

        [NotMapped]
        public string equs_Nombre { get; set; }
        [NotMapped]
        public string equs_Descripcion { get; set; }
        [NotMapped]
        public string prov_Descripcion { get; set; }

        public virtual tbActividadesPorEtapas acet { get; set; }
        public virtual tbEquiposSeguridadPorProveedores eqpp { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}