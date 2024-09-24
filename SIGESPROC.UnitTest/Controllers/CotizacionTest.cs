using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESPROC.Common.Models;
using SIGESPROC.BusinessLogic.Services.ServiceInsumo;
using SIGESPROC.BusinessLogic.Services.ServicePlanilla;
using SIGESPROC.BusinessLogic.Services.ServiceGeneral;
using SIGESPROC.BusinessLogic.Services.ServiceProyecto;

using SIGESPROC.API.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIGESPROC.API.Controllers.ControllersInsumo;
using SIGESPROC.API.Controllers.ControllersPlanilla;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIGESPROC.Common.Models.ModelsInsumo;
using SIGESPROC.UnitTest.Mocks;
using SIGESPROC.BusinessLogic.Services.GeneralService;

namespace SIGESPROC.UnitTest.Controllers
{
    [TestClass]
    public class CotizacionTest
    {
        private InsumoService _insumoService;
        private PlanillaService _planillaService;
        private FrecuenciaService _frecuenciaService;
        private PrestamoService _prestamoService;
        private DeduccionService _deduccionService;
        private GeneralService _generalService;



        public static IMapper _mapper;

        public List<CotizacionViewModel> cotizacionViewModel { get; set; }

        [TestMethod]

        public void ListarCotizacion()
        {
            CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
            var result = cotizacionController.ListarCotizacion();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IActionResult));
        }

        [TestMethod]

        public void ListarPlanilla()
        {
            PlanillaController planillaController = new PlanillaController(_planillaService, _mapper, _generalService, _frecuenciaService, _prestamoService, _deduccionService);
            var result = planillaController.ListarPlanilla();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IActionResult));
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
