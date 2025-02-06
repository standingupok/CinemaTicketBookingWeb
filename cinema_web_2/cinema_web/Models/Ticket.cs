using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace cinema_web.Models
{
    public partial class Ticket
    {
        [Display(Name = "Id vé")]
        public int TicketId { get; set; }

        [Display(Name = "Id tài khoản")]
        public int? AccountId { get; set; }

        [Display(Name = "Id suất chiếu")]
        public int? ScreeningId { get; set; }

        [Display(Name = "Ghế")]
        public string SeatNumber { get; set; }

        [Display(Name = "Tên phim")]
        public string FilmName { get; set; }
        [Display(Name = "Id phim")]

        public int? FilmId { get; set; }

        [Display(Name = "Ngày xem")]
        public DateTime? ScreeningDate { get; set; }

        [Display(Name = "Giá vé")]
        public long? TicketPrice { get; set; }

        public virtual Account Account { get; set; }
        public virtual Screening Screening { get; set; }
    }
}
