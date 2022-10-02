using Microsoft.AspNetCore.Mvc;
using Pro_Esthetic_CRUDCore.Datos;
using Pro_Esthetic_CRUDCore.Models;

namespace Pro_Esthetic_CRUDCore.Controllers
{
    public class MantenedorController : Controller
    {
        UsuariosDatos _UsuariosDatos = new UsuariosDatos();
        public IActionResult Listar()
        {
            //La vista mostrara una lista de contactos
            var oLista = _UsuariosDatos.Listar();

            return View(oLista);
        }
        public IActionResult Guardar()
        {
            //Metodo solo devuelve la vista
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(UsuariosModel oUsuario)
        {
            //Metodo recibe el objeto para guardarlo en BD
            if (!ModelState.IsValid)
                return View();

            var respuesta = _UsuariosDatos.Guardar(oUsuario);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Editar(int IdUsuario)
        {
            //Metodo solo devuelve la vista
            var oUsuario = _UsuariosDatos.Obtener(IdUsuario);
            return View(oUsuario);
        }
        [HttpPost]
        public IActionResult Editar(UsuariosModel oUsuario)
        {
            //Metodo recibe el objeto para guardarlo en BD
            if (!ModelState.IsValid)
                return View();

            var respuesta = _UsuariosDatos.Editar(oUsuario);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Eliminar(int IdUsuario)
        {
            //Metodo solo devuelve la vista
            var oUsuario = _UsuariosDatos.Obtener(IdUsuario);
            return View(oUsuario);
        }
        [HttpPost]
        public IActionResult Eliminar(UsuariosModel oUsuario)
        {
            //Metodo recibe el objeto para eliminar en BD
            var respuesta = _UsuariosDatos.Eliminar(oUsuario.IdUsuario);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
