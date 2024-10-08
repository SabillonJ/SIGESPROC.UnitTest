﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbActividadesPorEtapas
    {
        public tbActividadesPorEtapas()
        {
            tbComprasDetallesDireccionesPorMaquinaria = new HashSet<tbComprasDetallesDireccionesPorMaquinaria>();
            tbControlDeCalidadesPorActividades = new HashSet<tbControlDeCalidadesPorActividades>();
            tbEquiposSeguridadPorActividades = new HashSet<tbEquiposSeguridadPorActividades>();
            tbGestionesAdicionales = new HashSet<tbGestionesAdicionales>();
            tbIncidenciasPorActividades = new HashSet<tbIncidenciasPorActividades>();
            tbIncidentes = new HashSet<tbIncidentes>();
            tbInsumosPorActividades = new HashSet<tbInsumosPorActividades>();
            tbPresupuestosDetalle = new HashSet<tbPresupuestosDetalle>();
            tbReferenciasCeldas = new HashSet<tbReferenciasCeldas>();
            tbRentaMaquinariasPorActividades = new HashSet<tbRentaMaquinariasPorActividades>();
        }

        public int acet_Id { get; set; }
        public string acet_Observacion { get; set; }
        public int? acet_Cantidad { get; set; }
        public int? espr_Id { get; set; }
        public int? empl_Id { get; set; }
        public DateTime? acet_FechaInicio { get; set; }
        public DateTime? acet_FechaFin { get; set; }
        public decimal? acet_PrecioManoObraEstimado { get; set; }
        public decimal? acet_PrecioManoObraFinal { get; set; }
        public int? acti_Id { get; set; }
        public int? unme_Id { get; set; }
        public int? etpr_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? acet_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? acet_FechaModificacion { get; set; }
        public bool? acet_Estado { get; set; }
        [NotMapped]
        public int copc_Id { get; set; }

        [NotMapped]
        public string espr_Descripcion { get; set; }
        [NotMapped]
        public int proy_Id { get; set; }
        [NotMapped]
        public string proy_Descripcion { get; set; }
        [NotMapped]
        public string proy_Nombre { get; set; }
        [NotMapped]
        public string empl_NombreCompleto { get; set; }
        [NotMapped]
        public int etap_Id { get; set; }

        [NotMapped]
        public string etap_Descripcion { get; set; }
        [NotMapped]
        public string acti_Descripcion { get; set; }
        [NotMapped]
        public string unme_Nombre { get; set; }
        [NotMapped]
        public string unme_Nomenclatura { get; set; }
        [NotMapped]
        public decimal acet_CostoInsumos { get; set; }
        [NotMapped]
        public decimal acet_CostoMaquinaria { get; set; }
        [NotMapped]
        public decimal acet_CostoEquipoSeguridad { get; set; }
        [NotMapped]
        public decimal acet_Progreso { get; set; }

        [NotMapped]
        public int row { get; set; }
        [NotMapped]
        public int incidentes { get; set; }

        public virtual tbActividades acti { get; set; }
        public virtual tbEmpleados empl { get; set; }
        public virtual tbEstadosProyectos espr { get; set; }
        public virtual tbEtapasPorProyectos etpr { get; set; }
        public virtual tbUnidadesMedida unme { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbComprasDetallesDireccionesPorMaquinaria> tbComprasDetallesDireccionesPorMaquinaria { get; set; }
        public virtual ICollection<tbControlDeCalidadesPorActividades> tbControlDeCalidadesPorActividades { get; set; }
        public virtual ICollection<tbEquiposSeguridadPorActividades> tbEquiposSeguridadPorActividades { get; set; }
        public virtual ICollection<tbGestionesAdicionales> tbGestionesAdicionales { get; set; }
        public virtual ICollection<tbIncidenciasPorActividades> tbIncidenciasPorActividades { get; set; }
        public virtual ICollection<tbIncidentes> tbIncidentes { get; set; }
        public virtual ICollection<tbInsumosPorActividades> tbInsumosPorActividades { get; set; }
        public virtual ICollection<tbPresupuestosDetalle> tbPresupuestosDetalle { get; set; }
        public virtual ICollection<tbReferenciasCeldas> tbReferenciasCeldas { get; set; }
        public virtual ICollection<tbRentaMaquinariasPorActividades> tbRentaMaquinariasPorActividades { get; set; }
    }
}