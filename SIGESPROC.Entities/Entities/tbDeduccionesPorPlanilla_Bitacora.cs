﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbDeduccionesPorPlanilla_Bitacora
    {
        public int depl_Id { get; set; }
        public int dedu_Id { get; set; }
        public int plde_Id { get; set; }
        public decimal dedu_Porcentaje { get; set; }
        public bool? dedu_EsMontoFijo { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime depl_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? depl_FechaModificacion { get; set; }
        public bool? depl_Estado { get; set; }
        public bool? depl_SaberSiDeduce { get; set; }
        public string accion { get; set; }
    }
}