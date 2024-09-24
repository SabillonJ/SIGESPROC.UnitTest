using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using SIGESPROC.BusinessLogic.Services.ServiceInsumo;
using SIGESPROC.UnitTest.Mocks;
using Microsoft.AspNetCore.Mvc;
using SIGESPROC.API.Controllers.ControllersInsumo;
using SIGESPROC.Common.Models.ModelsInsumo;
using SIGESPROC.DataAccess.Repositories.RepositoryInsumo;

namespace SIGESPROC.IntegrationTest.Controllers
{
    [TestClass]
    public class CoticacionTest
    {
        private InsumoService _insumoService;
        public static IMapper _mapper;
        private CotizacionRequest _cotizacionRequest;

        [TestInitialize]
        public void Setup()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap <CotizacionRequest, CotizacionDetalleViewModel>();
            });

            _mapper = config.CreateMapper();
            _insumoService = new InsumoService(cotizacionDetalleRepository: new CotizacionDetalleRepository());
            _cotizacionRequest = new CotizacionRequest();
        }

        [TestMethod]
        public void EditarCotizacionTest()
        {
            CotizacionDetalleController cotizacionDetalleController = new CotizacionDetalleController(_insumoService, _mapper);
            CotizacionDetalleViewModel cotizacionOriginal = _cotizacionRequest.GetSampleCotizacionRequest();

            int cantidad = 3;
            decimal precioCompra = 5500;
            cotizacionOriginal.code_Cantidad = cantidad;
            cotizacionOriginal.code_PrecioCompra = precioCompra;

            var result = cotizacionDetalleController.Update(cotizacionOriginal);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IActionResult));

            var cotizacionActualizada = _insumoService.BuscarCotizacionDetalle(cotizacionOriginal.code_Id);
            Assert.AreEqual(cantidad, cotizacionActualizada.Data.code_Cantidad);
            Assert.AreEqual(precioCompra, cotizacionActualizada.Data.code_PrecioCompra);
        }
    }
}
