﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbDeduccionesPorEmpleados_Bitacora
    {
        public int deem_Id { get; set; }
        public int dedu_Id { get; set; }
        public int empl_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime deem_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? deem_FechaModificacion { get; set; }
        public decimal? deem_Porcentaje { get; set; }
        public bool? deem_EsMontoFijo { get; set; }
        public string accion { get; set; }
    }
}