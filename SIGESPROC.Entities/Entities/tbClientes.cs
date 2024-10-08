﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbClientes
    {
        public tbClientes()
        {
            tbPagos = new HashSet<tbPagos>();
            tbPresupuestosEncabezado = new HashSet<tbPresupuestosEncabezado>();
            tbProcesosVentas = new HashSet<tbProcesosVentas>();
            tbProyectos = new HashSet<tbProyectos>();
        }

        public int clie_Id { get; set; }
        public string clie_DNI { get; set; }
        public string clie_Nombre { get; set; }
        public string clie_Apellido { get; set; }
        public string clie_CorreoElectronico { get; set; }
        public string clie_Telefono { get; set; }
        public DateTime clie_FechaNacimiento { get; set; }
        public string clie_Sexo { get; set; }
        public string clie_DireccionExacta { get; set; }
        public int ciud_Id { get; set; }
        public int civi_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? clie_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? clie_FechaModificacion { get; set; }
        public bool? clie_Estado { get; set; }

        [NotMapped]
        public string cliente { get; set; }

        [NotMapped]

        public string Codigo { get; set; }
        [NotMapped]
        public string civi_Descripcion { get; set; }

        [NotMapped]
        public string esta_Id { get; set; }

        [NotMapped]
        public string esta_Nombre { get; set; }

        [NotMapped]
        public string pais_Id { get; set; }
        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public string ciud_Descripcion { get; set; }
        [NotMapped]

        public string clie_usua_Creacion { get; set; }
        [NotMapped]

        public string clie_usua_Modificacion { get; set; }
        [NotMapped]

        public string clie_usua_Creacionn { get; set; }
        [NotMapped]

        public string clie_usua_Modificacionn { get; set; }

        public string clie_NombreCompleto { get; set; }

        [NotMapped]
        public string clie_Tipo { get; set; }

        [NotMapped]
        public string tipoCliente { get; set; }

        public virtual tbCiudades ciud { get; set; }
        public virtual tbEstadosCiviles civi { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbPagos> tbPagos { get; set; }
        public virtual ICollection<tbPresupuestosEncabezado> tbPresupuestosEncabezado { get; set; }
        public virtual ICollection<tbProcesosVentas> tbProcesosVentas { get; set; }
        public virtual ICollection<tbProyectos> tbProyectos { get; set; }
    }
}