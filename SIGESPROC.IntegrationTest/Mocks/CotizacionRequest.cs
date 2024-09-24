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
using SIGESPROC.Common.Models.ModelsInsumo;

namespace SIGESPROC.UnitTest.Mocks
{
    public class CotizacionRequest
    {
        public CotizacionDetalleViewModel GetSampleCotizacionRequest()
        {
            return new CotizacionDetalleViewModel {
                code_Id = 440,
                coti_Id = 150,
                code_Cantidad = 1,
                code_PrecioCompra = 2000,
                usua_Modificacion = 3,
                code_FechaModificacion = DateTime.Now
            };
        }
    }
}
