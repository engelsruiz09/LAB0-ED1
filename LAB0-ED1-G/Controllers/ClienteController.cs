using Microsoft.AspNetCore.Mvc;

namespace LAB0_ED1_G.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection FC)
        {
            try
            {
                Nombre = FC["Nombre"];
                Apellido = FC["Apellido"];
                Telefono = FC["Telefono"];
                Descripcion = FC["Descripcion"];
            }
            catch 
            {

                throw;
            }
        }
    }
}
