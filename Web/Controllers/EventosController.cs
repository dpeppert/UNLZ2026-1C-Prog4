using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class EventosController : Controller
    {
        List<EventoVM> lista = new List<EventoVM>();

        public EventosController() {
            EventoVM evento = new EventoVM();
            evento.FechaEvento = DateTime.Now;
            evento.NombreEvento = "Argentina  - Zambia";
            evento.IdEvento = 2;
            lista.Add(new EventoVM { FechaEvento = DateTime.Now, IdEvento = 1, NombreEvento = "Maria Becerra" });
            lista.Add(evento);
        }
        // GET: EventosController
        public ActionResult Index()
        {
            

            return View(lista);
        }

        // GET: EventosController/Details/5
        public ActionResult Details(int id)
        {
            var evento = this.lista.First(x => x.IdEvento == id);
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
        public ActionResult Create(EventoVM collection)
        {
            try
            {
                
                this.lista.Add(collection);

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
            var evento = this.lista.First(x => x.IdEvento == id);

            return View(evento);
        }

        // POST: EventosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromBody]EventoVM asd )
        {
            try
            {
                EventoVM evento = this.lista.First(x => x.IdEvento == id);
                evento.FechaEvento = asd.FechaEvento;
                evento.NombreEvento = asd.NombreEvento;
                

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

            EventoVM evento = new EventoVM();
            evento.FechaEvento = DateTime.Now;
            evento.NombreEvento = "Argentina  - Zambia";
            evento.IdEvento = 2;
            return View("Borrar" , evento);
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
