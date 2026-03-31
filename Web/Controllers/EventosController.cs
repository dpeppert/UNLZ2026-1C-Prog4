using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class EventosController : Controller
    {
        // GET: EventosController
        public ActionResult Index()
        {
            List<EventoVM> lista = new List<EventoVM>();
            EventoVM evento = new EventoVM();
            evento.FechaEvento = DateTime.Now;
            evento.NombreEvento = "Argetina  - Zambia";
            evento.IdEvento = 2;
            lista.Add(new EventoVM { FechaEvento = DateTime.Now, IdEvento = 1, NombreEvento = "Maria Becerra" });
            lista.Add(evento);

            return View(lista);
        }

        // GET: EventosController/Details/5
        public ActionResult Details(int id)
        {
            EventoVM evento = new EventoVM();
            evento.FechaEvento = DateTime.Now;
            evento.NombreEvento = "Argetina  - Zambia";
            evento.IdEvento = 2;
            return View(evento);
        }

        // GET: EventosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventosController/Edit/5
        public ActionResult Edit(int id)
        {

            EventoVM evento = new EventoVM();
            evento.FechaEvento = DateTime.Now;
            evento.NombreEvento = "Argetina  - Zambia";
            evento.IdEvento = 2;
            return View(evento);
        }

        // POST: EventosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
