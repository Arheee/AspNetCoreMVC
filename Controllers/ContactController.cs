using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TpAspNetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.Message = "Votre liste de contacts ";
            return View();
        }

      
        public ActionResult Afficher()
        {
            ViewData["Contact"] = "Nicolas Durée";
            return View();
        }

      
        public ActionResult Ajouter()
        {
            ViewBag.Instruction = "Ici un Form pour ajouter un nouveau contact ";
            return View();
        }
    }
}
