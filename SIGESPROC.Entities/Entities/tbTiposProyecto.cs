﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbTiposProyecto
    {
        public tbTiposProyecto()
        {
            tbProyectos = new HashSet<tbProyectos>();
        }

        public int tipr_Id { get; set; }
        public string tipr_Descripcion { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime tipr_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? tipr_FechaModificacion { get; set; }
        public bool? tipr_Estado { get; set; }

        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }
        [NotMapped]
        public int row { get; set; }

        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbProyectos> tbProyectos { get; set; }
    }
}