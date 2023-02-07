using LAB0_ED1_G.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace LAB0_ED1_G.Controllers
{
    
    public class ClienteController : Controller
    {
        //GET: 
        public ActionResult Index()
        {
            return View(Singleton.Instance.listaclientes);
        }
        //GET:clientecontroller/create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(IFormCollection FC) //aqui va a recibir los campos para crear al nuevo cliente
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
                Singleton.Instance.listaclientes.Add(elnuevocliente);
                return RedirectToAction(nameof(Index)); //construye una URL de redireccionamiento a una acción/controlador específico en su aplicación y utiliza la tabla de rutas para generar la URL correcta.

            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult SortN()
        {
            Singleton.Instance2.Sort.OrdenamientoN(Singleton.Instance.listaclientes);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult SortL()
        {
            Singleton.Instance2.Sort.OrdenamientoA(Singleton.Instance.listaclientes);
            return RedirectToAction(nameof(Index));
        }
    }
}
