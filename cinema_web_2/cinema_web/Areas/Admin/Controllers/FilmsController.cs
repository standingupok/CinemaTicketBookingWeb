using cinema_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FilmsController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public FilmsController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Film> lstFilms = dbContext.Films.ToList();
            return View(lstFilms);
        }
        public IActionResult test()
        {
            return View();
        }
        public IActionResult Create()
        {
            Film film = new Film();
            return View(film);
        }
        [BindProperty]
        public Film Film { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                dbContext.Films.Add(Film);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var filmToDelete = dbContext.Films.FirstOrDefault(u => u.FilmId == id);
            if (filmToDelete != null)
            {
                dbContext.Films.Remove(filmToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            // Tìm Film cần chỉnh sửa từ cơ sở dữ liệu
            Film = dbContext.Films.FirstOrDefault(Film => Film.FilmId == id);
            if (Film != null)
            {
                return View(Film);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Film = dbContext.Films.FirstOrDefault(Film => Film.FilmId == id);
            if (Film != null)
            {
                return View(Film);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Films");
            }

            if (ModelState.IsValid)
            {
                dbContext.Update(Film);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "Films");
        }
    }
}
