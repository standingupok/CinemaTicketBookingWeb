using cinema_web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Net.Mail;
using System.Net;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TicketsController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public TicketsController(CinemaDbContext dbContext)
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

            List<Ticket> CinemaDbContext = new List<Ticket>();

            if(account.RoleId == 1)
            {
                CinemaDbContext = dbContext.Tickets.Include(t => t.Account).Include(t => t.Screening).ToList();

            }
            else
            {
                CinemaDbContext = dbContext.Tickets.Include(t => t.Account).Include(t => t.Screening).Where(x=> x.AccountId == account.AccountId).ToList();
            }
            ViewData["CurrentAccount"] = account;
            return View(CinemaDbContext);
        }

        public void SendConfirmationEmail(string toEmail, string filmName, string screeningTime)
        {
            string smtpServer = "smtp.gmail.com";
            int port = 587; // Port của SMTP server, thường là 587 hoặc 465
            string fromEmail = "nguyenhoanglong0165@gmail.com"; // Email của bạn
            string password = "txow zcij jxlt klxb\r\n"; // Mật khẩu của bạn

            SmtpClient client = new SmtpClient(smtpServer);
            client.Port = port;
            client.Credentials = new NetworkCredential(fromEmail, password);
            client.EnableSsl = true; // Kích hoạt SSL

            MailMessage message = new MailMessage(fromEmail, toEmail);
            message.Subject = "Xác nhận đặt vé";
            message.Body = $"Bạn đã đặt vé cho phim {filmName} vào lúc {screeningTime}. Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.";

            client.Send(message);
        }
        /* booking*/
        public IActionResult Book(int selectedFilmId)
        {
            
            var selectedFilm = dbContext.Films.FirstOrDefault(f => f.FilmId == selectedFilmId);
            if (selectedFilm == null)
            {
                // Xử lý trường hợp không tìm thấy đối tượng Film
                return NotFound();
            }

            ViewData["Selected"] = selectedFilm;

            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });

            var screenings = dbContext.ScreeningFilms
        .Where(sf => sf.FilmId == selectedFilmId) // Lọc các bản ghi có FilmId tương ứng
        .Select(sf => sf.Screening) // Lấy thông tin của các suất chiếu
        .ToList();
            ViewBag.Screenings = screenings;
             
            return View();
        }

        [BindProperty]
        public Ticket Ticket { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Book()
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });
            var account = dbContext.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taiKhoanId));
            
            if (account == null) return NotFound();

            if (ModelState.IsValid)
            {
                Ticket.AccountId = account.AccountId;

                var screening = dbContext.Screenings
            .Include(s => s.Tickets)
            .FirstOrDefault(s => s.ScreeningId == Ticket.ScreeningId);

                if (screening != null)
                {
                    int totalSeats = screening.TotalSeats ?? 0;
                    int bookedTickets = screening.Tickets.Count();

                    if (bookedTickets >= totalSeats)
                    {
                        // Số vé đã đặt đã đạt tối đa
                        ViewBag.Error = "Không còn vé trống cho suất chiếu này.";
                        return View();
                    }
                }

                Ticket.Screening = dbContext.Screenings.First(screen => screen.ScreeningId == Ticket.ScreeningId);
                dbContext.Tickets.Add(Ticket);
                dbContext.SaveChanges();

                //Gui mail
                SendConfirmationEmail(account.Email, Ticket.FilmName, Ticket.Screening.StartTime.ToString());
            }
            return RedirectToAction("Index","Tickets",new { Area = "Admin" });
        }

        public IActionResult Create()
        {
            Ticket ticket = new Ticket();

            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });

            List<Screening> screenings = dbContext.Screenings.ToList();
            List<Film> films = dbContext.Films.ToList();
            ViewBag.Films = films;
            ViewBag.Screenings = screenings;

            return View(ticket);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });
            var account = dbContext.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taiKhoanId));

            if (account == null) return NotFound();

            if (ModelState.IsValid)
            {
                Ticket.AccountId = account.AccountId;

                Ticket.FilmId =  Ticket.FilmId;
                Ticket.FilmName = dbContext.Films.FirstOrDefault(u => u.FilmId == Ticket.FilmId).FilmName;
                Ticket.Screening = dbContext.Screenings.First(screen => screen.ScreeningId == Ticket.ScreeningId);
                dbContext.Tickets.Add(Ticket);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var TicketToDelete = dbContext.Tickets.FirstOrDefault(u => u.TicketId == id);
            if (TicketToDelete != null)
            {
                dbContext.Tickets.Remove(TicketToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts");
            var account = dbContext.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taiKhoanId));
            if (account == null) return NotFound();

            // Tìm Ticket cần chỉnh sửa từ cơ sở dữ liệu
            Ticket = dbContext.Tickets.Include(u => u.Screening).FirstOrDefault(Ticket => Ticket.TicketId == id);
            if (Ticket != null)
            {
                ViewData["CurrentAccount"] = account;
                return View(Ticket);
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            Ticket = dbContext.Tickets.FirstOrDefault(Ticket => Ticket.TicketId == id);
            if (Ticket != null)
            {
                if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
                var taiKhoanId = HttpContext.Session.GetString("AccountId");
                if (taiKhoanId == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" });

                List<Screening> screenings = dbContext.Screenings.ToList();
                List<Account> accounts = dbContext.Accounts.ToList();
                List<Film> films = dbContext.Films.ToList();

                ViewBag.Screenings = screenings;
                ViewBag.Accounts = accounts;
                ViewBag.Films = films;
                return View(Ticket);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if (id != Ticket.TicketId)
            {
                return NotFound();
            }

            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taiKhoanId = HttpContext.Session.GetString("AccountId");
            if (taiKhoanId == null) return RedirectToAction("Login", "Accounts", new { Area = "Admin" }) ;
            var account = dbContext.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taiKhoanId));
            if (account == null) return NotFound();
            
             
            if(account.RoleId != 1)
            {
                if (Ticket.AccountId != account.AccountId) return RedirectToAction(nameof(Index));
            }

             
            if (ModelState.IsValid)
            {
                Ticket.FilmId = Ticket.FilmId;
                Ticket.FilmName = dbContext.Films.FirstOrDefault(u => u.FilmId == Ticket.FilmId).FilmName;
                Ticket.Screening = dbContext.Screenings.FirstOrDefault(screen => screen.ScreeningId == Ticket.ScreeningId);
                dbContext.Update(Ticket);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "Tickets");
        }
    }
}
