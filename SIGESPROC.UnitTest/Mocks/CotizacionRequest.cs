using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESPROC.Common.Models;
using SIGESPROC.BusinessLogic.Services.ServiceInsumo;
using SIGESPROC.API.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIGESPROC.API.Controllers.ControllersInsumo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIGESPROC.Common.Models.ModelsInsumo;

namespace SIGESPROC.UnitTest.Mocks
{
    public class CotizacionRequest
    {
        public List<CotizacionViewModel> GetSampleCotizacionRequest()
        {
            return new List<CotizacionViewModel>
        {
            new CotizacionViewModel
            {
                coti_Id = 150,
                prov_Id = 63,
                coti_Fecha = DateTime.Now,
                empl_Id = 2,
                coti_Incluido = false,
                coti_CompraDirecta = false,
                usua_Creacion = 3, 
                check = true, 
                code_Cantidad = 10, 
                code_PrecioCompra = 2000,
                cime_Id = 2, 
                cime_InsumoOMaquinariaOEquipoSeguridad = 2, 
                code_Renta = 1
            }
        };
        }
    }


}
