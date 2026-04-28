using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class EventosController : Controller
    {
        List<EventoVM> lista = new List<EventoVM>();
        private AppDbContext _context;

        public EventosController( AppDbContext context ) {
            _context = context;
        }
        // GET: EventosController
        public ActionResult Index()
        {
            lista = _context.Eventos.ToList();

            return View(lista);
        }

        // GET: EventosController/Details/5
        public ActionResult Details(int id)
        {
            var evento = _context.Eventos.First(x => x.IdEvento == id);
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
        public ActionResult Create(EventoVM evento)
        {
            try
            {
                evento.IdEvento = 0;
                _context.Eventos.Add(evento);

                _context.SaveChanges();

               if (1 == 1)
                {

                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventosController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var evento = _context.Eventos.First(x => x.IdEvento == id);

            return View(evento);
        }

        // POST: EventosController/Edit/5
        [HttpPost("/Eventos/Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(IFormCollection collection)
        {
            try
            {
                int idEvento = int.Parse(collection["IdEvento"]);
                EventoVM evento = _context.Eventos.First(x => x.IdEvento == idEvento);
                evento.FechaEvento = new DateTime();// collection["FechaEvento"]);
                evento.NombreEvento = collection["NombreEvento"];

                _context.SaveChanges();

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
                EventoVM evento = _context.Eventos.First(x => x.IdEvento == id);
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
