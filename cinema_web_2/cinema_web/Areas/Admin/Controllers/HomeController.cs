using cinema_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public HomeController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts");
            var account = dbContext.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taiKhoanId));
            if (account == null) return NotFound();

            return View(account);
        }
    }
}
