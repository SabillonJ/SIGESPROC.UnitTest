﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbCotizacionesDetalle
    {
        public tbCotizacionesDetalle()
        {
            tbComprasDetalle = new HashSet<tbComprasDetalle>();
        }

        public int code_Id { get; set; }
        public int code_Cantidad { get; set; }
        public decimal code_PrecioCompra { get; set; }
        public int? coti_Id { get; set; }
        public int? cime_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime code_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? code_FechaModificacion { get; set; }
        public int? cime_InsumoOMaquinariaOEquipoSeguridad { get; set; }
        public int? code_Renta { get; set; }

        public virtual tbCotizaciones coti { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbComprasDetalle> tbComprasDetalle { get; set; }
    }
}