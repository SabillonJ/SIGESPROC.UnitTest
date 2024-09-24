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
using SIGESPROC.UnitTest.Mocks;

namespace SIGESPROC.UnitTest.Controllers
{
    [TestClass]
    public class CotizacionTest
    {
        private InsumoService _insumoService;
        public static IMapper _mapper;

        public List<CotizacionViewModel> cotizacionViewModel { get; set; }

        [TestMethod]

        public void ListarCotizacion()
        {
            CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
            var result = cotizacionController.ListarCotizacion();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof (IActionResult));
        }


        [TestMethod]
        public void InsertarCotizacion()
        {
            CotizacionRequest cotizacionRequest = new CotizacionRequest();
            List<CotizacionViewModel> cotizacionViewModelList = cotizacionRequest.GetSampleCotizacionRequest();
            CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
            var result = cotizacionController.Create(cotizacionViewModelList);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IActionResult));
        }
    }
}
