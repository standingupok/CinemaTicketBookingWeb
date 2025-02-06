using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace cinema_web.Models
{
    public partial class Screening
    {
        public Screening()
        {
            ScreeningFilms = new HashSet<ScreeningFilm>();
            Tickets = new HashSet<Ticket>();
        }

        [Display(Name = "Id suất chiếu")]
        public int ScreeningId { get; set; }

        [Display(Name = "Suất chiếu")]
        public TimeSpan StartTime { get; set; }

        [Display(Name = "Thời lượng")]
        public int TimeDuration { get; set; }

        [Display(Name = "Tổng số ghế")]
        public int? TotalSeats { get; set; }

        public virtual ICollection<ScreeningFilm> ScreeningFilms { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
