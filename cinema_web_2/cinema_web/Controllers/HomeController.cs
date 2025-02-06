using cinema_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace cinema_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CinemaDbContext dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CinemaDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            
            IEnumerable<Film> lstFilms = dbContext.Films.ToList();
            var filmingFilms = dbContext.Films.Where(f => f.IsFilming == true).ToList();
            var upComingFilms = dbContext.Films.Where(f => f.IsFilming == false).ToList();
            ViewData["FilmingFilms"] = filmingFilms;
            ViewData["UpComingFilms"] = upComingFilms;
            return View(lstFilms);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [BindProperty]
        public Film Film { get; set; }
        public IActionResult Details(int id)
        {
            Film = dbContext.Films.FirstOrDefault(film => film.FilmId == id);
            if (Film != null)
            {
                
                return View(Film);
            }
            return RedirectToAction("Index");
        }

        public IActionResult BuyTicket(int id)
        {
            var film = dbContext.Films.FirstOrDefault(f => f.FilmId == id);
            var selectedFilmId = id;
            var ticketModel = new Ticket { FilmId = film.FilmId, FilmName = film.FilmName }; // Chú ý thêm thuộc tính FilmName vào model Ticket
            /*
            TempData["SelectedFilmId"] = id;
            */
            return RedirectToAction("Book", "Tickets", new { Area = "Admin", selectedFilmId = id });
        }
    }
}
