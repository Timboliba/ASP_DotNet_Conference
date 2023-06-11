using Conference.Models;
using Conference.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class HomeController : Controller
    {
        DataEntities entities = new DataEntities();
        public UnitOfWork<Lieu> unitLieu;
        public UnitOfWork<Participant> unitParticipant;
        public HomeController()
        {
            this.unitLieu = new UnitOfWork<Lieu>();
            this.unitParticipant = new UnitOfWork<Participant>();
        }
        // GET: Home
        public ActionResult Index()
        {
            var model = unitLieu.Entity.GetAll().First();
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        // GET: Conference
        public ActionResult Conference()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            var model = unitParticipant.Entity.GetAll().First();
            return View(model);
        }
        public ActionResult SignIn()
        {
            Participant p = new Participant();
            return View(p);
        }

        [HttpPost]
        protected ActionResult SignIn(Participant p)
        {
            if (ModelState.IsValid)
            {
                // Effectuez les opérations nécessaires, par exemple :
                // - Stockez les données dans une base de données
                // - Envoyez un e-mail de confirmation, etc.

                Console.WriteLine(p.Nom +" "+p.password);

                /*unitParticipant.Save();
                                            */
                // Redirigez vers une page de succès ou une autre action
                return RedirectToAction("Index");
            }
            return View(p);
        }

    }
}