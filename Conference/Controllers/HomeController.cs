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
        private DataEntities entity = new DataEntities();
        private UnitOfWork<Participant> unitParticipant;
        private UnitOfWork<Congre> unitCongre;

        public HomeController()
        {
            this.unitParticipant = new UnitOfWork<Participant>();
            this.unitCongre = new UnitOfWork<Congre>();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
      
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            Participant model = new Participant();
            //var model = unitParticipant.Entity.GetAll().First();
            return View(model);
        }

        // Authentication
        [HttpPost]
        public ActionResult Login(Participant p)
        {
            var model = unitParticipant.Entity.GetAll().ToList();
            if (p.Nom != null && p.Password != null)
            {
                foreach (Participant part in model)
                {
                    if (p.Nom == part.Nom && p.Password == part.Password)
                    {
                        Session["user"] = p;
                        return RedirectToAction("Index");
                    }
                }
                return View();

            }
            return View(p);
        }

        public ActionResult SignIn()
        {
            Participant p = new Participant();
            return View(p);
        }

        // Registration
        [HttpPost]
        public ActionResult SignIn(Participant p)
        {
            
            if (p.Nom != null && p.Password != null)
            {
                p.Role = "user";
                entity.Participants.Add(p);
                entity.SaveChanges();
                return RedirectToAction("Contact");
            }
            return View(p);
        }

        public ActionResult AddConference()
        {
            Congre c = new Congre();
            return View(c);
        }
        [HttpPost]
        public ActionResult AddConference(Congre c)
        {
            
            if(c.titre!=null && c.Lieu!=null && c.Details!=null && c.DateDebut!=null && c.DateFin != null)
            {
                entity.Congres.Add(c);
                entity.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult GetConference()
        {
            var model = unitCongre.Entity.GetAll().ToList();
            ViewBag.ListCongres = model;
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
