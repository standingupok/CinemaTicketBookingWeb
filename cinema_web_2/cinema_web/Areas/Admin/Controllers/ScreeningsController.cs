using cinema_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ScreeningsController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public ScreeningsController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Screening> lstScreenings = dbContext.Screenings.ToList();
            return View(lstScreenings);
        }

        public IActionResult Create()
        {
            Screening screening = new Screening();
            return View(screening);
        }
        [BindProperty]
        public Screening Screening { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                dbContext.Screenings.Add(Screening);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var ScreeningToDelete = dbContext.Screenings.FirstOrDefault(u => u.ScreeningId == id);
            if (ScreeningToDelete != null)
            {
                dbContext.Screenings.Remove(ScreeningToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            // Tìm Screening cần chỉnh sửa từ cơ sở dữ liệu
            Screening = dbContext.Screenings.FirstOrDefault(Screening => Screening.ScreeningId == id);
            if (Screening != null)
            {
                return View(Screening);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Screening = dbContext.Screenings.FirstOrDefault(Screening => Screening.ScreeningId == id);
            if (Screening != null)
            {
                return View(Screening);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Screenings");
            }

            if (ModelState.IsValid)
            {
                dbContext.Update(Screening);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "Screenings");
        }
    }
}
