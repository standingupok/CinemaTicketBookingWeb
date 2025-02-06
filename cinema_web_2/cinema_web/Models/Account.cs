using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace cinema_web.Models
{
    public partial class Account
    {
        public Account()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Display(Name = "Id tài khoản")]
        public int AccountId { get; set; }

        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }

        [Display(Name = "Địa chỉ Email")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Vai trò")]
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
