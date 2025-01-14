using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TpAspNetCoreMVC.Models;

namespace TpAspNetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        static List<ContactModel> Contacts = new List<ContactModel>() {
            new ContactModel { Id = 1, Nom = "Dupont", Prenom = "Jean", Email = "jean.dupont@example.com" },
            new ContactModel { Id = 2, Nom = "Durand", Prenom = "Claire", Email = "claire.durand@example.com" },
            new ContactModel { Id = 3, Nom = "Martin", Prenom = "Luc", Email = "luc.martin@example.com" }
       };
       
        public ActionResult Index()
        {
            ViewBag.Contacts = Contacts;
            return View();
        }

      
        public ActionResult Afficher(int id)
        {
            var contact = Contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["Contact"] = contact;
            return View();
        }


        [HttpGet]
        public ActionResult Ajouter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ajouter(ContactModel newContact)
        {
            return View();
        }
    }
}
