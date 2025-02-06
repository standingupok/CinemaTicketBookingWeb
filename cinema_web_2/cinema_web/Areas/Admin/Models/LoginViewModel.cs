using System.ComponentModel.DataAnnotations;

namespace cinema_web.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [Key]
        [MaxLength(50)]
        [Required(ErrorMessage ="Vui lòng nhập Email")]
        [Display(Name ="Địa chỉ Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Vui lòng nhập Email")]
        public string Email { get; set; }

        [Display(Name ="Mật khẩu")]
        [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
        [MaxLength(30, ErrorMessage ="Mật khẩu có tối đa 30 kí tự")]
        public string Password { get; set; }
    }
}
