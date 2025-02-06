using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace cinema_web.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }


        [Display(Name = "Id vai trò")]
        public int RoleId { get; set; }

        [Display(Name = "Vai trò")]
        public string RoleName { get; set; }

        [Display(Name = "Mô tả")]
        public string RoleDes { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
