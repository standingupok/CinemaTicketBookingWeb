using cinema_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ScreeningFilmsController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public ScreeningFilmsController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<ScreeningFilm> lstScreeningFilms = dbContext.ScreeningFilms.ToList();
            return View(lstScreeningFilms);
        }

        public IActionResult Create()
        {
            ScreeningFilm screeningfilm = new ScreeningFilm();

            List<Screening> screenings = dbContext.Screenings.ToList();
            ViewBag.Screenings = screenings;
            List<Film> films = dbContext.Films.Where(film => film.IsFilming).ToList();

            ViewBag.Films = films;

            return View(screeningfilm);
        }

        [BindProperty]
        public ScreeningFilm ScreeningFilm { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                ScreeningFilm.Screening = dbContext.Screenings.First(screen => screen.ScreeningId == ScreeningFilm.ScreeningId);
                ScreeningFilm.Film = dbContext.Films.First(film => film.FilmId == ScreeningFilm.FilmId);
                dbContext.ScreeningFilms.Add(ScreeningFilm);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int filmId, int screeningId)
        {
            var screeningFilmToDelete = dbContext.ScreeningFilms.FirstOrDefault(sf => sf.FilmId == filmId && sf.ScreeningId == screeningId);
            if (screeningFilmToDelete != null)
            {
                dbContext.ScreeningFilms.Remove(screeningFilmToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int filmId, int screeningId)
        {
            // Tìm Film cần chỉnh sửa từ cơ sở dữ liệu
            ScreeningFilm = dbContext.ScreeningFilms.FirstOrDefault(sf => sf.FilmId == filmId && sf.ScreeningId == screeningId);
            if (ScreeningFilm != null)
            {
                return View(ScreeningFilm);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int filmId, int screeningId)
        {
            ScreeningFilm = dbContext.ScreeningFilms.FirstOrDefault(sf => sf.FilmId == filmId && sf.ScreeningId == screeningId);
            if (ScreeningFilm != null)
            {
                List<Screening> screenings = dbContext.Screenings.ToList();
                ViewBag.Screenings = screenings;
                List<Film> films = dbContext.Films.ToList();
                ViewBag.Films = films;

                return View(ScreeningFilm);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? filmId, int? screeningId)
        {
            if (filmId == null || screeningId == null)
            {
                
                return RedirectToAction("Index", "ScreeningFilms");
                 
            }
            
            if (ModelState.IsValid)
            {
                ScreeningFilm.Screening = dbContext.Screenings.FirstOrDefault(screen => screen.ScreeningId == ScreeningFilm.ScreeningId);
                ScreeningFilm.Film = dbContext.Films.FirstOrDefault(film => film.FilmId == ScreeningFilm.FilmId);
                dbContext.Update(ScreeningFilm);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "ScreeningFilms");
        }
    }
}
