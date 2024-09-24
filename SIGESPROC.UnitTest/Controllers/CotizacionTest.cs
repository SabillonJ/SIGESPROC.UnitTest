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
using Microsoft.VisualStudio.TestTools.UnitTesting; // Framework para pruebas unitarias.
using SIGESPROC.Common.Models.ModelsInsumo;
using SIGESPROC.UnitTest.Mocks; // Mocks para simular comportamientos en pruebas.
using Moq; // Biblioteca para crear objetos simulados.
using SIGESPROC.DataAccess.Repositories.RepositoryInsumo;

/// <summary>
/// Clase de prueba para el controlador de cotización.
/// </summary>
[TestClass]
public class CotizacionTest
{
    private InsumoService _insumoService;
    public static IMapper _mapper;

    public List<CotizacionViewModel> cotizacionViewModel { get; set; }
    /// <summary>
    /// Método que se ejecuta antes de cada prueba para configurar el entorno de prueba.
    /// </summary>
    [TestInitialize]
    public void Setup()
    {
        // Creación de mocks para los repositorios necesarios
        var cotizacionDetalleRepositoryMock = new Mock<CotizacionDetalleRepository>();
        var cotizacionRepositoryMock = new Mock<CotizacionRepository>();
        var insumoPorMedidaRepositoryMock = new Mock<InsumoPorMedidaRepository>();
        var insumoPorProveedorRepositoryMock = new Mock<InsumoPorProveedorRepository>();
        var insumoRepositoryMock = new Mock<InsumoRepository>();
        var materialRepositoryMock = new Mock<MaterialRepository>();
        var proveedorRepositoryMock = new Mock<ProveedorRepository>();
        var bodegaRepositoryMock = new Mock<BodegaRepository>();
        var bodegaPorInsumoRepositoryMock = new Mock<BodegaPorInsumoRepository>();
        var compraEncabezadoRepositoryMock = new Mock<CompraEncabezadoRepository>();
        var maquinariaRepositoryMock = new Mock<MaquinariaRepository>();
        var maquinariaPorProveedorRepositoryMock = new Mock<MaquinariaPorProveedorRepository>();
        var subCategoriaRepositoryMock = new Mock<SubCategoriaRepository>();
        var compraDetalleRepositoryMock = new Mock<CompraDetalleRepository>();
        var cotizacionPorDocumentoRepositoryMock = new Mock<CotizacionPorDocumentoRepository>();

        // Inicialización del servicio con los mocks
        _insumoService = new InsumoService(
            cotizacionDetalleRepositoryMock.Object,
            cotizacionRepositoryMock.Object,
            insumoPorMedidaRepositoryMock.Object,
            insumoPorProveedorRepositoryMock.Object,
            insumoRepositoryMock.Object,
            materialRepositoryMock.Object,
            proveedorRepositoryMock.Object,
            bodegaRepositoryMock.Object,
            bodegaPorInsumoRepositoryMock.Object,
            compraEncabezadoRepositoryMock.Object,
            maquinariaRepositoryMock.Object,
            maquinariaPorProveedorRepositoryMock.Object,
            subCategoriaRepositoryMock.Object,
            compraDetalleRepositoryMock.Object,
            cotizacionPorDocumentoRepositoryMock.Object
        );

        // Configuración de AutoMapper
        var config = new MapperConfiguration(cfg =>
        {
            // Aquí se pueden agregar configuraciones de mapeo
        });
        _mapper = config.CreateMapper(); // Crear el mapper
    }

    /// <summary>
    /// Prueba para verificar la funcionalidad de listar cotizaciones.
    /// </summary
    [TestMethod]
    public void ListarCotizacion()
    {
        // Instanciar el controlador de cotización
        CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
        // Llamar al método para listar cotizaciones
        var result = cotizacionController.ListarCotizacion();
        // Afirmar que el resultado no es nulo
        Assert.IsNotNull(result);
        // Afirmar que el resultado es del tipo IActionResult
        Assert.IsInstanceOfType(result, typeof(IActionResult));
    }

    /// <summary>
    /// Prueba para verificar la funcionalidad de insertar una cotización.
    /// </summary>
    [TestMethod]
    public void InsertarCotizacion()
    {
        // Crear una solicitud de cotización
        CotizacionRequest cotizacionRequest = new CotizacionRequest();
        // Obtener una lista de cotizaciones de muestra
        List<CotizacionViewModel> cotizacionViewModelList = cotizacionRequest.GetSampleCotizacionRequest();
        // Afirmar que la lista de cotizaciones no es nula
        Assert.IsNotNull(cotizacionViewModelList, "La lista de CotizacionViewModel no puede ser nula");
        // Instanciar el controlador de cotización
        CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
        // Llamar al método para crear la cotización
        var result = cotizacionController.Create(cotizacionViewModelList);
        // Afirmar que el resultado no es nulo
        Assert.IsNotNull(result);
        // Afirmar que el resultado es del tipo IActionResult
        Assert.IsInstanceOfType(result, typeof(IActionResult));
    }
}
//@ -0,0 + 1,48 @@
//﻿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SIGESPROC.Common.Models;
//using SIGESPROC.BusinessLogic.Services.ServiceInsumo;
//using SIGESPROC.API.Controllers;
//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using SIGESPROC.API.Controllers.ControllersInsumo;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SIGESPROC.Common.Models.ModelsInsumo;
//using SIGESPROC.UnitTest.Mocks;

//namespace SIGESPROC.UnitTest.Controllers
//{
//    [TestClass]
//    public class CotizacionTest
//    {
//        private InsumoService _insumoService;
//        public static IMapper _mapper;

//        public List<CotizacionViewModel> cotizacionViewModel { get; set; }

//        [TestMethod]

//        public void ListarCotizacion()
//        {
//            CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
//            var result = cotizacionController.ListarCotizacion();
//            Assert.IsNotNull(result);
//            Assert.IsInstanceOfType(result, typeof(IActionResult));
//        }


//        [TestMethod]
//        public void InsertarCotizacion()
//        {
//            CotizacionRequest cotizacionRequest = new CotizacionRequest();
//            List<CotizacionViewModel> cotizacionViewModelList = cotizacionRequest.GetSampleCotizacionRequest();
//            CotizacionController cotizacionController = new CotizacionController(_insumoService, _mapper);
//            var result = cotizacionController.Create(cotizacionViewModelList);
//            Assert.IsNotNull(result);
//            Assert.IsInstanceOfType(result, typeof(IActionResult));
//        }
//    }
//}