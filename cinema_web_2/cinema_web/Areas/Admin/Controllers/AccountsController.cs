using cinema_web.Areas.Admin;
using cinema_web.Areas.Admin.Models;
using cinema_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AccountsController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public AccountsController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {

            IEnumerable<Account> lstAccounts = dbContext.Accounts.Include(a => a.Role);
            return View(lstAccounts);
        }

        [AllowAnonymous]
        [Route("dang-ky.html", Name = "Create")]
        public IActionResult Create()
        {
            Account Account = new Account();
            List<Role> roles = dbContext.Roles.ToList();
            ViewBag.Roles = roles;
            return View(Account);
        }

        [BindProperty]
        public Account Account { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "Create")]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                Account.RoleId = 3;
                dbContext.Accounts.Add(Account);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var AccountToDelete = dbContext.Accounts.FirstOrDefault(u => u.AccountId == id);
            if (AccountToDelete != null)
            {
                dbContext.Accounts.Remove(AccountToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            // Tìm Account cần chỉnh sửa từ cơ sở dữ liệu
            Account = dbContext.Accounts.FirstOrDefault(Account => Account.AccountId == id);
            if (Account != null)
            {
                return View(Account);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Account = dbContext.Accounts.FirstOrDefault(Account => Account.AccountId == id);
            if (Account != null)
            {
                List<Role> roles = dbContext.Roles.ToList();
                ViewBag.Roles = roles;
                return View(Account);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Accounts");
            }

            if (ModelState.IsValid)
            {
                dbContext.Update(Account);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "Accounts");
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name ="Login")]
        public IActionResult Login() {
            var taikhoanId = HttpContext.Session.GetString("AccountId");
            if (taikhoanId != null) return RedirectToAction("Index", "Home");
            return View();
        }

        
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                if(ModelState.IsValid) {
                    Account kh = dbContext.Accounts.Include(p => p.Role).SingleOrDefault(p => p.Email.ToLower() == model.Email.ToLower().Trim()); 
                    if (kh == null)
                    {
                        ViewBag.Error = "Email dang nhap chua chinh xac";
                        return View(model);
                    }

                    string pass = (model.Password.Trim());
                    if(kh.Password.Trim() != pass)
                    {
                        ViewBag.Error = "Mat khau dang nhap chua chinh xac";
                        return View(model);
                    }

                    dbContext.Update(kh);
                    await dbContext.SaveChangesAsync();

                    var taiKhoanId = HttpContext.Session.GetString("AccountId");
                    HttpContext.Session.SetString("AccountId", kh.AccountId.ToString());

                    var userClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, kh.FullName),
                        new Claim(ClaimTypes.Email, kh.Email),
                        new Claim("AccountId", kh.AccountId.ToString()),
                        new Claim("RoleId", kh.Role.ToString()),
                        new Claim(ClaimTypes.Role, kh.Role.RoleName)
                    };

                    var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                    await HttpContext.SignInAsync(userPrincipal);
                    
                    return RedirectToAction("Index", "Home", new { Area = "" });
                }
                ModelState.AddModelError("", "Đăng nhập thất bại");
            }
            catch
            {
                return RedirectToAction("Login", "Accounts", new { Area = "Admin" });
            }
            return RedirectToAction("Login", "Accounts", new { Area = "Admin" });
        }

        [AllowAnonymous]
        [Route("dang-xuat.html", Name ="Logout")]
        public IActionResult Logout()
        {
            try
            {
                HttpContext.SignOutAsync();

                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
        
    }
}
