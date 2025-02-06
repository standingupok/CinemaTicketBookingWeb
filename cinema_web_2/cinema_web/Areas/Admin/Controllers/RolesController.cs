using cinema_web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cinema_web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        private readonly CinemaDbContext dbContext;
        public RolesController(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Role> lstRoles = dbContext.Roles.ToList();
            return View(lstRoles);
        }

        public IActionResult Create()
        {
            Role role = new Role();
            return View(role);
        }
        [BindProperty]
        public Role Role { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int id)
        {
            if (ModelState.IsValid)
            {
                dbContext.Roles.Add(Role);
                dbContext.SaveChanges();
            }
             return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var roleToDelete = dbContext.Roles.FirstOrDefault(u => u.RoleId == id);
            if(roleToDelete != null)
            {
                dbContext.Roles.Remove(roleToDelete);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            // Tìm role cần chỉnh sửa từ cơ sở dữ liệu
            Role = dbContext.Roles.FirstOrDefault(role => role.RoleId == id);
            if (Role != null)
            {
                return View(Role); // Trả về trang 404 nếu không tìm thấy role
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Role = dbContext.Roles.FirstOrDefault(role => role.RoleId == id);
            if(Role != null)
            {
                return View(Role);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index", "Roles");
            }

            if (ModelState.IsValid)
            {
                dbContext.Update(Role);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "Roles");
        }

    }
}
