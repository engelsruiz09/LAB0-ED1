using LAB0_ED1_G.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace LAB0_ED1_G.Controllers
{
    
    public class ClienteController : Controller
    {
        //GET: 
        [Route("Client")]//enrutado a /Client--Ojo con el Camel Case
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClienteList);
        }
        //GET:clientecontroller/create
        [Route("Client/Create")]//enrutado a /Client/Create --Ojo con el Camel Case
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection FC) //aqui va a recibir los campos para crear al nuevo cliente
        {
            try
            {
                var elnuevocliente = new Models.Cliente 
                {
                    Nombre = FC["Nombre"],
                    Apellido = FC["Apellido"],
                    telefono = Convert.ToInt32(FC["Telefono"]),
                    Descripcion = FC["Descripcion"]
                };
                Singleton.Instance.ClienteList.Add(elnuevocliente);
                return RedirectToAction(nameof(Index)); //construye una URL de redireccionamiento a una acción/controlador específico en su aplicación y utiliza la tabla de rutas para generar la URL correcta.

            }
            catch
            {

                return View();
            }
        }
    }
}
