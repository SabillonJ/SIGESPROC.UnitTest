using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIGESPROC.BusinessLogic.Services.ServiceAcceso;
using SIGESPROC.Common.Models.ModelsAcceso;
using SIGESPROC.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGESPROC.API.Controllers.ControllersAcceso
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly AccesoService _accesoService;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;

        public UsuarioController(AccesoService accesoService, IMapper mapper, IMailService mailService)
        {
            _mapper = mapper;
            _accesoService = accesoService;
            _mailService = mailService;
        }

        [HttpDelete("Eliminar")]
        public IActionResult Eliminar(int? id, string name)
        {
            // Aquí podrías manejar la observación si es necesario
            var result = _accesoService.EliminarUsuario(id, name);

            return Ok(result);
        }

        [HttpGet("RestablecerContraWebb/{usua_Id}/{empl_Correo}")]
        public IActionResult RestablecerContraWeb(int usua_Id, string empl_Correo)
        {
            var result = _accesoService.InsertarCodigoRestablecer(usua_Id);
            var resu = result.Data.Message;

            var reultNuevo = EnviarCorreo(empl_Correo, int.Parse(resu));

            result.Success = reultNuevo;

            return Ok(result);
        }

        [HttpGet("EnviarCorreo/{correo_usuario}/{codigo}")]
        public Boolean EnviarCorreo(string correo_usuario, int codigo)
        {

            MailData mailData = new MailData();
            mailData.EmailToId = correo_usuario;
            mailData.EmailToName = "Usuario";
            mailData.EmailSubject = "Codigo de Verificación";
            mailData.EmailBody = "" + codigo.ToString();
            var result = _mailService.SendMail(mailData);
            return result;

        }

        [HttpGet("VerificarCodigoReestablecerWeb/{usua_Id}/{codigo}")]
        public IActionResult VerificarCodigoReestablecerWeb(int usua_Id, int codigo)
        {
            var result = _accesoService.VerificarCodigoReestablecer(usua_Id, codigo);

            return Ok(result);
        }

        //[HttpPost("Buscar")]
        //public IActionResult Buscar(int? id)
        //{
        //    var usuario = _accesoService.BuscarUsuario(id);

        //    return Ok(usuario);
        //}

        [HttpGet("Buscar/{id}")]
        public IActionResult Buscar(int id)
        {
            var usuario = _accesoService.BuscarUsuario(id);

            return Ok(usuario);
        }


        [HttpGet("InicioSesion/{user}/{clave}")]
        public IActionResult InicioSesion(string user, string clave)
        {
            var usuario = _accesoService.InicioSesionUsuario(user, clave);

            return Ok(usuario.Data);
        }


        [HttpGet("RestablecerFlutter/{user}/{clave}/{nuevaclave}")]
        public IActionResult RestablecerFlutter(string user, string clave, string nuevaclave)
        {
            var usuario = _accesoService.RestablecerFlutter(user, clave, nuevaclave);
            
            return Ok(usuario);
        }


        [HttpGet("RestablecerCorreo/{user}/{correo}")]
        public IActionResult RestablecerCorreo(string user, string correo)
        {
            var usuario = _accesoService.RestablecerCorrero(user, correo);


            return Ok(usuario);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(UsuarioViewModel UsuarioViewModel)
        {
            var modelo = new tbUsuarios()
            {
                usua_Usuario = UsuarioViewModel.usua_Usuario,
                usua_Clave = UsuarioViewModel.usua_Clave,
                usua_EsAdministrador = UsuarioViewModel.usua_EsAdministrador,
                role_Id = UsuarioViewModel.role_Id,
                empl_Id = UsuarioViewModel.empl_Id,
                usua_Creacion = UsuarioViewModel.usua_Creacion,
                usua_FechaCreacion = DateTime.Now
            };

            var result = _accesoService.InsertarUsuario(modelo);

            return Ok(result);
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var list = _accesoService.ListarUsuarios();

            return Ok(list.Data);
        }

        [HttpGet("ListarNotificacion")]
        public IActionResult ListarNotificaciones()
        {
            var list = _accesoService.ListarUsuariosMotificaciones();

            return Ok(list.Data);
        }

        [HttpPut("Reestablecer")]
        public IActionResult Reestablecer(UsuarioViewModel UsuarioViewModel)
        {
            var modelo = new tbUsuarios()
            {
                usua_Id = UsuarioViewModel.usua_Id,
                usua_Clave = UsuarioViewModel.usua_Clave,
            };

            var result = _accesoService.ReestablecerUsuario(modelo);

            return Ok(result);
        }

        [HttpPut("Actualizar")]
        public IActionResult Actualizar(UsuarioViewModel UsuarioViewModel)
        {
            var modelo = new tbUsuarios()
            {
                usua_Id = UsuarioViewModel.usua_Id,
                usua_Usuario = UsuarioViewModel.usua_Usuario,
                usua_Clave = UsuarioViewModel.usua_Clave,
                usua_EsAdministrador = UsuarioViewModel.usua_EsAdministrador,
                role_Id = UsuarioViewModel.role_Id,
                empl_Id = UsuarioViewModel.empl_Id,
                usua_Modificacion = UsuarioViewModel.usua_Modificacion,
                usua_FechaModificacion = DateTime.Now
            };

            var result = _accesoService.ActualizarUsuario(modelo);

            return Ok(result);
        }
    }
}
